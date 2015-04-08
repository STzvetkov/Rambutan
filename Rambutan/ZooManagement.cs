using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Zoo.Animals;
using Zoo.Employees;
using Zoo.BudgetInfo;
using Zoo.Common;
using Zoo.Exceptions;
using Zoo.Animals.Consumables;
using Zoo.Animals.Species.Aquatic;
using Zoo.Animals.Species.Bird;
using Zoo.Animals.Species.Terrestrial;

namespace Zoo
{
    [Version(VersionAttribute.Type.ZooManagementTool, "Rambutan Zoo", "1.0.0")]
    public static class ZooManagement
    {
        public const string FolderName = @"../../DB/";

        // Stores all employees
        private static List<Employee> staffDB;

        // Stores all animals in the zoo
        public static List<Animal> animalsDB;

        // Stores all cages
        public static List<Cage> cagesDB;

        // Stores all food storages
        public static List<FoodStorage> foodStoragesDB;

        static ZooManagement()
        {
            animalsDB = new List<Animal>();
            staffDB = new List<Employee>();
            cagesDB = new List<Cage>();
            foodStoragesDB = new List<FoodStorage>();
            BudgetInfo = Budget.Instance;
        }

        public static void Init()
        {
        }

        // Load DB from files 
        private static void LoadData()
        {
            string[] fileEntries = Directory.GetFiles(FolderName);
            string[] fileData;
            string[] objectData;
            Object[] args = new Object[20];
            foreach (string fullFileName in fileEntries)
            {
                fileData = File.ReadAllLines(fullFileName);
                string dbName = System.IO.Path.GetFileName(fullFileName).Replace(".txt", "");
                foreach (var record in fileData)
                {
                    objectData = record.Split('#');
                    for (int i = 1; i < objectData.Length; i++)
                    {
                        args[i - 1] = objectData[i];
                    }
                    switch (dbName)
                    {
                        case "animals":
                            Animal animal = (Animal)Activator.CreateInstance(Type.GetType(objectData[0]), args);
                            AcquireAnimal(animal);
                            break;
                        case "budget":
                            BudgetInfo = (Budget)Activator.CreateInstance(Type.GetType(objectData[0]), args);
                            break;
                        case "cages":
                            Cage cage = (Cage)Activator.CreateInstance(Type.GetType(objectData[0]), args);
                            cagesDB.Add(cage);
                            break;
                        case "employees":
                            Employee employee = (Employee)Activator.CreateInstance(Type.GetType(objectData[0]), args);
                            staffDB.Add(employee);
                            break;
                        case "food":
                            FoodStorage food = (FoodStorage)Activator.CreateInstance(Type.GetType(objectData[0]), args);
                            foodStoragesDB.Add(food);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        // Budget info
        public static Budget BudgetInfo { get; set; }

        // Employees management
        public static void HireEmployee(Employee employee)
        {
            staffDB.Add(employee);
        }

        public static void DischargeEmployee(long employeeID)
        {
            try
            {
                Employee employToBeDischarged = staffDB.Find(x => x.StaffID == employeeID);
                staffDB.Remove(employToBeDischarged);
            }
            catch (Exception)
            {
                throw new UnitNotFoundException("There is no Employee with such ID!");
            }
        }

        public static string ExtractEmployeeBasicInfo()
        {
            /*var sortedEmployees = from employee in EmployeeDB
            where ;*/
            return "";
        }

        public static int CountEmployeesByPosition(Position position)
        {
            var querySelectedAnimals =
                                      from employee in staffDB
                                      where employee.Position == position
                                      select employee;
            return querySelectedAnimals.Count();
        }

        // Animals management
        public static void AcquireAnimal(Animal animal)
        {
            if (animal == null)
            {
                throw new NullReferenceException("There is no animal provided!");
            }
            animalsDB.Add(animal);
        }

        public static void BuyAnimal(Animal animal)
        {
            AcquireAnimal(animal);
            BudgetInfo.AddExpense(animal.Type.ToString(), animal.Price);
        }

        public static void SellAnimal(long animalID)
        {
            try
            {
                Animal animalToBeSold = animalsDB.Find(x => x.AnimalID == animalID);
                animalsDB.Remove(animalToBeSold);
                BudgetInfo.AddIncome(animalToBeSold.Type.ToString(), animalToBeSold.Price);
            }
            catch (Exception)
            {
                throw new UnitNotFoundException("There is no Animal with such ID!");
            }
        }

        // Cages management
        public static void BuildCage(Cage cage)
        {
            cagesDB.Add(cage);
            Budget.Instance.AddExpense(cage.Type.ToString(), cage.Price);
        }

        public static void DemolishCage(long cageID)
        {
            try
            {
                Cage cageToBeDemolished = cagesDB.Find(x => x.CageID == cageID);
                cagesDB.Remove(cageToBeDemolished);
            }
            catch (Exception)
            {
                throw new UnitNotFoundException("There is no Cage with such ID!");
            }
        }

        public static int CountCagesByTypeAndOccupation(HabitatType cageType, int numberAnimals)
        {
            var querySelectedCages =
                                    from cage in cagesDB
                                    where cage.Type == cageType && cage.AnimalsInCage.Count == numberAnimals
                                    select cage;
            return querySelectedCages.Count();
        }

        // Food storages management
        public static void BuyFoodStorge(FoodStorage foodStorage)
        {
            if (foodStorage == null)
            {
                throw new NullReferenceException("There is no food storage provided!");
            }
            foodStoragesDB.Add(foodStorage);
            BudgetInfo.AddExpense(foodStorage.Type.ToString(), foodStorage.Price);
        }

        public static void DiscardFoodStorage(long storageID)
        {
            try
            {
                FoodStorage storageToBeDiscarded = foodStoragesDB.Find(x => x.StorageID == storageID);
                foodStoragesDB.Remove(storageToBeDiscarded);
            }
            catch (Exception)
            {
                throw new UnitNotFoundException("There is no food storage with such ID!");
            }
        }

        public static int CountAnimalsByType(AnimalSpeciesType animalType)
        {
            var querySelectedAnimals =
                                      from animal in animalsDB
                                      where animal.Type == animalType
                                      select animal;
            return querySelectedAnimals.Count();
        }
    }
}
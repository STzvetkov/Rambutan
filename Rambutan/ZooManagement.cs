using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Animals;
using Zoo.Employees;
using Zoo.BudgetInfo;
using Zoo.Common;
using Zoo.Exceptions;
using Zoo.Animals.Consumables;

namespace Zoo
{
    [Version(VersionAttribute.Type.ZooManagementTool, "Rambutan Zoo", "1.0.0")]
    public static class ZooManagement
    {
        static ZooManagement()
        {
            AnimalsDB = new List<Animal>();
            StaffDB = new List<Employee>();
            CagesDB = new List<Cage>();
        }

        // Stores all employees
        public static List<Employee> StaffDB { get; private set; }

        // Stores all animals in the zoo
        public static List<Animal> AnimalsDB { get; private set; }

        // Stores all cages
        public static List<Cage> CagesDB { get; private set; }

        // Stores all food storages
        public static List<FoodStorage> FoodStoragesDB { get; private set; }

        // Employees management
        public static void HireEmployee(Employee employee)
        {
            StaffDB.Add(employee);
        }

        public static void DischargeEmployee(long employeeID)
        {
            try
            {
                Employee employToBeDischarged = StaffDB.Find(x => x.StaffID == employeeID);
                StaffDB.Remove(employToBeDischarged);
            }
            catch (Exception)
            {
                throw new UnitNotFoundException("There is no Employee with such ID!");
            }
        }

        // Animals management
        public static void BuyAnimal(Animal animal)
        {
            if (animal == null)
            {
                throw new NullReferenceException("There is no animal provided!");
            }
            AnimalsDB.Add(animal);
            Budget.Instance().AddExpense(animal.Type.ToString(), animal.Price);
        }

        public static void SellAnimal(long animalID)
        {
            try
            {
                Animal animalToBeSold = AnimalsDB.Find(x => x.AnimalID == animalID);
                AnimalsDB.Remove(animalToBeSold);
                Budget.Instance().AddIncome(animalToBeSold.Type.ToString(), animalToBeSold.Price);
            }
            catch (Exception)
            {
                throw new UnitNotFoundException("There is no Animal with such ID!");
            }
        }

        // Cages management
        public static void BuildCage(Cage cage)
        {
            CagesDB.Add(cage);
            Budget.Instance().AddExpense(cage.Type.ToString(), cage.Price);
        }

        public static void DemolishCage(long cageID)
        {
            try
            {
                Cage cageToBeDemolished = CagesDB.Find(x => x.CageID == cageID);
                CagesDB.Remove(cageToBeDemolished);
            }
            catch (Exception)
            {
                throw new UnitNotFoundException("There is no Cage with such ID!");
            }
        }

        public static int CountCagesByTypeAndOccupation(HabitatType cageType, int numberAnimals)
        {
            var querySelectedCages =
                                    from cage in CagesDB
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
            FoodStoragesDB.Add(foodStorage);
            Budget.Instance().AddExpense(foodStorage.Type.ToString(), foodStorage.Price);
        }

        public static void DiscardFoodStorage(long storageID)
        {
            try
            {
                FoodStorage storageToBeDiscarded = FoodStoragesDB.Find(x => x.StorageID == storageID);
                FoodStoragesDB.Remove(storageToBeDiscarded);
            }
            catch (Exception)
            {
                throw new UnitNotFoundException("There is no food storage with such ID!");
            }
        }

        public static int CountAnimalsByType(AnimalSpeciesType animalType)
        {
            var querySelectedAnimals =
                                      from animal in AnimalsDB
                                      where animal.Type == animalType
                                      select animal;
            return querySelectedAnimals.Count();
        }
    }
}
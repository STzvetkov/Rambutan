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

namespace Zoo
{
   [Version(VersionAttribute.Type.ZooManagementTool, "Rambutan Zoo", "1.0.0")]
    public class ZooManagement
    {
       
        public ZooManagement()
        {
            this.AnimalsDB = new List<Animal>();
            this.StaffDB = new List<Employee>();
            this.CagesDB = new List<Cage>();
        }

        // Stores all employees
        public List<Employee> StaffDB { get; private set; }       


        // Stores all animals in the zoo
        public List<Animal> AnimalsDB { get; private set; }

        // Stores all cages
        public List<Cage> CagesDB { get; private set; }
        
        public void HireEmployee(Employee employee)
        {

            this.StaffDB.Add(employee);
           
        }

        public void DischargeEmployee(long employeeID)
        {            
            try
            {
                Employee employToBeDischarged = this.StaffDB.Find(x => x.StaffID == employeeID);
                this.StaffDB.Remove(employToBeDischarged);
            }
            catch (Exception)
            {
               throw new UnitNotFoundException("There is no Employee with such ID!");
            }
           
        }

        public void BuyAnimal(Animal animal)
        {
            this.AnimalsDB.Add(animal);
            Budget.Instance().AddExpense(animal.Type.ToString(), animal.Price);
        }

        public void SellAnimal(long animalID)
        {            
            try
            {
                Animal animalToBeSold = this.AnimalsDB.Find(x => x.AnimalID == animalID);
                this.AnimalsDB.Remove(animalToBeSold);
                Budget.Instance().AddIncome(animalToBeSold.Type.ToString(), animalToBeSold.Price);
            }
            catch (Exception)
            {
                throw new UnitNotFoundException("There is no Animal with such ID!");
            }
        }

        public void BuildCage(Cage cage)
        {
            this.CagesDB.Add(cage);
            Budget.Instance().AddExpense(cage.Type.ToString(), cage.Price);
        }

        public void DemolishCage(long cageID)
        {            
            try
            {
                Cage cageToBeDemolished = this.CagesDB.Find(x => x.CageID == cageID);
                this.CagesDB.Remove(cageToBeDemolished);
            }
            catch (Exception)
            {
                throw new UnitNotFoundException("There is no Cage with such ID!");
            }
        }
    }
}
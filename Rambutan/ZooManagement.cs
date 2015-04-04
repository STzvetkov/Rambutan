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
            Employee employToBeDischarged = this.StaffDB.Find(x => x.StaffID == employeeID);
            try
            {
                this.StaffDB.Remove(employToBeDischarged);
            }
            catch (EmployeeNotFoundException)
            {
                
                throw;
            }
           
        }

        public void BuyAnimal(Animal animal)
        {
            this.AnimalsDB.Add(animal);
            Budget.Instance().AddExpense(animal.Type.ToString(), animal.Price);
        }

        public void SellAnimal(long animalID)
        {
            Animal animalToBeSold = this.AnimalsDB.Find(x => x.AnimalID == animalID);
            try
            {
                this.AnimalsDB.Remove(animalToBeSold);
                Budget.Instance().AddIncome(animalToBeSold.Type.ToString(), animalToBeSold.Price);
            }
            catch (AnimalNotFoundException)
            {
                throw;
            }
        }

        public void BuildCage(Cage cage)
        {
            this.CagesDB.Add(cage);
            Budget.Instance().AddExpense(cage.Type.ToString(), cage.Price);
        }

        public void DemolishCage(long cageID)
        {
            Cage cageToBeDemolished = this.CagesDB.Find(x => x.CageID == cageID);
            try
            {
                this.CagesDB.Remove(cageToBeDemolished);
            }
            catch (CageNotFoundException)
            {
                throw;
            }
        }
    }
}
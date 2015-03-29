using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Animals;
using Zoo.Employees;
using Zoo.BudgetInfo;

namespace Zoo
{
    public class ZooManagement
    {
        public ZooManagement()
        {
            this.AnimalsDB = new List<Animal>();
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
            //Budget.Instance().AddExpense(employee.Position, employee.);
        }

        public void DischargeEmployee(long employeeID)
        {
            Employee employToBeDischarged = this.StaffDB.Find(x => x.StaffID == employeeID);
            this.StaffDB.Remove(employToBeDischarged);
        }

        public void BuyAnimal(Animal animal)
        {
            this.AnimalsDB.Add(animal);
            //Budget.Instance().AddExpense(animal.type, animal.cost);
        }

        public void SellAnimal(long animalID)
        {
        }
    }
}
namespace Zoo.Employees
{
    using System;

    public class Director : Employee
    {
        //Fields 
        private decimal montlySalary;
        private int employeesToManage; //??
        private decimal privateBudget; // money for meetings, taxi, etc.


        // Constructors
        public Director(string firstName, string lastName)
            :base(firstName, lastName, "Director") // it is better to make it through an enumerator Position.Director or a class Positions
        
        // Properties

        public decimal MontlySalary { get; set; }
        public int EmplayeesToManage { get; set; }
        public decimal PrivateBudget { get; set; }

        /* Methods

        public void Hire(Employee hired)
        {
        allEmployees.Add(hired)
        }

        public void Fire(Employee fired)
        {
        allEmplotees.Remove(fired)
        }
        */
    }
}

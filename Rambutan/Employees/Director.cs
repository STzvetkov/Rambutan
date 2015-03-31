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
            : base(firstName, lastName, Position.Director) // it is better to make it through an enumerator Position.Director or a class Positions
        {
        }
        
        // Properties

        public decimal MontlySalary 
        {
            get { return this.montlySalary; }
            set { this.montlySalary = value; }
        }

        public int EmplayeesToManage
        {
            get { return this.employeesToManage; }
            set { this.employeesToManage = value; }
        }

        public decimal PrivateBudget
        {
            get { return this.privateBudget; }
            set { this.privateBudget = value; }
        }

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

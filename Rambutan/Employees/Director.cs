namespace Zoo.Employees
{
    using System;
    using Zoo.Interfaces;

    public class Director : Employee
    {
        //Fields 
        private double montlySalary;
        private int employeesToManage; //??
        private double privateBudget; // money for meetings, taxi, etc.

        // Constructors
        public Director(string firstName, string lastName)
            : base(firstName, lastName, Position.Director) // it is better to make it through an enumerator Position.Director or a class Positions
        {
        }

        // Properties

        public double MontlySalary
        {
            get { return this.montlySalary; }
            set { this.montlySalary = value; }
        }

        public int EmplayeesToManage
        {
            get { return this.employeesToManage; }
            set { this.employeesToManage = value; }
        }

        public double PrivateBudget
        {
            get { return this.privateBudget; }
            set { this.privateBudget = value; }
        }

        //public double CalculatePayment(double hours)
        //{
        //    return montlySalary;
        //}
    }
}

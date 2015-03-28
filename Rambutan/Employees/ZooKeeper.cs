namespace Zoo.Employees
{
    using System;

    public class ZooKeeper : Employee
    {
        private double hourlyRate;
        private double hoursWorked;

        public ZooKeeper()
        {
        }

        public ZooKeeper(string firstName, string lastName)
            : base(firstName, lastName, "ZooKeeper")
        {
        }

        // TODO : Implement more constructors.

        public double HourlyRate
        {
            get { return this.hourlyRate; }
            set { this.hourlyRate = value; }
        }

        public double HoursWorked
        {
            get { return this.hoursWorked; }
            set { this.hoursWorked = value; }
        }
    }
}

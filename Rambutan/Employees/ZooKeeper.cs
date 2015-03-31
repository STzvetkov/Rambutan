namespace Zoo.Employees
{
    using System;

    public class ZooKeeper : Employee
    {
        private double hourlyRate;
        private double hoursWorked;

        public ZooKeeper()
            :base(Position.ZooKeeper)
        {
        }

        public ZooKeeper(string firstName, string lastName)
            : base(firstName, lastName, Position.ZooKeeper)
        {
        }

        // TODO : Implement more constructors.

        protected override string GetSpecifics()
        {
            return string.Format("Hourly rate: {0:C} \nHours worked: {1}", this.hourlyRate, this.hoursWorked);
        }

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

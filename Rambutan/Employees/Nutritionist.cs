namespace Zoo.Employees
{
    using System;

    public class Nutritionist : Employee
    {
        private double monthlySalary;
        private int animalsFedDaily;

        public Nutritionist()
        {
        }

        public Nutritionist(string firstName, string lastName)
            : base(firstName, lastName, "Nutritionist")
        {
        }

        // TODO : Implement more constructors.

        public double MonthlySalary
        {
            get { return this.monthlySalary; }
            set { this.monthlySalary = value; } // TODO : Enter checks.
        }

        public int AnimalsTreatedDaily
        {
            get { return this.animalsFedDaily; }
            set { this.animalsFedDaily = value; } // TODO : Enter checks. Should be private.
        }
    }
}

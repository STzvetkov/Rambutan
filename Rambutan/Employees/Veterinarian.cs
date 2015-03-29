namespace Zoo.Employees
{
    using System;

    public class Veterinarian : Employee
    {
        private decimal monthlySalary;
        private int animalsTreatedDaily;

        public Veterinarian()
        {
        }

        public Veterinarian(string firstName, string lastName)
            :base(firstName,lastName,"Veterinarian")
        {
        }

        // TODO : Implement more constructors.

        protected override string GetSpecifics()
        {
            return string.Format("Monthly salary: {0:C} \nAnimals treated daily: {1}", this.monthlySalary,this.animalsTreatedDaily);
        }

        public decimal MonthlySalary
        {
            get { return this.monthlySalary; }
            set { this.monthlySalary = value; } // TODO : Enter checks.
        }

        public int AnimalsTreatedDaily
        {
            get { return this.animalsTreatedDaily; }
            set { this.animalsTreatedDaily = value; } // TODO : Enter checks. Should be private.
        }
    }
}

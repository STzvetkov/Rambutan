namespace Zoo.Employees
{
    using System;

    public class Nutritionist : Employee
    {
        private decimal monthlySalary;
        private int animalsFedDaily;

        public Nutritionist()
        {

        }

        public Nutritionist(string firstName, string lastName)
            : base(firstName, lastName, "Nutritionist")
        {

        }

        // TODO : Implement more constructors.


        protected override string GetSpecifics()
        {
            return string.Format("Monthly salary: {0:C} \nAnimals fed daily: {1}", this.monthlySalary, this.animalsFedDaily);
        }
        
        public decimal MonthlySalary
        {
            get { return this.monthlySalary; }
            set { this.monthlySalary = value; } // TODO : Enter checks.
        }

        public int AnimalsFedDaily
        {
            get { return this.animalsFedDaily; }
            set { this.animalsFedDaily = value; } // TODO : Enter checks. Should be private.
        }
    }
}

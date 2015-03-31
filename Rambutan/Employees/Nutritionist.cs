namespace Zoo.Employees
{
    using System;

    using Zoo.Interfaces;

    public class Nutritionist : Employee, IPayable
    {
        private int animalsFedDaily;
        private PaymentTypes paymentType;
        private double paymentRate;
        private double workedTime;

        public Nutritionist()
            :base(Position.Nutritionist)
        {
        }

        public Nutritionist(string firstName, string lastName)
            : base(firstName, lastName, Position.Nutritionist)
        {
        }

        // TODO : Implement more constructors.

        public double CalculatePayment(double hours)
        {
            return this.workedTime*this.paymentRate;
        }

        protected override string GetSpecifics()
        {
            return string.Format("Payment rate: {0:C}/{1} \nAnimals fed daily: {2}", this.paymentRate,this.PaymentType, this.animalsFedDaily);
        }
        
        public int AnimalsFedDaily
        {
            get { return this.animalsFedDaily; }
            set { this.animalsFedDaily = value; } // TODO : Enter checks. Should be private.
        }

        public PaymentTypes PaymentType
        {
            get { return this.paymentType; }
            set { this.paymentType = value; }
        }

        public double PaymentRate
        {
            get { return this.paymentRate; }
            set { this.paymentRate = value; }
        }

        public double WorkedTime
        {
            get { return this.workedTime; }
            set { this.workedTime = value; }
        }
    }
}

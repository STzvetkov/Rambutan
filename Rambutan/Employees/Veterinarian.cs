namespace Zoo.Employees
{
    using System;

    using Zoo.Interfaces;

    public class Veterinarian : Employee, IPayable
    {
        private int animalsTreatedDaily;
        private PaymentTypes paymentType;
        private double paymentRate;
        private double workedTime;

        public Veterinarian()
            :base(Position.Veterinarian)
        {
        }

        public Veterinarian(string firstName, string lastName)
            : base(firstName, lastName, Position.Veterinarian)
        {
        }

        // TODO : Implement more constructors.
        public double CalculatePayment(double hours)
        {
            this.workedTime = hours;
            var normalWorkDay = 8;
            if (paymentType == PaymentTypes.Hourly)
            {
                return this.workedTime * this.paymentRate;
            }
            else
            {
                return (this.workedTime / normalWorkDay) * this.paymentRate;
            }

        }

        protected override string GetSpecifics()
        {
            return string.Format("Payment rate: {0:C}/{1} \nAnimals treated daily: {2}", this.paymentRate, this.PaymentType, this.animalsTreatedDaily);
        }

        public int AnimalsTreatedDaily
        {
            get { return this.animalsTreatedDaily; }
            set { this.animalsTreatedDaily = value; } // TODO : Enter checks. Should be private.
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

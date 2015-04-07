namespace Zoo.Employees
{
    using System;
    using System.Text;

    using Zoo.Interfaces;

    public class Veterinarian : Employee, IEmployee, IPayable
    {
        private int animalsTreatedDaily;
        private PaymentTypes paymentType;
        private double paymentRate;
        private double workedTime;

        public Veterinarian()
            : base(Position.Veterinarian)
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

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(base.ToString());
            result.AppendLine(string.Format("Payment rate: {0:C}/{1} \nAnimals treated daily: {2}", this.paymentRate, this.PaymentType, this.animalsTreatedDaily));

            return result.ToString();
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

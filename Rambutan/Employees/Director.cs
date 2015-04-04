namespace Zoo.Employees
{
    using System;
    using Zoo.Interfaces;

    public class Director : Employee, IPayable
    {
        //Fields
        private double paymentRate;
        private double workedTime;
        private double privateBudget; // money for meetings, taxi, etc.   




        // Constructors
        public Director(string firstName, string lastName, double paymentRate)
            : base(firstName, lastName, Position.Director) // it is better to make it through an enumerator Position.Director or a class Positions
        {
            this.paymentRate = paymentRate;
        }

        // Properties
        public PaymentTypes PaymentType { get; set; }
        public double PaymentRate
        {
            get
            {
                return this.paymentRate;
            }
            set
            {
                if (value < 0.00)
                {
                    throw new ArgumentException("PaymentRate", "Payment rate cannot be negative!");
                }
                this.paymentRate = value;
            }
        }
        public double WorkedTime { get; set; }


        public double PrivateBudget
        {
            get { return this.privateBudget; }
            set { this.privateBudget = value; }
        }

        // Methods
        public double CalculatePayment(double hours)
        {
            this.workedTime = hours;
            var normalWorkDay = 8;
            if (this.PaymentType == PaymentTypes.Hourly)
            {
                return this.workedTime * this.paymentRate;
            }
            else
            {
                return (this.workedTime / normalWorkDay) * this.paymentRate;
            }
        }


    }
}

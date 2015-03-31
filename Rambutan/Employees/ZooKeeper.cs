namespace Zoo.Employees
{
    using System;

    using Zoo.Interfaces;

    public class ZooKeeper : Employee, IPayable
    {
        private PaymentTypes paymentType;
        private double paymentRate;
        private double workedTime;

        public ZooKeeper()
            :base(Position.ZooKeeper)
        {
        }

        public ZooKeeper(string firstName, string lastName)
            : base(firstName, lastName, Position.ZooKeeper)
        {
        }

        // TODO : Implement more constructors.

        public double CalculatePayment()
        {
            return this.workedTime * this.paymentRate;
        }

        protected override string GetSpecifics()
        {
            return string.Format("Payment: {0:C} \nHours worked: {1}", this.CalculatePayment(), this.workedTime);
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

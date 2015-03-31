namespace Zoo.Employees
{
    using System;

    using Zoo.Interfaces;

    public enum Shift
    {
        Day,
        Night
    }

    public class ZooKeeper : Employee, IPayable
    {
        private PaymentTypes paymentType;
        private double paymentRate;
        private double workedTime;
        private Shift shift;

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
            return string.Format("Payment rate: {0:C}/{1} \n Shift:{2} ",this.paymentRate,this.PaymentType, this.shift);
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

        public Shift Shift
        {
            get { return this.shift; }
            set { this.shift = value; }
        }
    }
}

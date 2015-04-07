namespace Zoo.Employees
{
    using System;
    using System.Text;

    using Zoo.Interfaces;

    public class ZooKeeper : Employee, IEmployee, IPayable
    {
        private PaymentTypes paymentType;
        private double paymentRate;
        private double workedTime;
        private Shift shift;

        public ZooKeeper()
            : base(Position.ZooKeeper)
        {
        }

        public ZooKeeper(string firstName, string lastName)
            : base(firstName, lastName, Position.ZooKeeper)
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
            result.AppendLine(string.Format("Payment rate: {0:C}/{1} \n Shift:{2} ", this.paymentRate, this.PaymentType, this.shift));

            return result.ToString();
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

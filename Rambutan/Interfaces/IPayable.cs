namespace Zoo.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public enum PaymentTypes
    {
        Monthly,
        Hourly
    }
    public interface IPayable
    {
        double CalculatePayment(double hours);

        PaymentTypes PaymentType { get; }

        double PaymentRate { get; }

        double WorkedTime { get; }
    }
}

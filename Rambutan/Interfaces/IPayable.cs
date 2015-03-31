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
        double CalculatePayment();
        
        PaymentTypes PaymentType { get; set; }
        double PaymentRate { get; set; }

        double WorkedTime { get; set; }
    }
}

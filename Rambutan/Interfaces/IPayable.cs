using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Interfaces
{
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

        DateTime WorkedTime { get; set; }
    }
}

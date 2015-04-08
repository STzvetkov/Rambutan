namespace Zoo.Interfaces
{
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

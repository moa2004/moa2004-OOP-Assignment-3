namespace RefactoringLab;

public interface IShippingStrategy
{
    decimal Calculate(decimal weightKg);
}
public class AramexShippingStrategy : IShippingStrategy
{
    public decimal Calculate(decimal weightKg) => weightKg * 12m;
}

public class FedExShippingStrategy : IShippingStrategy
{
    public decimal Calculate(decimal weightKg) => weightKg * 15m;
}

public class DhlShippingStrategy : IShippingStrategy
{
    public decimal Calculate(decimal weightKg) => weightKg * 18m;
}
public class ShippingCostCalculator
{
    private readonly IShippingStrategy _shippingStrategy;
    public ShippingCostCalculator(IShippingStrategy shippingStrategy)
    {
        _shippingStrategy = shippingStrategy;
    }
    public decimal Calculate(decimal weightKg)
    {
        return _shippingStrategy.Calculate(weightKg);
    }
}
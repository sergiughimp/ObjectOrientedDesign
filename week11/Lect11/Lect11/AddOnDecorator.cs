public abstract class AddOnDecorator : Beverage
{
    protected Beverage wrappedBeverage;

    public AddOnDecorator(Beverage beverage)
    {
        wrappedBeverage = beverage;
    }

    public abstract override string GetDescription();
}

public class Milk : AddOnDecorator
{
    public Milk(Beverage beverage) : base(beverage) { }

    public override string GetDescription()
    {
        return wrappedBeverage.GetDescription() + ", Milk";
    }

    public override double GetCost()
    {
        return Math.Round(wrappedBeverage.GetCost() + 0.20, 2);
    }
}

public class Mocha : AddOnDecorator
{
    public Mocha(Beverage beverage) : base(beverage) { }

    public override string GetDescription()
    {
        return wrappedBeverage.GetDescription() + ", Mocha";
    }

    public override double GetCost()
    {
        return Math.Round(wrappedBeverage.GetCost() + 0.30, 2);    }
}

public class Whip : AddOnDecorator
{
    public Whip(Beverage beverage) : base(beverage) { }

    public override string GetDescription()
    {
        return wrappedBeverage.GetDescription() + ", Whip";
    }

    public override double GetCost()
    {
        return Math.Round(wrappedBeverage.GetCost() + 0.15, 2);
    }
}

public class Soy : AddOnDecorator
{
    public Soy(Beverage beverage) : base(beverage) { }

    public override string GetDescription()
    {
        return wrappedBeverage.GetDescription() + ", Soy";
    }

    public override double GetCost()
    {
        return Math.Round(wrappedBeverage.GetCost() + 0.25, 2);
    }
}

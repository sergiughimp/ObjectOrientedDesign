public class Espresso : Beverage
{
    public Espresso()
    {
        Description = "Espresso";
    }

    public override string GetDescription()
    {
        return Description;
    }

    public override double GetCost()
    {
        return Math.Round(1.99, 2);
    }
}

public class HouseBlend : Beverage
{
    public HouseBlend()
    {
        Description = "House Blend Coffee";
    }

    public override string GetDescription()
    {
        return Description;
    }

    public override double GetCost()
    {
        return Math.Round(0.89, 2);
    }
}

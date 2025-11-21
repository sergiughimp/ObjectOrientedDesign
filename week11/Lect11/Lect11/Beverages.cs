public abstract class Beverage
{
    public string Description { get; set; } = "Unknown Beverage";
    public abstract string GetDescription();
    public abstract double GetCost();
}

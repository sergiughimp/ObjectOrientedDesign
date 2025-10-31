public class NYStyleCheesePizza : Pizza {
    public override string Name => "NY Style Sauce and Cheese Pizza";
}
public class LondonStyleCheesePizza : Pizza {
    public override string Name => "London Style Deep Dish Cheese Pizza";
    public override void Cut() => Console.WriteLine("Cutting the pizza into square slices");
}
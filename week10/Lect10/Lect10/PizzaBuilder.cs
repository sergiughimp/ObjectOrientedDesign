public class PizzaBuilder
{
    private readonly Pizza _pizza;

    public PizzaBuilder(string size)
    {
        _pizza = new Pizza
        {
            Size = size,
            Crust = "Regular",
            SauceType = "Tomato"
        };
    }

    public PizzaBuilder SetCrust(string crust)
    {
        _pizza.Crust = crust;
        return this;
    }

    public PizzaBuilder AddCheese(bool hasCheese = true)
    {
        _pizza.HasCheese = hasCheese;
        return this;
    }

    public PizzaBuilder AddPepperoni(bool hasPepperoni = true)
    {
        _pizza.HasPepperoni = hasPepperoni;
        return this;
    }

    public PizzaBuilder AddMushrooms(bool hasMushrooms = true)
    {
        _pizza.HasMushrooms = hasMushrooms;
        return this;
    }

    public PizzaBuilder AddOlives(bool hasOlives = true)
    {
        _pizza.HasOlives = hasOlives;
        return this;
    }

    public PizzaBuilder AddSausage(bool hasSausage = true)
    {
        _pizza.HasSausage = hasSausage;
        return this;
    }

    public PizzaBuilder SetSauce(string sauce)
    {
        _pizza.SauceType = sauce;
        return this;
    }

    public Pizza Build()
    {
        if (_pizza.Size == "Small" && _pizza.HasSausage && _pizza.HasPepperoni)
            throw new Exception("Small pizzas can't have too many toppings!");

        return _pizza;
    }
}

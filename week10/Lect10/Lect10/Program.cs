using System;

class Program
{
    static void Main()
    {
        Pizza myPizza = new PizzaBuilder("Large")
            .SetCrust("Thin")
            .AddCheese()
            .AddPepperoni()
            .AddOlives()
            .SetSauce("BBQ")
            .Build();

        Console.WriteLine(myPizza);

        Pizza smallPizza = new PizzaBuilder("Small")
            .SetCrust("Regular")
            .AddCheese()
            .SetSauce("Tomato")
            .Build();

        Console.WriteLine(smallPizza);
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Beverage beverage1 = new Espresso();
        Console.WriteLine($"{beverage1.GetDescription()}: ${beverage1.GetCost()}");

        Beverage beverage2 = new HouseBlend();
        beverage2 = new Mocha(beverage2);
        beverage2 = new Whip(beverage2);
        Console.WriteLine($"{beverage2.GetDescription()}: ${beverage2.GetCost()}");

        Beverage beverage3 = new Espresso();
        beverage3 = new Mocha(beverage3);
        beverage3 = new Mocha(beverage3);
        beverage3 = new Whip(beverage3);
        Console.WriteLine($"{beverage3.GetDescription()}: ${beverage3.GetCost()}");
    }
}
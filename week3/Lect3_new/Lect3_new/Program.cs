using System;
using System.Collections.Generic;
using person;
using counter;
using calculator;
using math_helper;

// List<string> names = new List<string>();
// names.Add("Alice");
// names.Add("Bob");
// names.Add("Charlie");

// Console.WriteLine("First name: " + names[0]); names.Remove("Bob");
// Console.WriteLine("Total names: " + names.Count);


class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Alice", 25);
        Console.WriteLine("Print the detalis of the person by accessing each variable: ");
        Console.WriteLine("Name: " + person1.Name);
        Console.WriteLine("Age: " + person1.Age);

        Console.WriteLine("Print the detalis of the person using 'this' internally: ");
        person1.PrintDetails();

        // Console.WriteLine(Counter.MyCounter);
        // Counter.MyCounter++;
        // Counter.MyCounter++;
        // Console.WriteLine(Counter.MyCounter);

        Console.WriteLine("Initial value of the counter is: " + Counter.GetCounter());
        Counter.IncreaseCounter();
        Counter.IncreaseCounter();
        Console.WriteLine("Value of the counter is: "+ Counter.GetCounter());

        int result = Calculator.Add(3, 7);
        Console.WriteLine("Result of the addition: " + result);
        

        double area = MathHelper.Pi * MathHelper.Square(5);
        Console.WriteLine("The area is: "+ area); // Output: 78.53975
    }
}
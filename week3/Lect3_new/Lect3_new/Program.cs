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

// Console.WriteLine("First name: " + names[0]); 
// names.Remove("Bob");
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
        Console.WriteLine("Value of the counter is: " + Counter.GetCounter());

        int result = Calculator.Add(3, 7);
        Console.WriteLine("Result of the addition: " + result);


        double area = MathHelper.Pi * MathHelper.Square(5);
        Console.WriteLine("The area is: " + area); // Output: 78.53975

        // Task 3: Add more functionalities in Math Helper Library from Lecture
        Console.Write("Enter number1 for power: ");
        int number1_pow = int.Parse(Console.ReadLine());
        Console.Write("Enter number2 for power: ");
        int number2_pow = int.Parse(Console.ReadLine());
        double power = MathHelper.Power(number1_pow, number2_pow);
        Console.WriteLine("The power of number1 and number 2 is: " + power);

        Console.Write("Enter number1 for addition: ");
        int number1_add = int.Parse(Console.ReadLine());
        Console.Write("Enter number2 for addition: ");
        int number2_add = int.Parse(Console.ReadLine());
        int addition = MathHelper.Addition(number1_add, number2_add);
        Console.WriteLine($"The addition of number1 and number 2 is: " + addition);


        Console.Write("Enter number1 for multiplication: ");
        int number1_mult = int.Parse(Console.ReadLine());
        Console.Write("Enter number2 for multiplication: ");
        int number2_mult = int.Parse(Console.ReadLine());
        int multiplication = MathHelper.Multiplication(number1_mult, number2_mult);

        Console.WriteLine("The multiplication of number1 and number 2 is: " + multiplication);
    }

}

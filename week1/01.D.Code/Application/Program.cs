using System;
namespace Application
{
    class MyProgram
    {

        static void GreetUser(string name) {
            Console.WriteLine("Hello, " + name + "! Welcome!");
        }
        static string ConcatenateStrings(string firstString, string secondString)
        {
            string combined = firstString + " " + secondString;
            return combined;
        }

        static string SubtractNumbers(int a, float b)
        {
            float result = a - b;
            return $"Subtracting {b} from {a} gives {result}";
        }
        static void Main(string[] args)
        {
            ;
            // Declare and initialize variables
            int apples = 10;
            int oranges = 5;
            int totalFruits;
            totalFruits = apples + oranges;
            double pricePerApple = 0.50;
            double pricePerOrange = 0.75;

            // Calculate total cost
            double totalCost = (apples * pricePerApple) + (oranges * pricePerOrange);

            Console.WriteLine("Total Cost:");
            Console.WriteLine(totalCost);

            // Apply discount
            double discount = 2.0;
            double finalCost = totalCost - discount; // Subtraction: finalCost = totalCost - 2.0

            // Update the number of apples after some are sold
            int applesSold = 4;
            apples = apples - applesSold; // Subtraction: apples = 6

            // Calculate average price per fruit
            double averagePricePerFruit = totalCost / totalFruits;


            // Task 1: Area of Rectangle
            int length1 = 10;
            int width1 = 5;
            double area1 = length1 * width1;
            Console.Write("Area of rectangle is: " + area1);

            Console.Write("\n");

            // Task 2: User input
            Console.WriteLine("Enter your length:");
            int length2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your width:");
            int width2 = Convert.ToInt32(Console.ReadLine());

            double area2 = length1 * width2;
            Console.WriteLine("Area2 of rectangle is: " + area2);


            // Task 3: 
            GreetUser("John");

            // Task 4:
            Console.WriteLine(ConcatenateStrings("Hello", "Summer"));

            // Task 5:
            Console.WriteLine("Enter an interger (a): ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an float (b): ");
            float b = Convert.ToSingle(Console.ReadLine());


            Console.WriteLine(SubtractNumbers(a, b));

        }
    }
}
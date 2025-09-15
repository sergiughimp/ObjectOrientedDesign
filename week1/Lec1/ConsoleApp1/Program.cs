// See https://aka.ms/new-console-template for more information
using System;
namespace ConsoleApp1
{
    class MyProgram
    {

        static void DisplayText() {
            Console.WriteLine("Some text text text text text text text text text text text text");
        }
        static void Main(string[] args)
        {

            DisplayText();

            Console.WriteLine("Hello, Wolrd!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("enjoy codding!");
            Console.WriteLine("Nice weather!");
            Console.WriteLine("Nice city!");

            int age = 25;
            string name = "Alice";
            bool isStudent = true;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(isStudent);

            Console.WriteLine("Student " + name + " has " + age + " years old, and she is student " + isStudent);

            string input = "abc";
            bool success = int.TryParse(input, out int result);

            Console.WriteLine(success);

            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();
            Console.WriteLine("User's name is: " + userName);

        }
    }
}
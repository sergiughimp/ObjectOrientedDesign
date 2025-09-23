using System;
using System.Collections.Generic;
using counter_static;

// slide 5
// List<string> names = new List<string>();
//  names.Add("Alice");
// names.Add("Bob"); 
// names.Add("Charlie");

// Console.WriteLine("First name: " + names[0]); 
// names.Remove("Bob");
// Console.WriteLine("Total names: " + names.Count);

public class Person { 
    private string name;
    public int Age;

    public string Name {
        get { return name; }
        set {
                if (string.IsNullOrWhiteSpace(value)){
                    throw new ArgumentException("Name cannot be emplty or whitespace");
                }
                else {name = value;
                } 
            }
        }

    // Default constructor (needed for: new Person())
    public Person() { }

    public Person(string name, int age) { 
        this.Name = name;
        this.Age = age;
    }
    
    public void PrintDetails() {
        PersonPrinter printer = new PersonPrinter();
        printer.Print(this);
        }
    }
// Simple class that works with Person objects
public class PersonPrinter{
    public void Print(Person person) {
    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    }
}

// Static variables
public class Counter {
    public static int MyCounter = 0;
}

class Program
{
    static void Main(string[] args)
    {
        // Person person1 = new Person("Alice", 25);
        // person1.PrintDetails();

        // Person person2 = new Person();
        // person2.Name = "Charlie";
        // person2.Age = 30;
        // person2.PrintDetails();

        // Console.WriteLine("The initial value of MyCounter is: " + Counter.MyCounter);
        // Counter.MyCounter++; 
        // Counter.MyCounter++; 
        // Console.WriteLine("The value of MyCounter is: " + Counter.MyCounter);


        User u1 = new User("Alice", 25);
        User u2 = new User("Bob", 30);

        Console.WriteLine($"Total users created: {User.MyCounter}");

        u2.IncrementCounter(); // extra manual increment
        Console.WriteLine($"Counter after increment: {User.MyCounter}");
    }
}
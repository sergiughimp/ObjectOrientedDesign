using System;
using System.Collections.Generic;
using animals;
using generics;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();
        // animals.Add(new Dog());
        // animals.Add(new Cat());

        // Using the singleton manager to add animals
        AnimalManager.Instance.AddAnimal(animals, new Dog());
        AnimalManager.Instance.AddAnimal(animals, new Cat());

        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }

        Box<int> intBox = new Box<int>();
        intBox.SetValue(123);

        Box<string> strBox = new Box<string>();
        strBox.SetValue("Hello");

        Console.WriteLine($"intBox contains: {intBox.GetValue()}");
        Console.WriteLine($"strBox contains: {strBox.GetValue()}");
    }
}
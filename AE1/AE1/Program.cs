using System;
using petstore;
using pets;
using supply;
using employee;
using customer;

// -----------------------------
// Program Entry Point
// -----------------------------
class Program
{
    static void Main(string[] args)
    {
        PetStore store = new PetStore();

        // Add pets
        Dog max = new Dog("Max", 250);
        Cat milo = new Cat("Milo", 180);
        store.AddItem(max);
        store.AddItem(milo);

        // Add supplies
        Supply rubberBone = new Supply("Rubber Bone", "Toy", 10);
        store.AddItem(rubberBone);

        // Add employees and log in
        Employee alice = new Employee("Alice", 101, "Cashier");
        store.RegisterEmployee(alice);
        alice.Login();

        // Add customers
        Customer john = new Customer("John Smith", "john@mail.com");
        store.RegisterCustomer(john);

        // Display store data
        store.ShowInventory();

        // Feed all pets (via IFeedable)
        store.FeedAllPets();

        // Process purchases
        store.ProcessPurchase(john, max);
        store.ProcessPurchase(john, rubberBone);

        // Employee logs out
        alice.Logout();

        Console.WriteLine("\nUpdated Store Status:");
        store.ShowInventory();
        Console.WriteLine($"\nTotal Revenue: ${store.TotalRevenue}");
    }
}
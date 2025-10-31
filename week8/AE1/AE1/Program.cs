using System;
using petstore;
using employee;
using customer;

class Program
{
    static void Main(string[] args)
    {
        // Create PetStore (Concrete Store)
        PetStore store = new PetStore();

        Console.WriteLine("Welcome to the Pet Store!");
        Console.WriteLine("Type 'exit' anytime to stop adding items.\n");

        // Employee login
        Employee alice = new Employee("Alice", 101, "Cashier");
        store.RegisterEmployee(alice);
        alice.Login();

        // Register Customers
        Customer john = new Customer("John Smith", "john@mail.com");
        Customer emily = new Customer("Emily Brown", "emily@mail.com");
        Customer david = new Customer("David Lee", "david@mail.com");
        Customer[] customers = { john, emily, david };

        store.RegisterCustomer(john);
        store.RegisterCustomer(emily);
        store.RegisterCustomer(david);

        int customerIndex = 0;

        // Loop to Add Items (Factory + Purchases)
        while (true)
        {
            Console.Write("Enter item type (dog/cat/toy): ");
            string type = Console.ReadLine()?.Trim().ToLower();
            if (type == "exit") break;

            Console.Write("Enter item name: ");
            string name = Console.ReadLine();
            if (name.ToLower() == "exit") break;

            Console.Write("Enter price: ");
            string priceInput = Console.ReadLine();
            if (priceInput.ToLower() == "exit") break;

            if (!double.TryParse(priceInput, out double price))
            {
                Console.WriteLine("Invalid price. Try again.\n");
                continue;
            }

            //  Factory Method: Create Item
            var newItem = store.CreateItem(type, name, price);
            if (newItem != null)
            {
                store.AddItem(newItem);
                Console.WriteLine($"{newItem.Name} ({type}) added to store inventory.");

                // Customer Buys Item
                Customer currentCustomer = customers[customerIndex % customers.Length];
                store.ProcessPurchase(currentCustomer, newItem);
                customerIndex++;

                // Show inventory after each purchase
                store.ShowInventory();
            }
        }

        // Feed pets
        store.FeedAllPets();

        // Employee logout
        alice.Logout();

        // Final store status
        Console.WriteLine("\nUpdated Store Status:");
        store.ShowInventory();
        Console.WriteLine($"\nTotal Revenue: ${store.TotalRevenue}");
    }
}


/* 
Explanation in Factory Method Terms

Concept	Component in this Program
Abstract Store	PetStore (declares CreateItem)
Concrete Store	PetStore itself (we only have one store here)
Abstract Product	IPurchasable (interface for any item sold)
Concrete Products	Dog, Cat, Supply (actual items created by the factory) 
*/
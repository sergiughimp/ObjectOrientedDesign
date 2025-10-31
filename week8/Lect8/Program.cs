using System;
namespace FactoryPatternDemo {
    class Program {
        private static void Main() {
            // 1) Ask which store (creator) to use
            Console.Write("Choose store (ny/ london): ");
            string? storeInput = Console.ReadLine()?.Trim().ToLower();
            PizzaStore store;
            if (storeInput == "ny") {
                store = new NYPizzaStore();
            }
            else if (storeInput == "london") {
                store = new LondonPizzaStore();
            }
            else {
                Console.WriteLine("Unknown store. Try 'ny' or 'london'.");
                return;
            }
            Console.Write("Choose pizza type (e.g., cheese): ");
            string? type = Console.ReadLine()?.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(type))
            {
                Console.WriteLine("Please enter a pizza type.");
                return;
            }
            Pizza pizza = store.OrderPizza(type);
            if (pizza == null)
            {
                Console.WriteLine($"Sorry, '{type}' is not available at this store.");
                return;
            }
            Console.WriteLine($"Ordered: {pizza.Name}");
        } 
    }
}
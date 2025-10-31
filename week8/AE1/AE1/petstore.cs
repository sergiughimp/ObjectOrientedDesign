using interfaces;
using employee;
using customer;
using pets;
using supply;

namespace petstore
{
    // -----------------------------
    // PetStore Class (Concrete Store)
    // -----------------------------
    public class PetStore
    {
        private List<IPurchasable> items = new List<IPurchasable>();
        private List<Employee> employees = new List<Employee>();
        private List<Customer> customers = new List<Customer>();
        public double TotalRevenue { get; private set; }

        // Factory Method - creates items dynamically based on type
        public IPurchasable CreateItem(string type, string name, double price)
        {
            type = type.ToLower();

            switch (type)
            {
                case "dog":
                    return new Dog(name, price); // Concrete product
                case "cat":
                    return new Cat(name, price); // Concrete product
                case "toy":
                    return new Supply(name, "Toy", price); // Concrete product
                default:
                    Console.WriteLine("Unknown item type.");
                    return null;
            }
        }

        // Add a new item (uses the factory)
        public void AddNewItem(string type, string name, double price)
        {
            IPurchasable item = CreateItem(type, name, price);
            if (item != null)
            {
                items.Add(item);
                Console.WriteLine($"{item.Name} ({type}) added to store inventory.");
            }
        }

        public void AddItem(IPurchasable item) => items.Add(item);
        public void RegisterEmployee(Employee emp) => employees.Add(emp);
        public void RegisterCustomer(Customer cust) => customers.Add(cust);

        public bool HasItems() => items.Count > 0;

        /// Processes a purchase and adds revenue.
        public void ProcessPurchase(Customer customer, IPurchasable item)
        {
            item.Purchase();
            customer.Purchase();
            TotalRevenue += item.Price;

            int points = (int)(item.Price / 10);
            customer.AddLoyaltyPoints(points);

            Console.WriteLine($"Total Revenue: ${TotalRevenue}\n");
        }

        public void FeedAllPets()
        {
            Console.WriteLine("\nFeeding all pets...");
            foreach (IPurchasable item in items)
            {
                if (item is IFeedable feedable)
                {
                    feedable.Feed();
                }
            }
        }

        // Show inventory. onlyItems=true will skip employees/customers
        public void ShowInventory(bool onlyItems = false)
        {
            Console.WriteLine("\n--- Store Items ---");
            foreach (IPurchasable item in items)
            {
                switch (item)
                {
                    case Pet pet:
                        Console.WriteLine($"{pet.Name} ({pet.Species}) - ${pet.Price}");
                        break;
                    case Supply supply:
                        Console.WriteLine($"{supply.Name} ({supply.Type}) - ${supply.Price}");
                        break;
                }
            }

            if (onlyItems) return;

            Console.WriteLine("\n--- Employees ---");
            foreach (Employee e in employees)
            {
                string status = e.LoggedIn ? "Logged in" : "Logged out";
                Console.WriteLine($"{e.Name} ({e.Role}) - {status}");
            }

            Console.WriteLine("\n--- Customers ---");
            foreach (Customer c in customers)
            {
                Console.WriteLine($"{c.Name} ({c.Email}) - Loyalty Points: {c.LoyaltyPoints}");
            }
        }
    }
}
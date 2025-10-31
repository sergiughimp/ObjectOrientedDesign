using interfaces;
namespace customer
{
    // ---------------
    // Customer Class
    // ---------------

    /// Represents a customer in the store.
    /// Demonstrates Encapsulation and Polymorphism via IPurchasable.
    public class Customer : IPurchasable
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int LoyaltyPoints { get; private set; }
        public double Price => 0; // not applicable for customers

        public Customer(string name, string email, int loyaltyPoints = 0)
        {
            Name = name;
            Email = email;
            LoyaltyPoints = loyaltyPoints;
        }

        public void Purchase()
        {
            Console.WriteLine($"Customer {Name} made a purchase.");
        }

        public void AddLoyaltyPoints(int points)
        {
            LoyaltyPoints += points;
            Console.WriteLine($"{Name} earned {points} loyalty points!");
        }
    }
}
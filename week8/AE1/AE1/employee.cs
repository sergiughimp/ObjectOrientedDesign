using interfaces;

namespace employee
{
    // -----------------------------
    // Employee Class
    // -----------------------------
    /// Represents a store employee. Demonstrates Encapsulation and Constructors.
    public class Employee : ILoginable
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Role { get; set; }
        public bool LoggedIn { get; private set; }

        public Employee(string name, int id, string role)
        {
            Name = name;
            Id = id;
            Role = role;
            LoggedIn = false;
        }

        public bool Login()
        {
            LoggedIn = true;
            Console.WriteLine($"Employee {Name} logged in.");
            return LoggedIn;
        }

        public void Logout()
        {
            LoggedIn = false;
            Console.WriteLine($"Employee {Name} logged out.");
        }
    }
}
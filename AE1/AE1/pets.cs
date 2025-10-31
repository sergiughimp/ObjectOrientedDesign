using interfaces;
using storeitem;

namespace pets
{
    // -----------------------------
    // Pet Classes
    // -----------------------------

    /// Base class for all pets. Implements IFeedable.
    /// Demonstrates Inheritance and Polymorphism.

    public abstract class Pet : StoreItem, IFeedable
    {
        private string _species;
        public string Species { get => _species; set => _species = value; }

        protected Pet(string name, string species, double price) : base(name, price)
        {
            _species = species;
        }

        public virtual void Feed()
        {
            Console.WriteLine($"{Name} the {Species} has been fed.");
        }
    }

    public class Dog : Pet
    {
        public Dog(string name, double price) : base(name, "Dog", price) { }

        public void Bark() => Console.WriteLine($"{Name} says: Woof!");

        public override void Feed()
        {
            Console.WriteLine($"{Name} enjoys a tasty dog meal.");
        }
    }

    public class Cat : Pet
    {
        public Cat(string name, double price) : base(name, "Cat", price) { }

        public void Meow() => Console.WriteLine($"{Name} says: Meow!");

        public override void Feed()
        {
            Console.WriteLine($"{Name} enjoys a delicious cat meal.");
        }
    }
}
using interfaces;
namespace storeitem
{
    // -----------------------------
    // Base Class for Store Items
    // -----------------------------

    /// Base class for items in the store.
    /// Demonstrates Encapsulation, Constructors, and Code Reuse.
    public abstract class StoreItem : IPurchasable
    {
        private string _name;
        private double _price;

        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }

        protected StoreItem(string name, double price)
        {
            _name = name;
            _price = price;
        }

        /// Default purchase action.
        /// Can be overridden in derived classes to demonstrate Polymorphism.
        public virtual void Purchase()
        {
            Console.WriteLine($"{Name} purchased for ${Price}.");
        }
    }
}
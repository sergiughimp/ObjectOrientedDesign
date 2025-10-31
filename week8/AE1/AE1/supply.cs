using storeitem;

namespace supply
{
    // -----------------------------
    // Supply Class
    // -----------------------------

    /// Represents store supplies (food, toys, etc.).
    /// Inherits from StoreItem to reuse Name/Price properties.

    public class Supply : StoreItem
    {
        public string Type { get; set; }

        public Supply(string name, string type, double price) : base(name, price)
        {
            Type = type;
        }

        public void Restock()
        {
            Console.WriteLine($"{Name} has been restocked.");
        }

        public override void Purchase()
        {
            Console.WriteLine($"{Name} ({Type}) supply purchased for ${Price}.");
        }
    }
}
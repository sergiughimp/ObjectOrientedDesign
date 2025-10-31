namespace interfaces
{
    // -----------------------------
    // Interfaces
    // -----------------------------
    
    // -----------------------------
    // ILoginable interface
    // -----------------------------

    /// Represents an object that can log in/out.
    public interface ILoginable
    {
        bool Login();
        void Logout();
    }

    // -----------------------------
    // IPurchasable interface
    // -----------------------------

    /// Represents an object that can be purchased.
    public interface IPurchasable
    {
        string Name { get; }
        double Price { get; }
        void Purchase();
    }

    // -----------------------------
    // IFeedable interface
    // -----------------------------
    
    /// Represents an entity that can be fed.
    /// Demonstrates separation of responsibilities via interfaces.
    public interface IFeedable
    {
        void Feed();
    }
}
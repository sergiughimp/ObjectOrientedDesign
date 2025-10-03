namespace libraryItem
{
    public abstract class LibraryItems
    {
        protected string name;
        protected bool isAvailable;
        public string GetName() => name;
        public LibraryItems(string name, bool isAvailable)
        {
            this.name = name;
            this.isAvailable = isAvailable;
        }
        // Base implementation for all library items
        public virtual void LibraryItem()
        {
            Console.WriteLine($"Library Item: {name}");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{name} (Available: {(isAvailable ? "Yes" : "No")})");
        }

        public bool CheckAvailabilityByName(string itemName)
        {
            if (itemName == name)
            {
                Console.WriteLine(isAvailable ? $"{name} is available." : $"{name} is not available.");
                return true;
            }
            return false;
        }
    }
}
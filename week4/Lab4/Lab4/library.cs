using libraryItem;

namespace library
{
    public class LibraryManager
    {
        private static LibraryManager _instance;
        public static LibraryManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LibraryManager();
                }
                return _instance;
            }
        }
        private List<LibraryItems> items;
        private LibraryManager()
        {
            items = new List<LibraryItems>();
        }
        // Add any item
        public void AddItem(LibraryItems item)
        {
            items.Add(item);
            Console.WriteLine($"{item.GetType().Name} \"{item.GetName()}\" added to library.");
        }
        // Remove by object
        public void RemoveItem(LibraryItems item)
        {
            if (items.Remove(item))
                Console.WriteLine($"{item.GetType().Name} \"{item.GetName()}\" removed from library.");
            else
                Console.WriteLine("Item not found.");
        }
        // Remove by name
        public void RemoveItem(string name)
        {
            var found = items.FirstOrDefault(i => i.GetName() == name);
            if (found != null)
            {
                items.Remove(found);
                Console.WriteLine($"Item \"{name}\" removed from library.");
            }
            else
            {
                Console.WriteLine($"Item \"{name}\" not found.");
            }
        }
        // Display all items
        public void DisplayItems()
        {
            Console.WriteLine("\nLibrary Items:");
            foreach (var item in items)
            {
                item.DisplayInfo();
                Console.WriteLine();
            }
        }

        // check availability by name in the entire list
        public void CheckAvailability(string itemName)
        {
            bool found = false;
            foreach (var item in items)
            {
                if (item.CheckAvailabilityByName(itemName))
                {
                    found = true;
                    break;
                }
            }

            if (!found)
                Console.WriteLine($"Item \"{itemName}\" not found in library.");
        }

        // Get all items as list
        public List<LibraryItems> GetAllItems()
        {
            return items; // return copy of the list
        }
    }
}
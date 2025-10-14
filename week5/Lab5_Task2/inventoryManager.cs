using interfaces;
using item;

namespace inventoryManager {

    public class InventoryManager
    {

        private static InventoryManager _instance;
        private List<Item> items;
        private InventoryManager()
        {
            items = new List<Item>();
        }

        public static InventoryManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new InventoryManager();
                }
                return _instance;
            }
        }

        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine($"{item.Name} added to inventory.");
        }

        public void removeItem(Item item)
        {
            if (items.Remove(item))
                Console.WriteLine($"{item.Name} removed from inventory.");
            else
                Console.WriteLine($"{item.Name} not found in inventory.");
        }

        public void useItem(Item item)
        {
            if (items.Contains(item))
            {
                item.Use();
                if (item is ISingleUse)
                    removeItem(item);
            }
            else
            {
                Console.WriteLine($"{item.Name} not found in inventory.");
            }
        }
        public void showItemsInvetory()
        {
            Console.WriteLine("\n Current Inventory: ");
            foreach (var item in items)
            {
                Console.WriteLine($" - {item.Name} (Weight: {item.Weight}, Value: {item.Value})");
            }
            if (items.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
            }
        }
    }
}

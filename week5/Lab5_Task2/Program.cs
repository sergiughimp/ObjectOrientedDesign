using System;
using inventoryManager;
using weapon;
using potion;
using shield;

class Program
{
    public static void Main(string[] args)
    {
        Weapon sword = new Weapon("Excalibur", 5.5f, 1000, 50);
        Potion potion = new Potion("Health Potion", 0.5f, 50, 30);
        Shield shield = new Shield("Iron Shield", 7f, 200, 20);

        InventoryManager inventory = InventoryManager.Instance;

        inventory.AddItem(sword);
        inventory.AddItem(potion);
        inventory.AddItem(shield);

        inventory.showItemsInvetory();

        Console.WriteLine("\nUsing Items:");
        inventory.useItem(sword);
        inventory.useItem(potion);
        inventory.useItem(shield);

        inventory.showItemsInvetory();
    }
}

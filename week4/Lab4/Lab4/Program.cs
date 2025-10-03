using library;
using book;
using magazine;
using journal;

class Program
{
    static void Main(string[] args)
    {
        LibraryManager lm = LibraryManager.Instance;

        Book book1 = new Book(
            name: "The Enchanted Forest",
            isAvailable: true,
            genre: "Fantasy",
            ISBN: "978-3-16-148410-0",
            subject: "Magic, Adventure, and Friendship",
            recomandedFor: "Teens and young adults who enjoy fantasy and adventure stories.",
            plotSummary: "When an ancient spell awakens the long-forgotten creatures of the Enchanted Forest…"
        );

        Magazine celebMagazine1 = new Magazine("Star Weekly", true, 10, "Weekly", "Celebrity news");
        Journal journal1 = new Journal("Science Today", true, 5, "Monthly", "Physics", "Dr. John Doe");

        lm.AddItem(book1);
        lm.AddItem(celebMagazine1);
        lm.AddItem(journal1);

        lm.DisplayItems();

        Console.WriteLine("\nAvailability check:");
        lm.CheckAvailability("The Enchanted Forest");
        lm.CheckAvailability("Star Weekly");
        lm.CheckAvailability("Science Today");
        lm.CheckAvailability("Nonexistent Item"); // test for not found

        Console.WriteLine("\nRemoving items:");
        lm.RemoveItem(book1);
        lm.RemoveItem("The Enchanted Forest");


        // Get list of all remaining items
        Console.WriteLine("\nRemaining items in library:");
        var allItems = lm.GetAllItems();
        foreach (var item in allItems)
        {
            Console.WriteLine(item.GetName());
        }
    }
}

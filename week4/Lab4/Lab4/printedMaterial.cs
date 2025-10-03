using libraryItem;

namespace printedMaterial
{
    public class PrintedMaterial : LibraryItems
    {
        protected string genre;
        protected string ISBN;
        public PrintedMaterial(string name, bool isAvailable, string genre, string ISBN)
            : base(name, isAvailable)
        {
            this.genre = genre;
            this.ISBN = ISBN;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Genre: {genre}, ISBN: {ISBN}");
        }

    }
}
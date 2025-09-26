namespace task1Library
{
    public class Library
    {
        // Task 1: Library Management System with Generic Collections

        // Use List<string> to store book titlesImplement these basic operations
        List<string> books = new List<string>();
        public void AddBooks()
        {
            // Add 5 book titles to the list
            books.Add("The Alchemist");
            books.Add("Think and Grow Rich");
            books.Add("Rich Dad, Poor Dad");
            books.Add("How to Win Friends & Influence People");
            books.Add("Emotional Intelligence");
        }
        public void DisplayBooks() {
            // Display all books with their position numbers (1, 2, 3...)
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"The name of book {i + 1}: '{books[i]}'");
            }
        }

        // Remove one book by title
        public void RemoveBook(string title) {
            books.Remove(title);
        }
        // check if this book exists in the list
        public void ExistsBook(string title) {
            bool exists = books.Exists(book => book == title);
            Console.WriteLine($"Does the book '{title}' exist: " + exists);
        }
        // Show the total number of books
        public void ShowTotal(){
            Console.WriteLine("Total books: " + books.Count);
        }
        
    }
}
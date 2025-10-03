
using System;
using System.Collections.Generic;
using task1Library;
using task2Student;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        library.AddBooks("The Alchemist");
        library.AddBooks("Think and Grow Rich");
        library.AddBooks("Rich Dad, Poor Dad");
        library.AddBooks("How to Win Friends & Influence People");
        library.AddBooks("Emotional Intelligence");
        library.DisplayBooks();
        library.RemoveBook("How to Win Friends & Influence People");
        library.ExistsBook("How to Win Friends & Influence People");
        library.ExistsBook("Think and Grow Rich");
        library.ShowTotal();


        Student student1 = new Student("Alice Johnson", 20, "ST001");
        Student student2 = new Student("Bob Smith", 19, "ST002");

        student1.DisplayInfo();
        student2.DisplayInfo();
        
    }

}

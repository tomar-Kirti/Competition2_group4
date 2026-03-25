namespace Competition2_group4
using System;
using System.Collections;

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
            Book book2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
            Book book3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);

            Student student1 = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
            Student student2 = new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025);

            Staff staff1 = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            library.AddPatron(student1);
            library.AddPatron(student2);
            library.AddPatron(staff1);

            library.DisplayBooks();
            Console.WriteLine();

            library.DisplayPatrons();
            Console.WriteLine();

            Console.WriteLine("Borrowing Books...");
            library.BorrowBook("Sandeep", "Business Insights with AI");
            library.BorrowBook("Akhil", "Analytics in Action");
            Console.WriteLine();

            Console.WriteLine("Books after borrowing:");
            library.DisplayBooks();
        }
    }
}
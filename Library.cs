using System;
using System.Collections.Generic;

namespace Competition2_group4
{
    public class Library
    {
        public List<Book> Books { get; set; }
        public List<Person> Patrons { get; set; }

        public Library()
        {
            Books = new List<Book>();
            Patrons = new List<Person>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void AddPatron(Person patron)
        {
            Patrons.Add(patron);
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Books in Library:");
            foreach (Book book in Books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available Copies: {book.AvailableCopies}");
            }
        }

        public void DisplayPatrons()
        {
            Console.WriteLine("Patrons in Library:");
            foreach (Person patron in Patrons)
            {
                Console.WriteLine($"Name: {patron.Name}, ID: {patron.ID}");
            }
        }

        public void BorrowBook(string patronName, string bookTitle)
        {
            Book foundBook = null;

            foreach (Book book in Books)
            {
                if (book.Title == bookTitle)
                {
                    foundBook = book;
                    break;
                }
            }

            if (foundBook == null)
            {
                Console.WriteLine($"Book '{bookTitle}' not found.");
                return;
            }

            if (foundBook.BorrowBook())
            {
                Console.WriteLine($"{patronName} borrowed '{bookTitle}'");
            }
            else
            {
                Console.WriteLine($"No copies available for '{bookTitle}'");
            }
        }
    }
}
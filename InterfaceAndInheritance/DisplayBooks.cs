using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;

namespace InterfaceAndInheritance
{
    public class DisplayBooks
    {
        
        public List<Library> LibraryBookList { get; set; } // Erklærer en Library Liste med navn LibraryBookList <Libary> kaller på library konstruktoren

        public DisplayBooks()// DisplayBooks Constructor 1:1
        {
            LibraryBookList = new List<Library>();
        }

        public void AddNewBook(string bookName, int year, int pages)
        {
            LibraryBookList.Add(new Library(bookName, year, pages));
        }

        public void ShowBookList()
        {
            foreach (var books in LibraryBookList)
            {
                books.showBooks();
            }
        }
    }
}
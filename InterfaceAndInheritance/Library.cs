using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace InterfaceAndInheritance
{
    public class Library
    {
        // Her settes klassens porperties
        private string bookName { get; set; }
        private int year { get; set; }
        private int pages { get; set; }

        // Library konstruktor som tar inn parametre og tilegner verdien til properties
        public Library( string bookName, int year, int pages)
        {
            this.bookName = bookName;
            this.year = year;
            this.pages = pages;
        }

        // En metode som kalles opp og skriver ut tekst med verdier.
        public void showBooks()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine($"Name: {bookName} -  Year: {year} - Pages: {pages}");
        }



    }
}
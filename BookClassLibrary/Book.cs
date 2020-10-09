using System;
using System.ComponentModel.DataAnnotations;

namespace BookClassLibrary
{
    public class Book
    {

        //Create a “Class Library (.NET core)” project.
        //Create a class Book with properties (note the different constraints):
        //Title, minimum 2 characters long  Author  Page number, 10 < pagenumber <= 1000
        //Isbn13, must be a text string of exactly 13 characters.
        //If the above constraints are not complied with, appropriate exceptions must be thrown .
        //This also applies to constructors. Add a unit test to your project. Test your Book class.
        //Your test test should have a good “Code Coverage” 
        private string _title;
        private int _pageNumber;
        private string _isbn;

        public string Author { get; protected set; }


        public Book(string title, string author, int pageNumber, string isbn)
        {
            Title = title;
            Author = author;
            PageNumber = pageNumber;
            Isbn13 = isbn;
        }

   




        public string Title
        {
            get { return this._title;}
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Book Titles must be a minimum of two characters. Please try again.");
                    this._title = value;
                }
            }
        }

        public int PageNumber
        {
            get { return this._pageNumber; }
            set
            {
                if (value < 10 || value >= 1001)
                {
                    throw new ArgumentException("Page length is either too large or too small, please try again.");
                    this._pageNumber = value;
                }
            }
        }

        public string Isbn13
        {
            get { return this._isbn; }
            set
            {
                if (value.Length != 13)
                {
                    throw new ArgumentException("International Standard Book Number (Isbn) must be 13 characters long. Please try again.");
                    this._isbn = value;
                }
            }
        }


    }
}

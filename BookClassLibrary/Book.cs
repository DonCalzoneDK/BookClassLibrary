using System;
using System.ComponentModel.DataAnnotations;

namespace BookClassLibrary
{
    public class Book
    {

        private string _title;
        private int _pageNumber;
        private string _isbn;

        /// <summary>
        /// default properties for Author
        /// </summary>
        public string Author { get; protected set; }


        /// <summary>
        /// Empty Constructor for Book
        /// </summary>
        public Book()
        {

        }

        /// <summary>
        /// Constructor for book class that takes four parameters
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="pageNumber"></param>
        /// <param name="isbn"></param>
        public Book(string title, string author, int pageNumber, string isbn)
        {
            Title = title;
            Author = author;
            PageNumber = pageNumber;
            Isbn13 = isbn;
        }

        /// <summary>
        /// Book Titles property that allows titles only over 2 chars. in length
        /// </summary>
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

        /// <summary>
        /// Books PageNumber property which will throw an error if the int value
        /// is below 10 or over 1000
        /// </summary>
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

        /// <summary>
        /// Books Isbn13 property which only allows strings that are
        /// 13 chars in length
        /// </summary>
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

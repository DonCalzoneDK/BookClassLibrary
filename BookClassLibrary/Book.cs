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
        public string Author { get; set; }

        

        /// <summary>
        /// Book Titles property that allows titles only over 2 chars. in length
        /// </summary>
        public string Title
        {
            get { return _title;}
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Book Titles must be a minimum of two characters. Please try again.");
                    
                }
                _title = value;
            }
        }

        /// <summary>
        /// Books PageNumber property which will throw an error if the int value
        /// is below 10 or over 1000
        /// </summary>
        public int PageNumber
        {
            get { return _pageNumber; }
            set
            {
                if (value < 10 || value >= 1001)
                {
                    throw new ArgumentException("Page length is either too large or too small, please try again.");
                    
                }
                _pageNumber = value;
            }
        }

        /// <summary>
        /// Books Isbn13 property which only allows strings that are
        /// 13 chars in length
        /// </summary>
        public string Isbn13
        {
            get { return _isbn; }
            set
            {
                if (value.Length != 13)
                {
                    throw new ArgumentException("International Standard Book Number (Isbn) must be 13 characters long. Please try again.");
                    
                }
                _isbn = value;
            }
        }


    }
}

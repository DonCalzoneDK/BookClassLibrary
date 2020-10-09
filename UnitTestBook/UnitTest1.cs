using System;
using BookClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBook
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BookTitleLessThanTwoCharTest()
        {
            //Arrange
            var book = new Book("1","Josh Lewis",200, "12c4567890123");
            //Act
            string title = book.Title;
            //Assert
            Assert.AreEqual("Book Title",title);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BookPageNumberLessThanTenTest()
        {
            //Arrange
            var book = new Book("Slaughterhouse Five", "Kurt Vonnegut", 2, "12c4567890123");
            //Act
            int pageNum = book.PageNumber;
            //Assert
            Assert.AreEqual(215, pageNum);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BookPageNumberMoreThanOneThousandTest()
        {
            //Arrange
            var book = new Book("Slaughterhouse Five", "Kurt Vonnegut", 1002, "12c4567890123");
            //Act
            int pageNum = book.PageNumber;
            //Assert
            Assert.AreEqual(215, pageNum);

        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsbnIsLessThan13Test()
        {
            //Arrange
            var book = new Book("Slaughterhouse Five", "Kurt Vonnegut", 215, "123456789012");
            //Act
            string isbn = book.Isbn13;
            //Assert
            Assert.AreEqual("1234567890123", isbn);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsbnIsMoreThan13Test()
        {
            //Arrange
            var book = new Book("Slaughterhouse Five", "Kurt Vonnegut", 215, "12345678901234");
            //Act
            string isbn = book.Isbn13;
            //Assert
            Assert.AreEqual("1234567890123", isbn);

        }

        [TestMethod]
        public void BookValidValuesTest()
        {
            //Arrange
            Book book = new Book("Slaughterhouse Five", "Kurt Vonnegut", 215, "1234567890123");
        }

        /*
        //used if there wasn't an object of Book
        [TestMethod]
        public void AuthorTest()
        {
            //Arrange
            Book book = new Book();
            string author = "Kurt Vonnegut";
            book.Author = author;
            Assert.AreEqual(author, book.Author);

        }
        */


    }
}

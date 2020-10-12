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
            var book = new Book();
            //Act
            book.Title = "n";
            //Assert
            Assert.Fail();

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BookPageNumberLessThanTenTest()
        {
            //Arrange
            var book = new Book();
            //Act
            book.PageNumber = 9;
            //Assert
            Assert.Fail();

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BookPageNumberMoreThanOneThousandTest()
        {
            //Arrange
            var book = new Book();
            //Act
            book.PageNumber = 1001;
            //Assert
            Assert.Fail();

        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsbnIsLessThan13Test()
        {
            //Arrange
            var book = new Book();
            //Act
            book.Isbn13 = "123456789012";
            //Assert
            Assert.Fail();

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsbnIsMoreThan13Test()
        {
            //Arrange
            var book = new Book();
            //Act
            book.Isbn13 = "12345678901234";
            //Assert
            Assert.Fail();

        }
        
        
        [TestMethod]
        public void IsbnIsGoodLengthOf13Test()
        {
            Book book = new Book();

            book.Isbn13 = "1234567890123";
        }

        [TestMethod]
        public void AmountOfPageIsGoodTest()
        {
            Book book = new Book();

            book.PageNumber = 302;

        }

        [TestMethod]
        public void BookTitleIsGoodTest()
        {
            //Arrange
            Book book = new Book();

            book.Title = "Kurt Vonnegut";

        }

        [TestMethod]
        public void AuthorTest()
        {
            //Arrange
            Book book = new Book();
            string author = "Kurt Vonnegut";
            book.Author = author;
            Assert.AreEqual(author, book.Author);

        }



    }
}

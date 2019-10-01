using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BogTestProject
{
    [TestClass]
    public class UnitTest1
    {
        //Arrange
        public Bog.Bog testBog;

        [TestMethod]
        public void TestMethod()
        {
            //Arrange
            testBog = new Bog.Bog("De Vises Sten", "J K R Rowling", 400, 1234567891011);
            //Act

            //Assert

        }
        [TestMethod]
        public void TestConstructorTitle()
        {
            //Act
            testBog = new Bog.Bog("De Vises Sten", "J K R Rowling", 400, 1234567891011);
            //Assert
            Assert.AreEqual(testBog.Title, "De Vises Sten");
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestConstructorTitleException()
        {
            //Act
            testBog = new Bog.Bog("D", "J K R Rowling", 400, 1234567891011);
        }

        [TestMethod]
        public void TestConstructorAuthor()
        {
            //Act
            testBog = new Bog.Bog("De Vises Sten", "J K R Rowling", 400, 1234567891011);
            //Assert
            Assert.AreEqual(testBog.Author, "J K R Rowling");
        }
        [TestMethod]
        public void TestConstructorPageNr()
        {
            //Act
            testBog = new Bog.Bog("De Vises Sten", "J K R Rowling", 400, 1234567891011);
            //Assert
            Assert.AreEqual(testBog.PageNr, 400);
        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestConstructorPageNrExceptionHigh()
        {
            //Act
            testBog = new Bog.Bog("De Vises Sten", "J K R Rowling", 1001, 1234567891011);
        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestConstructorPageNrExceptionLow()
        {
            //Act
            testBog = new Bog.Bog("De Vises Sten", "J K R Rowling", 9, 1234567891011);
        }
        [TestMethod]
        public void TestConstructorISBN()
        {
            //Act
            testBog = new Bog.Bog("De Vises Sten", "J K R Rowling", 400, 1234567891011);
            //Assert
            Assert.AreEqual(testBog.ISBN13, 1234567891011);
        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestConstructorISBNExceptionOne()
        {
            //Act
            testBog = new Bog.Bog("De Vises Sten", "J K R Rowling", 400, 0);
        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestConstructorISBNExceptionTwo()
        {
            //Act
            testBog = new Bog.Bog("De Vises Sten", "J K R Rowling", 400, 12345678910112);
        }




        [TestMethod]
        public void TestSetTitle()
        {
            //Arrange
            testBog = new Bog.Bog("De Vises Sten", "J K R Rowling", 400, 1234567891011);

            //Act
            testBog.Title = "Kingsman";

            //Assert
            Assert.AreEqual(testBog.Title, "Kingsman");
        }
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestSetTitleException()
        {
            //Assert
            testBog = new Bog.Bog("De Vises Sten", "J K R Rowling", 400, 1234567891011);
            //Act
            testBog.Title = "D";
        }
        [TestMethod]
        public void TestSetAuthor()
        {
            //Arrange
            testBog = new Bog.Bog("De Vises Sten", "J K R Rowling", 400, 1234567891011);

            //Act
            testBog.Author = "Jørgen Høg";

            //Assert
            Assert.AreEqual(testBog.Author, "Jørgen Høg");

        }
        [TestMethod]
        public void TestSetPageNr()
        {
            //Arrange
            testBog = new Bog.Bog("De Vises Sten", "J K R Rowling", 400, 1234567891011);

            //Act
            testBog.PageNr = 200;

            //Assert
            Assert.AreEqual(testBog.PageNr, 200);

        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestSetPageNrExceptionOne()
        {
            //Assert
            testBog = new Bog.Bog("De Vises Sten", "J K R Rowling", 400, 12345678910112);
            //Act
            testBog.PageNr =1;
        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestSetPageNrExceptionTwo()
        {
            //Assert
            testBog = new Bog.Bog("De Vises Sten", "J K R Rowling", 400, 12345678910112);
            //Act
            testBog.PageNr = 1001;
        }
        [TestMethod]
        public void TestSetISBN()
        {
            //Arrange
            testBog = new Bog.Bog("De Vises Sten", "J K R Rowling", 400, 1234567891011);

            //Act
            testBog.ISBN13 = 1111111111111;

            //Assert
            Assert.AreEqual(testBog.ISBN13, 1111111111111);
        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestSetISBNException()
        {
            //Assert
            testBog = new Bog.Bog("De Vises Sten", "J K R Rowling", 400, 12345678910112);
            //Act
            testBog.ISBN13 = 1;
        }


    }
}

using System;
using Lab_Encapsulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortPersonTest
{
    [TestClass]
    public class SortingTest
    {
        [TestMethod]
        public void SortTestValid()
        {
            //--Arrange
            Person person = new Person
            {
                FirstName = "Peter",
                LastName = "Forsberg",
                Age = 44
            }
            string expected = "Peter Forsberg is 44 years old.";


            //--Act
            string actual = "{this.FirstName} {this.LastName} is {this.Age} years old.""

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

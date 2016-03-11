using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestExample;

namespace UnitTestProject1
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FirstNameTest()
        {
        //--Arrange
        Customer customer = new Customer();
        customer.firstName = "Sara";
        customer.lastName = "Franco";


        string expected = "Sara,Franco";

        //--Act

        string actual = customer.fullName;

        //--Assert
        Assert.AreEqual(expected, actual);
        }
    }
}

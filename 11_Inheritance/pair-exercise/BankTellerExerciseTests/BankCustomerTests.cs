using BankTellerExerciseTests.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExerciseTests
{
    [TestClass]
    public class BankCustomerTests
    {
        [TestMethod]
        public void TestIsVIP()
        {
            //arrange
            BankCustomer customer = new BankCustomer();
             
            //act
            bool actualResult = customer.IsVIP;

            //assert
            Assert.AreEqual(false, actualResult);
        }
    }
}

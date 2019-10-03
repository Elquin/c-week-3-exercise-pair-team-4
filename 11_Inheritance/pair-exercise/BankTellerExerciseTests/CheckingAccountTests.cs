using BankTellerExerciseTests.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExerciseTests
{


    [TestClass]
    public class CheckingAccountTests
    {

        [TestMethod]
        public void DepositTest()
        {
            // arrange
            CheckingAccount deposit = new CheckingAccount();

            // act
            decimal actualResult = deposit.Deposit(500);

            // assert
            Assert.AreEqual(500, actualResult);
        }
        [TestMethod]

        public void WithdrawFiftyTest()
        {
            //arrange
            CheckingAccount withdraw = new CheckingAccount();

            //act
            decimal actualResult = withdraw.Withdraw(50);

            //assert
            Assert.AreEqual(-60, actualResult);
        }
        [TestMethod]

        public void WithdrawTwoHundredTest()
        {
            //arrange
            CheckingAccount withdraw = new CheckingAccount();

            //act
            decimal actualResult = withdraw.Withdraw(200);

            //assert
            Assert.AreEqual(0, actualResult);
        }
    }
}

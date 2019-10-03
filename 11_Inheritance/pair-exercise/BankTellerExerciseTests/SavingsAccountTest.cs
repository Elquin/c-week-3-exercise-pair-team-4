using BankTellerExerciseTests.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExerciseTests
{
    [TestClass]
    public class SavingsAccountTests
    {

        [TestMethod]
        public void DepositTest()
        {
            // arrange
            SavingsAccount deposit = new SavingsAccount();

            // act
            decimal actualResult = deposit.Deposit(500);

            // assert
            Assert.AreEqual(500, actualResult);
        }
        [TestMethod]

        public void WithdrawFiftyTest()
        {
            //arrange
            SavingsAccount withdraw = new SavingsAccount();

            //act
            decimal actualResult = withdraw.Withdraw(50);

            //assert
            Assert.AreEqual(0, actualResult);
        }
        [TestMethod]

        public void WithdrawZeroTest()
        {
            //arrange
            SavingsAccount withdraw = new SavingsAccount();

            //act
            decimal actualResult = withdraw.Withdraw(0);

            //assert
            Assert.AreEqual(-2, actualResult);
        }
        [TestMethod]

        public void WithdrawTwoHundredTest()
        {
            //arrange
            SavingsAccount withdraw = new SavingsAccount();
            withdraw.Deposit(50);
            //act
            decimal actualResult = withdraw.Withdraw(200);

            //assert
            Assert.AreEqual(50, actualResult);
        }

    }   
    
}

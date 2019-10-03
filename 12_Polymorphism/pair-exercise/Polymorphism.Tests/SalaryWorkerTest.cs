using EmployeePayroll.CLasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Tests
{
    [TestClass]
    public class SalaryWorkerTest
    {
        [TestMethod]
        public void TestSalaryWorker()
        {
            //Arrange
            SalaryWorker employee = new SalaryWorker(52000, "Ron", "Haywood");

            //Act
            double actualResult = employee.CalculateWeeklyPay(20);

            //Assert
            Assert.AreEqual(1000, actualResult);
        }

        [TestMethod]
        public void TestSalaryWorkerOvertime()
        {
            //Arrange
            SalaryWorker employee = new SalaryWorker(52000, "Ron", "Haywood");

            //Act
            double actualResult = employee.CalculateWeeklyPay(60);

            //Assert
            Assert.AreEqual(1000, actualResult);
        }
    }
}

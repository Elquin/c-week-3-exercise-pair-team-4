using EmployeePayroll.CLasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Tests
{
    [TestClass]
    public class VolunteerWorkerTest
    {
        [TestMethod]
        public void TestHourlyWorker()
        {
            //Arrange
            VolunteerWorker employee = new VolunteerWorker("Ron", "Haywood");

            //Act
            double actualResult = employee.CalculateWeeklyPay(40);

            //Assert
            Assert.AreEqual(0, actualResult);
        }

       
    }
}

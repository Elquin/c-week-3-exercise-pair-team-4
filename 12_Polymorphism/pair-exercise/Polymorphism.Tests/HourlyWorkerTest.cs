using EmployeePayroll.CLasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polymorphism.Tests;

namespace Polymorphism.Tests
{
    [TestClass]
    public class HourlyWorkerTest
    {
        [TestMethod]
        public void TestHourlyWorker()
        {
            //Arrange
            HourlyWorker employee = new HourlyWorker(15, "Ron", "Haywood");

            //Act
            double actualResult = employee.CalculateWeeklyPay(20);

            //Assert
            Assert.AreEqual(300, actualResult);
        }

        [TestMethod]
        public void TestHourlyWorkerOvertime()
        {
            //Arrange
            HourlyWorker employee = new HourlyWorker(15, "Ron", "Haywood");

            //Act
            double actualResult = employee.CalculateWeeklyPay(60);

            //Assert
            Assert.AreEqual(1050, actualResult);
        }
    }
}

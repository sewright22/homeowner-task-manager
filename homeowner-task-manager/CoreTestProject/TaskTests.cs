using Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CoreTestProject
{
    [TestClass]
    public class TaskTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            DateTime expectedDate = DateTime.Now.AddDays(5).Date;

            Task monthlyTask = new Task(5);

            Assert.AreEqual(expectedDate, monthlyTask.DueDate.Date);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DateTime expectedDate = DateTime.Now.AddDays(5).Date;

            var monthlyRepairTask = new RepairTask("Test Repair", 5);

            Assert.AreEqual(expectedDate, monthlyRepairTask.DueDate.Date);
            Assert.AreEqual("Test Repair", monthlyRepairTask.Name);
        }

        [TestMethod]
        public void TestMethod3()
        {
            DateTime expectedDate = DateTime.Now.AddDays(5).Date;

            var monthlyRepairTask = new RepairTask("Test Repair", 5);

            try
            {
                monthlyRepairTask.CalculateNumberOfDaysTilDueDate();
                monthlyRepairTask.DueDate = expectedDate;
                monthlyRepairTask.Name = "";
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            //catch (ArgumentOutOfRangeException aoore)
            //{
            //    Console.WriteLine(aoore.Message);
            //}

            Assert.AreEqual(expectedDate, monthlyRepairTask.DueDate.Date);
            Assert.AreEqual("Test Repair", monthlyRepairTask.Name);
        }
    }
}
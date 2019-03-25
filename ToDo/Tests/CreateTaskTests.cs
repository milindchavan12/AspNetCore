using System;
using NUnit.Framework;
using ToDo.Domains;

namespace Tests
{
    public class CreateTaskTests : AssertionHelper
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DescriptionAndNoDueDate_When_DueDateIsEmpty()
        {
            var input = "Pick up groceries";
            var taskItem = new TaskItem(input, default(DateTime));

            Expect(taskItem.Description, EqualTo(input));
            Assert.AreEqual(input, taskItem.Description);
            Assert.AreEqual(null, taskItem.DueDate);
        }

        [Test]
        public void MayDueDate_When_DueDateMonthIsMay()
        {
            var input = "Pick up groceries may 5";

            var taskItem = new TaskItem(input, new DateTime(DateTime.Today.Year, 5, 5));

            Expect(taskItem.DueDate, EqualTo(new DateTime(DateTime.Today.Year, 5, 5)));
        }

        [Test]
        [TestCase("groceries jan 5", 1)]
        [TestCase("groceries feb 5", 2)]
        [TestCase("groceries mar 5", 3)]
        [TestCase("groceries apr 5", 4)]
        [TestCase("groceries may 5", 5)]
        [TestCase("groceries jun 5", 6)]
        [TestCase("groceries jul 5", 7)]
        [TestCase("groceries aug 5", 8)]
        [TestCase("groceries sep 5", 9)]
        [TestCase("groceries oct 5", 10)]
        [TestCase("groceries nov 5", 11)]
        [TestCase("groceries dec 5", 12)]
        public void MonthDueDate_When_RespectiveMonthProvided(string input, int expectedMonth)
        {
            var taskItem = new TaskItem(input, new DateTime(DateTime.Today.Year, 5, 5));

            Expect(taskItem.DueDate, Is.Not.Null);
            Expect(taskItem.DueDate.Value.Month, EqualTo(expectedMonth));
        }

        [Test]
        public void TwoDigitDay_ParseBothDigits()
        {
            var input = "groceries may 15";

            var taskItem = new TaskItem(input, default(DateTime));

            Expect(taskItem.DueDate.Value.Day, EqualTo(15));
        }

        [Test]
        public void DayPastTheLastDayOfMonth_DoNOParseDueDate()
        {
            var input = "groceries may 44";

            var taskItem = new TaskItem(input, default(DateTime));

            Expect(taskItem.DueDate, Is.Null);
        }
    }
}
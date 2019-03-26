using System;
using AspNetCore.UnitTestDemo.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetCore.UnitTestDemo.Tests
{
    [TestClass]
    public class CalculatorFixture
    {
        [TestInitialize]
        public void OnTestInitialize()
        {
            _SystemUnderTest = null;
        }

        private Calculator _SystemUnderTest;
        public Calculator SystemUnderTest
        {
            get 
            { 
                if(_SystemUnderTest == null)
                {
                    _SystemUnderTest = new Calculator();
                }
                return _SystemUnderTest;
            }
        }
        

        [TestMethod]
        public void Add()
        {
            //arrange
            int value1 = 3;
            int value2 = 2;
            int expected = 5;

            //act
            int actual = SystemUnderTest.Add(value1, value2);

            //assert
            Assert.AreEqual(expected, actual, "Wrong Result");
        }

        [TestMethod]
        public void Subtract()
        {
            //arrange
            int value1 = 5;
            int value2 = 2;
            int expected = 3;

            //act
            int actual = SystemUnderTest.Subtract(value1, value2);

            //assert
            Assert.AreEqual(expected, actual, "Wrong Result");
        }

        [TestMethod]
        public void Multipy()
        {
            //arrange
            int value1 = 5;
            int value2 = 2;
            int expected = 10;

            //act
            int actual = SystemUnderTest.Multipy(value1, value2);

            //assert
            Assert.AreEqual(expected, actual, "Wrong Result");
        }

        [TestMethod]
        public void Divide()
        {
            //arrange
            int value1 = 10;
            int value2 = 2;
            int expected = 5;

            //act
            int actual = SystemUnderTest.Divide(value1, value2);

            //assert
            Assert.AreEqual(expected, actual, "Wrong Result");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DivideByZero_ThrowsException()
        {
            //arrange
            int value1 = 5;
            int value2 = 0;

            //act
            int actual = SystemUnderTest.Divide(value1, value2);
        }
    }
}

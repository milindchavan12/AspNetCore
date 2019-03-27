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
            double value1 = 3;
            double value2 = 2;
            double expected = 5;

            //act
            double actual = SystemUnderTest.Add(value1, value2);

            //assert
            Assert.AreEqual(expected, actual, "Wrong Result");
        }

        [TestMethod]
        public void Subtract()
        {
            //arrange
            double value1 = 5;
            double value2 = 2;
            double expected = 3;

            //act
            double actual = SystemUnderTest.Subtract(value1, value2);

            //assert
            Assert.AreEqual(expected, actual, "Wrong Result");
        }

        [TestMethod]
        public void Multipy()
        {
            //arrange
            double value1 = 5;
            double value2 = 2;
            double expected = 10;

            //act
            double actual = SystemUnderTest.Multiply(value1, value2);

            //assert
            Assert.AreEqual(expected, actual, "Wrong Result");
        }

        [TestMethod]
        public void Divide()
        {
            //arrange
            double value1 = 10;
            double value2 = 2;
            double expected = 5;

            //act
            double actual = SystemUnderTest.Divide(value1, value2);

            //assert
            Assert.AreEqual(expected, actual, "Wrong Result");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DivideByZero_ThrowsException()
        {
            //arrange
            double value1 = 5;
            double value2 = 0;

            //act
            double actual = SystemUnderTest.Divide(value1, value2);
        }
    }
}

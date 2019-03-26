using AspNetCore.UnitTestDemo.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetCore.UnitTestDemo.Tests
{
    [TestClass]
    public class CalculatorFixture
    {
        [TestMethod]
        public void Add()
        {
            //arrange
            int value1 = 3;
            int value2 = 2;
            int expected = 5;

            //act
            var sut = new Calculator();
            int actual = sut.Add(value1, value2);

            //assert
            Assert.AreEqual(expected, actual, "Wrong Result");
        }
    }
}


using AspNetCore.UnitTestDemo.WebUi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetCore.UnitTestDemo.Tests.Presentation
{
    [TestClass]
    public class CalculatorControllerFixture
    {
        private CalculatorController _SystemUnderTest;
        public CalculatorController SystemUnderTest
        {
            get
            {
                if (_SystemUnderTest == null)
                {
                    _SystemUnderTest = new CalculatorController();
                }
                return _SystemUnderTest;
            }
        }
        
        [TestMethod]
        public void CalculatorController_Index_ModelIsNotNull()
        {
            var actual = SystemUnderTest.Index();

            Assert.IsNotNull(actual, "Model was null");
        }
    }
}
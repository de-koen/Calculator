using CalculatorNS;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Addition_Tests()
        {
            double firstNumber = 18.04;
            double secondNumber = 22;
            double expected = 40.04;

            Assert.AreEqual(expected, Calculator.DoOperation(firstNumber, secondNumber, "a"));
        }

        [TestMethod]
        public void Division_Tests()
        {
            double firstNumber = 1;
            double secondNumber = 0;
            string excpectedMessage = "Division by zero";

            try
            {
                Calculator.DoOperation(firstNumber, secondNumber, "d");
            }
            catch (System.DivideByZeroException e)
            {
                StringAssert.Contains(e.Message, excpectedMessage);
                return;
            }

            Assert.Fail("The expected exception was not thrown.");
        }
    }
}
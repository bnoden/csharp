using System;
using bnCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace bnCalculatorUnitTests
{
    [TestClass]
    public class CalculatorUnitTests
    {
        [TestMethod]
        public void Test25x25() {
            double a = 25;
            double b = 25;
            double expected = 625;
            var calc = new Calculator();

            double actual = calc.Multiply(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test106x238() {
            double a = 106;
            double b = 238;
            double expected = 25228;
            var calc = new Calculator();

            double actual = calc.Multiply(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDouble() {
            double a = 5.08;
            double b = 32.46;
            double expected = 164.8968;
            var calc = new Calculator();

            double actual = calc.Multiply(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}

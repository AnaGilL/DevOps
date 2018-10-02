using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcNs;

namespace CalcTest
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void DivCorrect()
        {
            double val1 = 11.99;
            double val2 = 4.55;
            double expected = 2.63;
            Calc calc = new Calc();
            double result = calc.Div(val1, val2);
            
            Assert.AreEqual(expected, result, 0.001, "Division correct");
        }
    }
}

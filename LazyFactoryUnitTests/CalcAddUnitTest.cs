using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LazyFactoryWpf;

namespace LazyFactoryUnitTests
{
    [TestClass]
    public class CalcAddUnitTest
    {
        ICalc calc;
        [TestInitialize]
        public void CalcAddUnitTestPrepare()
        {
            calc = new CalcAdd();
        }
        [TestMethod]
        public void CalcAddZerosReturnZero()
        {
            var x= calc.Calc2Ints(0,0);
            Assert.AreEqual(x, 0);
        }
        [TestMethod]
        public void CalcAddOneAndZeroReturnOne()
        {
            var x = calc.Calc2Ints(1, 0);
            Assert.AreEqual(x, 1);
        }
        [TestMethod]
        public void CalcAddOneAndOneReturnTwo()
        {
            var x = calc.Calc2Ints(1, 1);
            Assert.AreEqual(x, 2);
        }
    }
}

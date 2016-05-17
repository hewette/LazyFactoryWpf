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
        public void AddUnitTestPrepare()
        {
            calc = new CalcAdd();
        }
        [TestMethod]
        public void Add_ZeroandZero_ReturnsZero()
        {
            var x= calc.Calc2Ints(0,0);
            Assert.AreEqual(x, 0);
        }
        [TestMethod]
        public void Add_OneAndZero_ReturnsOne()
        {
            var x = calc.Calc2Ints(1, 0);
            Assert.AreEqual(x, 1);
        }
        [TestMethod]
        public void Add_OneAndOne_ReturnsTwo()
        {
            var x = calc.Calc2Ints(1, 1);
            Assert.AreEqual(x, 2);
        }
    }
}

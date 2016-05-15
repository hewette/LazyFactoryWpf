using LazyFactoryWpf;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LazyFactoryUnitTests
{
    [TestClass]
    public class CalcMultiplyUnitTest
    {
        ICalc calc;
        [TestInitialize]
        public void CalcAddUnitTestPrepare()
        {
            calc = new CalcMultiply();
        }

        [TestMethod]
        public void CalcMultiplyZerobyZeroReturnZero()
        {
            var x = calc.Calc2Ints(0, 0);
            Assert.AreEqual(0, x);
        }

        [TestMethod]
        public void CalcMultiplyOnebyZeroReturnZero()
        {
            var x = calc.Calc2Ints(1, 0);
            Assert.AreEqual(0, x);
        }

        [TestMethod]
        public void CalcMultiplyOnebyOneReturnOne()
        {
            var x = calc.Calc2Ints(1, 1);
            Assert.AreEqual(1, x);
        }

        [TestMethod]
        public void CalcMultiplyTwobyTwoReturnFour()
        {
            var x = calc.Calc2Ints(2, 2);
            Assert.AreEqual(4, x);
        }
    }
}

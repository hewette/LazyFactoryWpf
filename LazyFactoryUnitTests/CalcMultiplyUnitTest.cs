using LazyFactoryWpf;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LazyFactoryUnitTests
{
    [TestClass]
    public class CalcMultiplyUnitTest
    {
        ICalc calc;
        [TestInitialize]
        public void CalcMultiply_UnitTestPrepare()
        {
            calc = new CalcMultiply();
        }

        [TestMethod]
        public void Multiply_ZerobyZero_ReturnsZero()
        {
            var x = calc.Calc2Ints(0, 0);
            Assert.AreEqual(0, x);
        }

        [TestMethod]
        public void Multiply_OnebyZero_ReturnsZero()
        {
            var x = calc.Calc2Ints(1, 0);
            Assert.AreEqual(0, x);
        }

        [TestMethod]
        public void Multiply_OnebyOne_ReturnsOne()
        {
            var x = calc.Calc2Ints(1, 1);
            Assert.AreEqual(1, x);
        }

        [TestMethod]
        public void Multiply_TwobyTwo_ReturnsFour()
        {
            var x = calc.Calc2Ints(2, 2);
            Assert.AreEqual(4, x);
        }
    }
}

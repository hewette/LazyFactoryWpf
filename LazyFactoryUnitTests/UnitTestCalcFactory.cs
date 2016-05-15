using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LazyFactoryWpf;

namespace LazyFactoryUnitTests
{
    /// <summary>
    /// Summary description for UnitTestCalcFactory
    /// </summary>
    [TestClass]
    public class UnitTestCalcFactory
    {
        ICalcFactory calcFactory;
        public UnitTestCalcFactory()
        {
            calcFactory = new CalcFactory();
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void GetCalculatorusingNotImplementedCalcType()
        {
            var x = calcFactory.getCalculatorFunction(CalcFactory.CalcTypes.SubStract);
            //Assert Exception
        }

        [TestMethod]
        public void GetCalculatorusingValidAddCalcType()
        {
            var x = calcFactory.getCalculatorFunction(CalcFactory.CalcTypes.Add).Calc2Ints(2,2);
            Assert.AreEqual(4, x);
        }

        [TestMethod]
        public void GetCalculatorusingValidMultiplyCalcType()
        {
            var x = calcFactory.getCalculatorFunction(CalcFactory.CalcTypes.Multiply).Calc2Ints(2, 2);
            Assert.AreEqual(4, x);
        }
    }
}

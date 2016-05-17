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
        public void IsInvalidCalcType_UseNotImplementedCalcType_ThrowsNotImplemented()
        {
            var x = calcFactory.getCalculatorFunction(CalcFactory.CalcTypes.NotImpemented);
            //Assert Exception
        }

        [TestMethod]
        public void GetCalculator_withValidTypeCalcAdd_ReturnsTypeofCalcAdd()
        {
            var x = calcFactory.getCalculatorFunction(CalcFactory.CalcTypes.Add);
            Assert.AreEqual(typeof( CalcAdd),x.GetType());
        }

        [TestMethod]
        public void GetCalculator_withValidTypeCalcMultiply_ReturnsTypeofCalcMultiply()
        {
            var x = calcFactory.getCalculatorFunction(CalcFactory.CalcTypes.Multiply);
            Assert.AreEqual(typeof(CalcMultiply), x.GetType());
        }

        [TestMethod]
        public void UseCalcFactory_WithCalcAdd_ReturnsFour()
        {
            var x = calcFactory.getCalculatorFunction(CalcFactory.CalcTypes.Add).Calc2Ints(2,2);
            Assert.AreEqual(4, x);
        }


        [TestMethod]
        public void UseCalcFactory_WithCalcMultiply_ReturnsFour()
        {
            var x = calcFactory.getCalculatorFunction(CalcFactory.CalcTypes.Multiply).Calc2Ints(2, 2);
            Assert.AreEqual(4, x);
        }
    }
}

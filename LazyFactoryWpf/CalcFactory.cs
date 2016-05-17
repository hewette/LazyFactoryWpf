using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyFactoryWpf
{
    public class CalcFactory : ICalcFactory
    {
        public enum CalcTypes: byte { Add, Multiply, SubStract, Devide, NotImpemented  }
        Dictionary<CalcTypes, Lazy<ICalc>> calcOptions;

        // TODO DI these details from web.config or Entityframework
        public CalcFactory()
        {
            calcOptions = new Dictionary<CalcTypes, Lazy<ICalc>>
             {
                { CalcTypes.Add, new Lazy<ICalc>(() => new CalcAdd()) },
                { CalcTypes.Multiply, new Lazy<ICalc>(() => new CalcMultiply()) },
            };
        }

        public ICalc getCalculatorFunction(CalcTypes calcType)
        {
            Lazy<ICalc> calculator;
            if(!calcOptions.TryGetValue(calcType, out calculator))
            {
                throw new NotImplementedException(string.Format("There is no implementation of requested calculator: {0}", calcType));
            }
            return calculator.Value;
        }
    }
}

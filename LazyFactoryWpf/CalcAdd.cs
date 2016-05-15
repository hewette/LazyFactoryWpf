using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyFactoryWpf
{
    public class CalcAdd : ICalc
    {
        public int Calc2Ints(int a, int b)
        {            
            return a+b;
        }
    }
}

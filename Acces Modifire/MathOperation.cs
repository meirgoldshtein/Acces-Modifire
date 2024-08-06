using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acces_Modifire
{
    internal class MathOperation
    {
        Calculator calculator = new Calculator();
        public int Add(int a, int b)
        {
            return calculator.Add(a, b);
        }
    }
}

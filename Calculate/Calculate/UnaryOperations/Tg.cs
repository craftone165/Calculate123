using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate.UnaryOperations
{
    public class Tg : IUnaryOperation
    {
        public string Calculate(double firstArgument)
        {
            double result = Math.Tan(firstArgument);
            return result.ToString();
        }
    }
}

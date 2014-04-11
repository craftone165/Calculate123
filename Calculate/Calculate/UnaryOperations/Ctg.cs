using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate.UnaryOperations
{
    public class Ctg : IUnaryOperation
    {
        public string Calculate(double firstArgument)
        {
            double result = Math.Atan(firstArgument);
            return result.ToString();
        }
    }
}

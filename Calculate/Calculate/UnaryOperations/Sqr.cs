using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate.UnaryOperations
{
    public class Sqr : IUnaryOperation
    {
        public string Calculate(double firstArgument)
        {
            double result = Math.Pow(firstArgument,2);
            return result.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate.UnaryOperations
{
    public class Arcsin : IUnaryOperation
    {
        public string Calculate(double firstArgument)
        {
            double result = Math.Asin(firstArgument);
            return result.ToString();
        }
    }
}

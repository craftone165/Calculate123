using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate.UnaryOperations
{
    public class Sqrt : IUnaryOperation
    {
        public string Calculate(double firstArgument)
        {
            double result = Math.Sqrt(firstArgument);
            return result.ToString();
        }
    }
}

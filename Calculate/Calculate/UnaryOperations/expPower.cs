using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate.UnaryOperations
{
    public class expPower : IUnaryOperation
    {
        public string Calculate(double firstArgument)
        {
            double result = Math.Exp(firstArgument);
            return result.ToString();
        }
    }
}

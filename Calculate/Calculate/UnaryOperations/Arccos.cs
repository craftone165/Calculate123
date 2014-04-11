using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate.UnaryOperations
{
    public class Arccos : IUnaryOperation
    {
        public string Calculate(double firstArgument)
        {
            double result = Math.Acos(firstArgument);
            return result.ToString();
        }
    }
}

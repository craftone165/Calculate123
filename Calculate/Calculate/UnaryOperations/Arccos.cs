using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate.UnaryOperations
{
    public class Arccos : IUnaryOperation
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Acos(firstArgument);
            return result;
        }
    }
}

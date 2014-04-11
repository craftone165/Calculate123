using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate.UnaryOperations
{
    public class Sin : IUnaryOperation
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Sin(firstArgument);
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate.UnaryOperations
{
    public class Log2 : IUnaryOperation
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Log(firstArgument,2);
            return result;
        }
    }
}

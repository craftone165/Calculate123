using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate.UnaryOperations
{
    public class Cos : IUnaryOperation
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Cos(firstArgument);
            return result; 
        }
    }
}

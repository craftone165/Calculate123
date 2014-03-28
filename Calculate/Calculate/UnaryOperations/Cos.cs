using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate.UnaryOperations
{
    public class Cos : IUnaryOperation
    {
        public string Calculate(double firstArgument)
        {
            double result = Math.Cos(firstArgument);
            return result.ToString(); 
        }
    }
}

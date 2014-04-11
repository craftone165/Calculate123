using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate.UnaryOperations
{
    public class Ln : IUnaryOperation
    {
        public string Calculate(double firstArgument)
        {
            double result = Math.Log10(firstArgument);
            return result.ToString();
        }
    }
}

using System;

namespace Calculate.UnaryOperations
{
    public class Ln : IUnaryOperation
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Log(firstArgument);
            return result;
        }
    }
}

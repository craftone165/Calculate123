using System;

namespace Calculate.UnaryOperations
{
    public class Arcsin : IUnaryOperation
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Asin(firstArgument);
            return result;
        }
    }
}

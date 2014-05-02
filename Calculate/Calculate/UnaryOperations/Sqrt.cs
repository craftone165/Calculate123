using System;

namespace Calculate.UnaryOperations
{
    public class Sqrt : IUnaryOperation
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Sqrt(firstArgument);
            return result;
        }
    }
}

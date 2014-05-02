using System;

namespace Calculate.UnaryOperations
{
    public class Sqr : IUnaryOperation
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Pow(firstArgument,2);
            return result;
        }
    }
}

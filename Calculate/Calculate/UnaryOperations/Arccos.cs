using System;

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

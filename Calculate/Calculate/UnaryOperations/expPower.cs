using System;

namespace Calculate.UnaryOperations
{
    public class expPower : IUnaryOperation
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Exp(firstArgument);
            return result;
        }
    }
}

using System;

namespace Calculate.UnaryOperations
{
    public class Tg : IUnaryOperation
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Tan(firstArgument);
            return result;
        }
    }
}

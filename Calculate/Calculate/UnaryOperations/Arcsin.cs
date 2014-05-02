using System;

namespace Calculate.UnaryOperations
{
    public class Arcsin : IUnaryOperation
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument < 0 || firstArgument > 1)
            {
                throw new ArgumentException("Недопустимые значения");
            }
            double result = Math.Asin(firstArgument);
            return result;
        }
    }
}

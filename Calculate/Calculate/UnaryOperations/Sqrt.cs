using System;

namespace Calculate.UnaryOperations
{
    public class Sqrt : IUnaryOperation
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument < 0)
            {
                throw new ArgumentException("Недопустимые значения");
            }
            double result = Math.Sqrt(firstArgument);
            return result;
        }
    }
}

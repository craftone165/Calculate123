using System;

namespace Calculate.UnaryOperations
{
    public class Log2 : IUnaryOperation
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument <= 0)
            {
                throw new ArgumentException("Логарифм от чисел меньше 0 не существует");
            }
            double result = Math.Log(firstArgument,2);
            return result;
        }
    }
}

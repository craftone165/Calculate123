using System;

namespace Calculate.BinaryOperations
{
    class Divider : IBinaryOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new ArgumentException("Делить на 0 нельзя");
            }
            double result = firstArgument / secondArgument;
            return result;
        }
    }
}


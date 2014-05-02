using System;

namespace Calculate.UnaryOperations
{
    public class Ctg : IUnaryOperation
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Cos(firstArgument)/Math.Sin(firstArgument);
            return result;
        }
    }
}

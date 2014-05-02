using System;

namespace Calculate.UnaryOperations
{
    public class Pix : IUnaryOperation
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Pow(Math.PI,firstArgument);
            return result;
        }
    }
}

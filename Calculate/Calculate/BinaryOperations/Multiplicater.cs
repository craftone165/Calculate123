namespace Calculate.BinaryOperations
{
    class Multiplicater : IBinaryOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            double result = firstArgument * secondArgument;
            return result;
        }
    }
}


namespace Calculate.BinaryOperations
{
    class Multiplicater : IBinaryOperation
    {
        public string Calculate(double firstArgument, double secondArgument)
        {
            double result = firstArgument * secondArgument;
            return result.ToString();
        }
    }
}


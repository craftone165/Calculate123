namespace Calculate.BinaryOperations
{
    class Substracter : IBinaryOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            double result = firstArgument - secondArgument;
            return result;
        }
    }
}




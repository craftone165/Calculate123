namespace Calculate.BinaryOperations
{
    class Substracter : IBinaryOperation
    {
        public string Calculate(double firstArgument, double secondArgument)
        {
            double result = firstArgument - secondArgument;
            return result.ToString();
        }
    }
}




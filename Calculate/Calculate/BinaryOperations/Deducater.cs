namespace Calculate.BinaryOperations
{
    class Deducater : IBinaryOperation
    {
        public string Calculate(double firstArgument, double secondArgument)
        {
            double result = firstArgument / secondArgument;
            return result.ToString();
        }
    }
}


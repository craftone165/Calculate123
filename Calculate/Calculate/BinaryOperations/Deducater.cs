namespace Calculate.BinaryOperations
{
    class Deducater : IBinaryOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            double result = firstArgument / secondArgument;
            return result;
        }
    }
}


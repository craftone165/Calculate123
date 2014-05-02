namespace Calculate.BinaryOperations
{
    class Divider : IBinaryOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            double result = firstArgument / secondArgument;
            return result;
        }
    }
}


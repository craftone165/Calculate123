namespace Calculate.BinaryOperations
{
    public class Adder: IBinaryOperation

{
    public double Calculate(double firstArgument, double secondArgument)
    {
        double result = firstArgument + secondArgument;
        return result;
    }
}
}

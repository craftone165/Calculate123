using System;

namespace Calculate.BinaryOperations
{
    public static class BinaryOperationFactory
    {
        public static IBinaryOperation CreateOperation(string name)
        {
            switch (name)
            {
                case "+":
                    return new Adder();
                case "-":
                    return new Substracter();
                case "/":
                    return new Divider();
                case "*":
                    return new Multiplicater();
                default:
                    throw new ArgumentException("Неизвестный калькулятор","name");
            }
        }
    }
}
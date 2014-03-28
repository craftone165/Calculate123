﻿using System;

namespace Calculate.UnaryOperations
{
    public static class UnaryOperationFactory
    {
        public static IUnaryOperation CreateOperation(string name)
        {
            switch (name)
            {
                case "cos":
                    return new Cos();
                default:
                    throw new ArgumentException("Неизвестный калькулятор","name");
            }
        }
    }
}
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
                case "sin":
                    return new Sin();
                case "arcsin":
                    return new Arcsin();
                case "arccos":
                    return new Arccos();
                case "tg":
                    return new Tg();
                case "ctg":
                    return new Ctg();
                case "sqrt":
                    return new Sqrt();
                case "sqr":
                    return new Sqr();
                case "pix":
                    return new Pix();
                case "log2":
                    return new Log2();
                case "ln":
                    return new Ln();
                case "exppower":
                    return new expPower();
                default:
                    throw new ArgumentException("Неизвестный калькулятор","name");
            }
        }
    }
}
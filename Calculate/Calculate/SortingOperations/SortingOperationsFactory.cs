using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate.SortingOperations
{
    public static class SortingOperationsFactory
    {
        public static ISortingOperation CreateOperation(string name)
        {
            switch (name)
            {
                case "+":
               //     return new ();
                case "-":
               //     return new();
                default:
                    throw new ArgumentException("Неизвестный калькулятор", "name");
            }
        }
    }
}

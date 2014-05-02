using System;

namespace Calculate.SortingOperations
{
    public static class SortingOperationsFactory
    {
        public static ISortingOperation CreateOperation(string name)
        {
            switch (name)
            {
                case "bogosort":
                    return new BogoSort();
                case "quicksort":
                    return new QuickSort();
                default:
                    throw new ArgumentException("Неизвестный калькулятор", "name");
            }
        }
    }
}

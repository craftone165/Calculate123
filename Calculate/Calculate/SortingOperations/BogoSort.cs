using System;

namespace Calculate.SortingOperations
{
    public class BogoSort : ISortingOperation
    {
        private bool IsSorted(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].CompareTo(array[i + 1]) == 1)
                {
                    return false;
                }
            }
            return true;
        }

        private static void Swap(ref int a, ref int b)
        {
            int buffer = a;
            a = b;
            b = buffer;
        }

        private void Shuffle(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                Swap(ref array[i], ref array[random.Next(0, array.Length)]);
            }
        }

        public int[] Sort(int[] array)
        {
            while (!IsSorted(array))
            {
                Shuffle(array);
            }
            return array;
        }
    }
}

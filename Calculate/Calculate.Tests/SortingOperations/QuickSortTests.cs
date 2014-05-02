using Calculate.SortingOperations;
using NUnit.Framework;

namespace Calculate.Tests.SortingOperations
{
    public class QuickSortTests
    {
        [Test]
        public void CalculateTest()
        {
            ISortingOperation calculator = SortingOperationsFactory.CreateOperation("quicksort");
            int[] result = calculator.Sort(new []{1,6,3,76});
            int[] expected = new[] {1, 3, 6, 76};
            Assert.AreEqual(expected.Length, result.Length);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
        [Test]
        public void SecondSortTest()
        {
            ISortingOperation calculator = SortingOperationsFactory.CreateOperation("quicksort");
            int[] result = calculator.Sort(new[] { 156, 156, 76, 54, -5,-14});
            int[] expected = new[] {-14, -5, 54, 76, 156, 156};
            Assert.AreEqual(expected.Length, result.Length);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}

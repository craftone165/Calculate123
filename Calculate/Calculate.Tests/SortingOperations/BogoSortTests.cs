using Calculate.SortingOperations;
using NUnit.Framework;

namespace Calculate.Tests.SortingOperations
{
    public class BogoSortTests
    {
        [Test]
        public void CalculateTest()
        {
            ISortingOperation calculator = SortingOperationsFactory.CreateOperation("bogosort");
            int[] result = calculator.Sort(new []{1,6,3,76});
            int[] expected = new[] {1, 3, 6, 76};
            Assert.AreEqual(expected.Length, result.Length);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}

using Calculate.UnaryOperations;
using NUnit.Framework;

namespace Calculate.Tests.UnaryOperations
{
    [TestFixture]
    public class CtgTests
    {
        [Test]
        public void CalculateTest()
        {
            IUnaryOperation calculator = UnaryOperationFactory.CreateOperation("ctg");
            double result = calculator.Calculate(1);
            Assert.AreEqual(0.6421, result, 0.0001);
        }
    }
}
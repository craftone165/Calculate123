using Calculate.UnaryOperations;
using NUnit.Framework;

namespace Calculate.Tests.UnaryOperations
{
    [TestFixture]
    public class ArccosTests
    {
        [Test]
        public void CalculateTest()
        {
            IUnaryOperation calculator = UnaryOperationFactory.CreateOperation("arccos");
            double result = calculator.Calculate(0);
            Assert.AreEqual(1.5708, result, 0.0001);
        }
    }
}
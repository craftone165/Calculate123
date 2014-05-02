using Calculate.UnaryOperations;
using NUnit.Framework;

namespace Calculate.Tests.UnaryOperations
{
    [TestFixture]
    public class ArcsinTests
    {
        [Test]
        public void CalculateTest()
        {
            IUnaryOperation calculator = UnaryOperationFactory.CreateOperation("arcsin");
            double result = calculator.Calculate(1);
            Assert.AreEqual(1.5708, result, 0.0001);
        }
    }
}
using Calculate.UnaryOperations;
using NUnit.Framework;

namespace Calculate.Tests.UnaryOperations
{
    [TestFixture]
    public class SqrtTests
    {
        [Test]
        public void CalculateTest()
        {
            IUnaryOperation calculator = UnaryOperationFactory.CreateOperation("sqrt");
            double result = calculator.Calculate(4);
            Assert.AreEqual(2, result);
        }
    }
}
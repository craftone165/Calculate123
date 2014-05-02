using Calculate.UnaryOperations;
using NUnit.Framework;

namespace Calculate.Tests.UnaryOperations
{
    [TestFixture]
    public class LnTests
    {
        [Test]
        public void CalculateTest()
        {
            IUnaryOperation calculator = UnaryOperationFactory.CreateOperation("ln");
            double result = calculator.Calculate(8);
            Assert.AreEqual(2.0794, result, 0.0001);
        }
    }
}
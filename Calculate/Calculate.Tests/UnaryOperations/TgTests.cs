using Calculate.UnaryOperations;
using NUnit.Framework;

namespace Calculate.Tests.UnaryOperations
{
    [TestFixture]
    public class TgTests
    {
        [Test]
        public void CalculateTest()
        {
            IUnaryOperation calculator = UnaryOperationFactory.CreateOperation("tg");
            double result = calculator.Calculate(1);
            Assert.AreEqual(1.5574, result, 0.0001);
        }
    }
}
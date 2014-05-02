using Calculate.UnaryOperations;
using NUnit.Framework;

namespace Calculate.Tests.UnaryOperations
{
    [TestFixture]
    public class ExppowerxTests
    {
        [Test]
        public void CalculateTest()
        {
            IUnaryOperation calculator = UnaryOperationFactory.CreateOperation("exppower");
            double result = calculator.Calculate(3);
            Assert.AreEqual(20.0855, result, 0.0001);
        }
    }
}
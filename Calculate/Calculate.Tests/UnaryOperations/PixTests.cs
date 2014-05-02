using Calculate.UnaryOperations;
using NUnit.Framework;

namespace Calculate.Tests.UnaryOperations
{
    [TestFixture]
    public class PixTests
    {
        [Test]
        public void CalculateTest()
        {
            IUnaryOperation calculator = UnaryOperationFactory.CreateOperation("pix");
            double result = calculator.Calculate(2);
            Assert.AreEqual(9.8696, result, 0.0001);
        }
    }
}
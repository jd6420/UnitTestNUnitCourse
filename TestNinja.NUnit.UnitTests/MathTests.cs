using NUnit.Framework;

namespace TestNinja.NUnit.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Fundamentals.Math _math;
        [SetUp]
        public void Setup()
        {
            _math = new Fundamentals.Math();
        }

        [Test]
        //[Ignore("Just because")]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            var result = _math.Add(2, 3);

            Assert.AreEqual(5, result);
            //Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        [TestCase(2, 1, 2)] // Primer argumento mayor
        [TestCase(1, 2, 2)] // Segundo argumento mayor
        [TestCase(1, 1, 1)] // Argumentos iguales
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);

            Assert.AreEqual(expectedResult, result);
        }
    }
}

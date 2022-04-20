using NUnit.Framework;
using System.Linq;

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

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumberUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            // Propios
            //Assert.IsNotEmpty(result);

            //Assert.AreEqual(result.Count(), 3);

            //Assert.Contains(1, result.ToList());
            //Assert.Contains(3, result.ToList());
            //Assert.Contains(5, result.ToList());

            Assert.AreEqual(new[] { 1, 3, 5 }, result);

            // Curso
            //Assert.That(result, Is.Not.Empty);

            //Assert.That(result.Count(), Is.EqualTo(3));

            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            //Assert.That(result, Is.EquivalentTo(new [] { 1, 3, 5 }));

            //Assert.That(result, Is.Ordered); // verifica si el array está organizado
            //Assert.That(result, Is.Unique); // verifica que no tenga elementos repetidos
        }
    }
}

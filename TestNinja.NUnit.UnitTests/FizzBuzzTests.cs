using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.NUnit.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(15, "FizzBuzz")]
        [TestCase(6, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(4, "4")]
        public void GetOutput(int number, string message)
        {
            var result = FizzBuzz.GetOutput(number);

            //Assert.AreEqual(message, result);

            Assert.That(result, Is.EqualTo(message).IgnoreCase);
        }
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.NUnit.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        private ErrorLogger _errorLogger;
        [SetUp]
        public void Setup()
        {
            _errorLogger = new ErrorLogger();
        }

        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            //var errorLogger = new ErrorLogger();

            _errorLogger.Log("a");

            // Propio
            //Assert.AreEqual("a", errorLogger.LastError);

            // Clase
            Assert.That(_errorLogger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            //_errorLogger.Log(error);

            // Propio
            Assert.Throws<ArgumentNullException>(() => _errorLogger.Log(error));

            // Clase
            //Assert.That(() => _errorLogger.Log(error), Throws.ArgumentNullException);
            //Assert.That(() => _errorLogger.Log(error), Throws.Exception.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var id = Guid.Empty;
            _errorLogger.ErrorLogged += (sender, args) => { id = args; };

            _errorLogger.Log("a");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.NUnit.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        private CustomerController _customerController;
        [SetUp]
        public void Setup()
        {
            _customerController = new CustomerController();
        }

        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var result = _customerController.GetCustomer(0);

            // Propio
            //Assert.IsInstanceOf(typeof(NotFound), result);
            //Assert.IsInstanceOf<NotFound>(result);

            // Clase
            Assert.That(result, Is.TypeOf<NotFound>()); // Not found
            //Assert.That(result, Is.InstanceOf<NotFound>()); // Not found or derivatives
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            var result = _customerController.GetCustomer(1);

            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}

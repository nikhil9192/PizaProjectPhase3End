using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using Pizza_App_Phase_4_project.Controllers;
using Pizza_App_Phase_4_project.Models;

namespace TestProject
{
    [TestFixture]
    public class PizzaControllerTests
    {
        private PizzaController pizzaController;

        [SetUp]
        public void Setup()
        {
            // Initialize the PizzaController
            pizzaController = new PizzaController();
        }

        [Test]
        public void Index_ReturnsViewResult_WithListOfPizzas()
        {
            // Act
            IActionResult result = pizzaController.Index();

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);

            var viewResult = (ViewResult)result;
            Assert.IsInstanceOf<List<Pizza>>(viewResult.Model);
        }

        [Test]
        public void Cart_ReturnsViewResult_WithFoundPizza()
        {
            // Arrange
            int pizzaId = 100;

            // Act
            IActionResult result = pizzaController.Cart(pizzaId);

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);

            var viewResult = (ViewResult)result;
            Assert.IsInstanceOf<Pizza>(viewResult.Model);
        }

        [Test]
        public void Checkout_ReturnsViewResult_WithListOfOrderInfo()
        {
            // Act
            IActionResult result = pizzaController.Checkout();

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);

            var viewResult = (ViewResult)result;
            Assert.IsInstanceOf<List<OrderInfo>>(viewResult.Model);
        }

        // Add more tests for the Cart POST action and other controller logic as needed

        [TearDown]
        public void TearDown()
        {
            // Dispose resources if needed
        }
    }
}

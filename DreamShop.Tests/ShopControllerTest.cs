using Core;
using DreamShop.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace DreamShop.Tests
{
    [TestClass]
    public class ShopControllerTest
    {
        [TestMethod]
        public void GetProductTest_ReturnsProductIsNotNull()
        {
            var mock = new Mock<IRepo>();
            mock.Setup(repo => repo.GetProduct(3)).Returns(new Product());
            var controller = new ShopController(mock.Object);

            var result = controller.GetProduct(3);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetCategoryProducts_ReturnsProductArrayIsNotEmpty()
        {
            var mock = new Mock<IRepo>();
            mock.Setup(repo => repo.GetCategoryProducts(3)).Returns(new List<Product>() { new Product() });
            var controller = new ShopController(mock.Object);

            var result = controller.GetCategoryProducts(3);

            Assert.IsTrue(result.Any());
        }

        [TestMethod]
        public void GetCategoryProducts_ReturnsProductTreeContaintRootCategory()
        {
            var mock = new Mock<IRepo>();
            mock.Setup(repo => repo.GetCategoryTree()).Returns(MoqRepo.FillData());
            var controller = new ShopController(mock.Object);

            var result = controller.GetCategoryTree();

            Assert.IsNotNull(result.First());
            Assert.IsTrue(result.First().Name == "Root Category");
        }
    }
}

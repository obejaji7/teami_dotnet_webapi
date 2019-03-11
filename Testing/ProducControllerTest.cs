using Microsoft.VisualStudio.TestTools.UnitTesting;
using TEHomeTest.Controllers;
using System.Linq;
using Service.ProductService;
using Entities.Models;
using Moq;

namespace Testing
{
    [TestClass]
    public class ProducControllerTest
    {
        [TestMethod]
        public void Make_A_Successfull_Get_All_Products()
        {
            FakeProductService stub = new FakeProductService();
            var productController = new ProductsController(stub);

            var products = productController.Get();

            Assert.IsNotNull(products);
        }

        [TestMethod]
        public void Make_A_Successfull_Get_Product_By_Category()
        {
            FakeProductService stub = new FakeProductService();
            var productController = new ProductsController(stub);

            var products = productController.Get("Tech");

            Assert.IsNotNull(products);
        }

        [TestMethod]
        public void Get_At_Least_One_Product()
        {
            FakeProductService stub = new FakeProductService();
            var productController = new ProductsController(stub);

            var products = productController.Get();

            Assert.IsTrue(products.Count() > 0);
        }

        [TestMethod]
        public void Get_At_Least_One_Product_With_Tech_Category()
        {
            FakeProductService stub = new FakeProductService();
            var productController = new ProductsController(stub);

            var products = productController.Get("Tech");

            Assert.IsTrue(products.Count() > 0);
        }

    }
}

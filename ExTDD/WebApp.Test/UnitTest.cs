using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Controllers;
using WebApp.Services;
using Xunit;

namespace WebApp.Test
{
   public class UnitTest
    {
        [Fact]
        public void Test_MockBehavior()
        {
            var moq = new Mock<IProductService>(MockBehavior.Strict);
            moq.Setup(p => p.GetProductPrice(1)).Returns(15000);
            var result = moq.Object.GetProductPrice(1);
            Assert.IsType<int>(result);
        }

        [Fact]
        public void Test_PropertySetupTest()
        {
            var moq = new Mock<IProductService>();
            moq.Setup(p => p.ProductCount).Returns(25);
        }
        [Fact]
        public void Test_Add_Product_SaveState()
        {
            var moq = new Mock<IProductService>();
            Product product = new Product { Id = 1, Name = "test" };
            moq.SetupAllProperties();
            HomeController controller = new HomeController(moq.Object);
            controller.AddProduct(product);

            Assert.Equal(1, moq.Object.ProductCount);
        }

        [Fact]
        public void Test_It()
        {
            var moq = new Mock<IProductService>();

            int[] ids = new int[] { 5, 85, 45, 745, 86, 896569, 56, 1 };
            moq.Setup(p => p.GetProductPrice(It.IsAny<int>())).Returns(1000);
            moq.Setup(p => p.GetProductPrice(It.IsIn(ids))).Returns(2000);
        }

    }
}

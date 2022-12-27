using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Controllers;
using WebApp.Models.MockData;
using WebApp.Services;
using Xunit;

namespace WebApp.Test
{
    public class BookApiControllerTest
    {
        moqData _moqdata;

        public BookApiControllerTest()
         {
             _moqdata = new moqData();
         }
        [Fact]
        public void GetTest()
        {
            //Arrange

            var moq = new Mock<IBooksService>();
            moq.Setup(p => p.GetAll()).Returns(_moqdata.GetAll());
            BookApiController apiController = new BookApiController(moq.Object);

            //Act

            var result = apiController.Get();

            //Assert
            Assert.IsType<OkObjectResult>(result);
            var list = result as OkObjectResult;
            Assert.IsType<List<Product>>(list.Value);
        }
    }
}

using SonOfCod.Controllers;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class NewsletterControllerTest
    {
        private readonly ApplicationDbContext db;

        [Fact]
        public void Get_ViewResult_Newsletter_Index_Test()
        {
            //Arrange
            NewsletterController controller = new NewsletterController(db);

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}

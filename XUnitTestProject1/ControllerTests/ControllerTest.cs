using SonOfCod.Controllers;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class ControllerTest
    {
        [Fact]
        public void Get_ViewResult_Marketing_Index_Test()
        {
            //Arrange
            MarketingController controller = new MarketingController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_Marketing_AdminLogin_Test()
        {
            //Arrange
            MarketingController controller = new MarketingController();

            //Act
            var result = controller.AdminLogin();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_Marketing_AdminRegister_Test()
        {
            //Arrange
            MarketingController controller = new MarketingController();

            //Act
            var result = controller.AdminRegister();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_Newsletter_Index_Test()
        {
            //Arrange
            NewsletterController controller = new NewsletterController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}

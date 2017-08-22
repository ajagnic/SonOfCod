using SonOfCod.Controllers;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;
using System;
using Xunit;
using Microsoft.AspNetCore.Identity;

namespace XUnitTestProject1
{
    public class MarketingControllerTest
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;


        [Fact]
        public void Get_ViewResult_Marketing_Index_Test()
        {
            //Arrange
            MarketingController controller = new MarketingController(userManager, signInManager, db);

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_Marketing_AdminLogin_Test()
        {
            //Arrange
            MarketingController controller = new MarketingController(userManager, signInManager, db);

            //Act
            var result = controller.AdminLogin();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_Marketing_AdminRegister_Test()
        {
            //Arrange
            MarketingController controller = new MarketingController(userManager, signInManager, db);

            //Act
            var result = controller.AdminRegister();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
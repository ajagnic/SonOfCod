using SonOfCod.Models;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class SubscriberModelTest
    {
        [Fact]
        public void ModelTest()
        {
            //Arrange
            var sub = new Subscriber();
            sub.Email = "email@email.com";

            //Act
            var result = sub.Email;

            //Assert
            Assert.Equal("email@email.com", result);
        }
    }
}

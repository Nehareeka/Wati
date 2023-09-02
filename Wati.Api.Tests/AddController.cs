using Microsoft.AspNetCore.Mvc;
using Wati.Api.Controllers;
using Wati.Api.Models;
using Xunit;

namespace Wati.Api.Tests
{
    public class AddControllerTests
    {
        [Fact]
        public void AddTwoNumbers_ReturnsSum()
        {
            //Arrange
            RequestData data = new RequestData { Num1 = 1, Num2 = 2 };

            //Act
            AddController addCtrl = new AddController();
            var result = addCtrl.Add(data) as ActionResult;

            //Assert
            int expected = 3;
            Assert.IsType<OkResult>(result);
            Assert.Equal(expected, result.);
        }

        [Fact]
        public void MissingInput_ReturnsError()
        {
            //Arrange
            RequestData data = new RequestData { Num2 = 2 };

            //Act
            AddController addCtrl = new AddController();
            var result = addCtrl.Add(data) as ActionResult;

            //Assert
            int expected = 3;
            Assert.IsType<OkResult>(result);
            Assert.Equal(expected, result.);
        }
    }
}
using Castle.Core.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using YnovShop.Business;
using YnovShop.Controllers;
using YnovShop.Models;

namespace YnovShop.Tests.Controller
{
    [TestClass]
    public class AccountContollerShould
    {
        private AccountController _controller;
        private Mock<IUserService> _userServiceMock;
        private Mock<ILogger<AccountController>> _logger;

        [TestInitialize]
        public void Init()
        {
            _userServiceMock = new Mock<IUserService>(MockBehavior.Strict);
            _logger = new Mock<ILogger<AccountController>>();

            var httpContext = new DefaultHttpContext();
            var actionContext = new ActionContext(httpContext, new RouteData(), new ActionDescriptor());

            _controller = new AccountController(_logger.Object, _userServiceMock.Object);
            _controller.ModelState.AddModelError("SessionName", "Required");
        }

        [TestMethod]
        public void Register_ReturnBadRequestIsRegisterModelInValid()
        {
            // Arrange
            var model = new RegisterModel { Email = "fdsfsdfds" };

            // Act
            var result = _controller.Register(model) as BadRequestObjectResult;

            // Arrange
            Assert.IsNotNull(result);
        }



         
    }
}

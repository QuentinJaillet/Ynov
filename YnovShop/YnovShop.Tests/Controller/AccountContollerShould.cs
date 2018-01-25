﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Routing;
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

        [TestInitialize]
        public void Init()
        {
            _userServiceMock = new Mock<IUserService>(MockBehavior.Strict);

            var httpContext = new DefaultHttpContext();
            var actionContext = new ActionContext(httpContext, new RouteData(), new ActionDescriptor());

            _controller = new AccountController(_userServiceMock.Object);
            _controller.ModelState.AddModelError("SessionName", "Required");
        }

        [TestMethod]
        public void Register_ReturnBadRequestIsModelInValid()
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

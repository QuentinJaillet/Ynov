using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

            _controller = new AccountController(_userServiceMock.Object);
        }

        [TestMethod]
        public void Register_ReturnBadRequestIsModelInValid()
        {
            // Arrange
            var model = 

            // Act
            var result = _controller.Register(new RegisterModel()) as BadRequestObjectResult;

            // Arrange
            Assert.IsNotNull(result);
        }

         
    }
}

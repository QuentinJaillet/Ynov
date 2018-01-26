using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using YnovShop.Business;
using YnovShop.Data;
using YnovShop.Data.Entities;

namespace YnovShop.Tests.Service
{
    [TestClass]
    public class CatergoryServiceShould
    {
        private CategoryService _catergoryService;
        private Mock<ICategoryRepository> _categoryRepository;

        [TestInitialize]
        public void Init()
        {
            _categoryRepository = new Mock<ICategoryRepository>(MockBehavior.Strict);

            _catergoryService = new CategoryService(_categoryRepository.Object);
        }

        [TestMethod]
        public void Plop()
        {
            // Arrange
            _categoryRepository.Setup(s => s.Get(
                It.IsAny<Expression<Func<YCategory, bool>>>(),
                It.IsAny<Func<IQueryable<YCategory>, IOrderedQueryable<YCategory>>>(), null, null))
                .Returns(new List<YCategory>());

            // Act
            _catergoryService.GetCategories();
        }

    }
}

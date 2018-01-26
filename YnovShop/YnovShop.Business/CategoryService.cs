using System.Collections.Generic;
using System.Linq;
using YnovShop.Business.Models;
using YnovShop.Data;

namespace YnovShop.Business
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<CategoryModel> GetCategories()
        {
            var models = new List<CategoryModel>();
            var categories = _categoryRepository.Get(null, orderBy: o => o.OrderBy(p => p.Name)).ToList();

            foreach (var category in categories)
                models.Add(new CategoryModel { Id = category.Id, Name = category.Name, Description = category.Name, ProductsCount = category.YProduct.Count });

            return models;
        }
    }
}

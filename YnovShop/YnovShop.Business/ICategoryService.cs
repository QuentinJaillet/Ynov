using System.Collections.Generic;
using YnovShop.Business.Models;

namespace YnovShop.Business
{
    public interface ICategoryService
    {
        IEnumerable<CategoryModel> GetCategories();
    }
}

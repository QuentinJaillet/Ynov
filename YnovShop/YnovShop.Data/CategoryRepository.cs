using YnovShop.Data.Entities;

namespace YnovShop.Data
{
    public class CategoryRepository : RepositoryBase<YCategory>, ICategoryRepository
    {
        public CategoryRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}

using YnovShop.Data.Entities;

namespace YnovShop.Data
{
    public class ProductRepository : RepositoryBase<YProduct>, IProductRepository
    {
        public ProductRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}

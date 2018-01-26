using YnovShop.Data.Entities;

namespace YnovShop.Data
{
    public class ManufacturerRepository : RepositoryBase<YManufacturer>, IManufacturerRepository
    {
        public ManufacturerRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}

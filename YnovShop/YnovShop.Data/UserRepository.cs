using YnovShop.Data.Entities;

namespace YnovShop.Data
{
    public class UserRepository : RepositoryBase<YUser>, IUserRepository
    {
        public UserRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}

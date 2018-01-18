using YnovShop.Data.Entities;

namespace YnovShop.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork()
        {
            DbContext = new YnovShopContext();
        }

        public YnovShopContext DbContext { get; }
    }
}

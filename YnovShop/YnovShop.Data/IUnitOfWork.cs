using YnovShop.Data.Entities;

namespace YnovShop.Data
{
    public interface IUnitOfWork
    {
        YnovShopContext DbContext { get; }
    }
}

namespace YnovShop.Business
{
    public interface IUserService
    {
        void CreateUser(string name, string surname, string email, string password);
    }
}

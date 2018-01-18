namespace YnovShop.Provider
{
    public interface IPasswordProvider
    {
        byte[] PasswordHash(string password, byte[] salt);
        bool Validate(string password, byte[] salt, byte[] passwordHash);
    }
}

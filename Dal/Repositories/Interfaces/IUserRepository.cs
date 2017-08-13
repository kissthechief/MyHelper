using Dal.Context;

namespace Dal.Repositories
{
    /// <summary>
    /// Interface for user repository implementation
    /// </summary>
    public interface IUserRepository : IBaseRepository<User>
    {
        bool LogIn(string email, string password);
        User GetUser(string email);
    }
}
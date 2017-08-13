using Dal.Context;

namespace Dal.Repositories.Interfaces
{
    public interface IInventarRepository : IBaseRepository<Inventar>
    {
        /// <summary>
        /// Returns the inventar of a requested user
        /// </summary>
        /// <param name="id">The id of the requested user</param>
        /// <returns>An inventar with every item thats in it</returns>
        Inventar GetUsersInventar(int id);
    }
}
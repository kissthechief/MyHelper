using Dal.Context;
using System;
using System.Linq;

namespace Dal.Repositories
{
    /// <summary>
    /// Repository for all acitvities on user table
    /// </summary>
    public class UserRepository : IUserRepository
    {
        private readonly IHelperContext _context;

        /// <summary>
        /// constructor for injection
        /// </summary>
        /// <param name="context"></param>
        public UserRepository(IHelperContext context)
        {
            _context = context;
        }

        public void Delete(User entity)
        {
            _context.User.Remove(entity);
            _context.SaveChanges();
        }
        
        public User GetById(int id)
        {
            return _context.User.SingleOrDefault(user => user.Id == id);
        }

        public AspNetUsers GetUser(string email)
        {
            return _context.AspNetUsers.SingleOrDefault(user => user.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        public void Insert(User entity)
        {
            _context.User.Add(entity);
            _context.SaveChanges();
        }

        public bool LogIn(string email, string password)
        {
            throw new NotImplementedException();
        }

        User IUserRepository.GetUser(string email)
        {
            throw new NotImplementedException();
        }
    }
}

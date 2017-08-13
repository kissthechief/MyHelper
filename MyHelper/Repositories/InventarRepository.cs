using Dal.Context;
using Dal.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repositories
{
    public class InventarRepository : IInventarRepository
    {
        private readonly IHelperContext _context;

        public InventarRepository(IHelperContext context)
        {
            _context = context;
        }

        public void Delete(Inventar entity)
        {
            throw new NotImplementedException();
        }

        public Inventar GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Inventar GetUsersInventar(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Inventar entity)
        {
            throw new NotImplementedException();
        }
    }
}

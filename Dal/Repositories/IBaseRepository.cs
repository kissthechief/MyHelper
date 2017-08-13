using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repositories
{
    /// <summary>
    /// Base Repository for standard operations
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        void Delete(TEntity entity);
        void Insert(TEntity entity);
    }
}

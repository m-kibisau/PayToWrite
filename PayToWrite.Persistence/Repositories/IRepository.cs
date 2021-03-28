using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PayToWrite.Persistence
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        Task CreateAsync(TEntity entity);
        IEnumerable<TEntity> GetAll();
        Task<IEnumerable<TEntity>> GetAllAsync();
        IEnumerable<TEntity> Get(Func<TEntity, bool> predicate);
        bool Delete(TEntity item);
        Task<bool> DeleteAsync(TEntity item);
        void Update(TEntity entity);
        Task UpdateAsync(TEntity entity);
    }
}

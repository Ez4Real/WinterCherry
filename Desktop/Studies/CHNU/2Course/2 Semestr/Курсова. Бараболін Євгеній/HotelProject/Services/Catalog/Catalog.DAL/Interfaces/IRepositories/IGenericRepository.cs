using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.DAL.Interfaces.IEntities;

namespace Catalog.DAL.Interfaces.IRepositories
{
   public interface IGenericRepository<TEntity> where TEntity : IEntity
    {
        public Task<IEnumerable<TEntity>> GetAllAsync();
        public Task<TEntity> GetByIdAsync(int Id);
        public Task<TEntity> AddAsync(TEntity entity);
        public Task<TEntity> UpdateAsync(TEntity entity);
        public Task<TEntity> DeleteAsync(int Id);
        public void SaveChangesAsync();
    }
}

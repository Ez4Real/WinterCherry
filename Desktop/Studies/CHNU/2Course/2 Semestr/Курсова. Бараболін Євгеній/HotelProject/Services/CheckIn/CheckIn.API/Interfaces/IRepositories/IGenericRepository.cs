using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booking.API.Interfaces.IEntities;

namespace Booking.API.Interfaces.IRepositories
{
   public interface IGenericRepository<TEntity> where TEntity : IEntity
    {
        public Task<IEnumerable<TEntity>> GetAllAsync();
        public Task<TEntity> GetByIdAsync(int Id);
        public Task<bool> AddAsync(TEntity entity);
        public Task<bool> UpdateAsync(TEntity entity);
        public Task<bool> DeleteAsync(int Id);
    }
}

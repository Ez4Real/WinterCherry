using Booking.API.Interfaces.IEntities;
using Booking.API.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.API.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : IEntity
    {
    }
}

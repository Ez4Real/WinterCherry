using Comments.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comments.API.Interfaces.IRepositories
{
    public interface ICommentsRepository : IGenericRepository<Entities.Comments>
    {
    }
}

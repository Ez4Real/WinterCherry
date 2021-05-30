using Response.API.EfDBContext;
using Response.API.Entities;
using Response.API.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Response.API.Repositories
{
    public class CommentsRepository : GenericRepository<Comments>, ICommentsRepository
    {
        public CommentsRepository(ResponseDBContext context) : base(context)
        {
        }
    }
}

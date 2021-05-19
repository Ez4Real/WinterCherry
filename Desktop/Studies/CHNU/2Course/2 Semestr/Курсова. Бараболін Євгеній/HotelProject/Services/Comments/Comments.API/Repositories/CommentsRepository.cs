using Comments.API.EfDBContext;
using Comments.API.Entities;
using Comments.API.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comments.API.Repositories
{
    public class CommentsRepository : GenericRepository<Entities.Comments>, ICommentsRepository
    {
        public CommentsRepository(CommentsDBContext context) : base(context)
        {
        }
    }
}

using Comments.API.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comments.API.Interfaces
{
    public interface IUnitOfWork
    {
        public ICommentsRepository CommentsRepository { get; }
        
    }
}

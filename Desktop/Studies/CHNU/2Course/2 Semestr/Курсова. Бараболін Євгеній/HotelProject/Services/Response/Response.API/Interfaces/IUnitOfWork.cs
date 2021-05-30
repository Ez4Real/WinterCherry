using Response.API.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Response.API.Interfaces.Interfaces
{
    public interface IUnitOfWork
    {
        public IClientsRepository ClientsRepository { get; }
        public ICommentsRepository CommentsRepository { get; }
        
    }
}

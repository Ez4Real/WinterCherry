using Clients.API.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clients.API.Interfaces.Interfaces
{
    public interface IUnitOfWork
    {
        public IClientsRepository ClientsRepository { get; }
        
    }
}

using Clients.API.Interfaces.Interfaces;
using Clients.API.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clients.API.UnitOfWorks
{
        public class UnitOfWork : IUnitOfWork
        {
            private readonly IClientsRepository _ClientsRepository;

        public UnitOfWork(IClientsRepository ClientsRepository)
            {
                _ClientsRepository = ClientsRepository;
            }
            public IClientsRepository ClientsRepository { get { return _ClientsRepository; } }
    }
    

}

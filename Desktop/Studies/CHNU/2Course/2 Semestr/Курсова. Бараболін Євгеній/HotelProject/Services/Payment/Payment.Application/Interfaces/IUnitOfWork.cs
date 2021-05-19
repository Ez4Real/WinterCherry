using Payment.Application.Interfaces.IRepositories;
using Payment.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.Application.Interfaces
{
    public interface IUnitOfWork
    {
        public IClientsRepository ClientsRepository { get; }      
    }
}

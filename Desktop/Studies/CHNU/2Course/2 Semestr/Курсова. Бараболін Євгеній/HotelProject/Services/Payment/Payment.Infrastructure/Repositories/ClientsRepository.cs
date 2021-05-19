using Payment.Application.Interfaces.IRepositories;
using Payment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Payment.Infrastructure.DBContext;

namespace Payment.Infrastructure.Repositories
{
    public class ClientsRepository : GenericRepository<Clients>, IClientsRepository
    {
        public ClientsRepository(PaymentDBContext context) : base(context)
        {
        }
    }
}

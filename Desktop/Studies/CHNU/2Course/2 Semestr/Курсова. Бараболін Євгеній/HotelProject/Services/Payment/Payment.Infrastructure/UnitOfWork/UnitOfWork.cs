using Payment.Application.Interfaces;
using Payment.Application.Interfaces.IRepositories;

namespace Payment.Infrastructure.UnitOfWorks
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

using Response.API.Interfaces.Interfaces;
using Response.API.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Response.API.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IClientsRepository _ClientsRepository;
        private readonly ICommentsRepository _CommentsRepository;

        public UnitOfWork(IClientsRepository ClientsRepository, ICommentsRepository CommentsRepository)
        {
            _ClientsRepository = ClientsRepository;
            _CommentsRepository = CommentsRepository;
        }
        public IClientsRepository ClientsRepository { get { return _ClientsRepository; } }
        public ICommentsRepository CommentsRepository { get { return _CommentsRepository; } }
    }


}

using Comments.API.Interfaces;
using Comments.API.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comments.API.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ICommentsRepository _CommentsRepository;

        public UnitOfWork(ICommentsRepository CommentsRepository)
        {
            _CommentsRepository = CommentsRepository;
        }
        public ICommentsRepository CommentsRepository { get { return _CommentsRepository; } }
    }


}

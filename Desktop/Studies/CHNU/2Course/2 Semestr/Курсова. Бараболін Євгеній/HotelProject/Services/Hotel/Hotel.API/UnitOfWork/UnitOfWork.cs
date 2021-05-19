using Hotel.API.Interfaces.Interfaces;
using Hotel.API.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.API.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ICheckInRepository _CheckInRepository;
        private readonly IClientsRepository _ClientsRepository;
        private readonly ICommentsRepository _CommentsRepository;
        private readonly IRoomsRepository _RoomsRepository;
        private readonly IRoomImagesRepository _RoomImagesRepository;

        public UnitOfWork(ICheckInRepository CheckInRepository, IClientsRepository ClientsRepository, ICommentsRepository CommentsRepository, IRoomsRepository RoomsRepository, IRoomImagesRepository RoomImagesRepository)
        {
            _CheckInRepository = CheckInRepository;
            _ClientsRepository = ClientsRepository;
            _CommentsRepository = CommentsRepository;
            _RoomsRepository = RoomsRepository;
            _RoomImagesRepository = RoomImagesRepository;
        }
        public ICheckInRepository CheckInRepository { get { return _CheckInRepository; } }
        public IClientsRepository ClientsRepository { get { return _ClientsRepository; } }
        public ICommentsRepository CommentsRepository { get { return _CommentsRepository; } }
        public IRoomsRepository RoomsRepository { get { return _RoomsRepository; } }
        public IRoomImagesRepository RoomImagesRepository { get { return _RoomImagesRepository; } }
    }


}

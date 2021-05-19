using Hotel.API.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.API.Interfaces.Interfaces
{
    public interface IUnitOfWork
    {
        public ICheckInRepository CheckInRepository { get; }
        public IClientsRepository ClientsRepository { get; }
        public ICommentsRepository CommentsRepository { get; }
        public IRoomsRepository RoomsRepository { get; }
        public IRoomImagesRepository RoomImagesRepository { get; }
        
    }
}

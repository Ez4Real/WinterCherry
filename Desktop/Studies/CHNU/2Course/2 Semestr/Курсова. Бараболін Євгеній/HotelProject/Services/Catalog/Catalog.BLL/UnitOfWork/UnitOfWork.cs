using Catalog.BLL.Interfaces;
using Catalog.DAL.Interfaces.Interfaces;
using Catalog.DAL.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.BLL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IRoomsRepository _RoomsRepository;
        private readonly IRoomImagesRepository _RoomImagesRepository;

        public UnitOfWork (IRoomsRepository RoomsRepository, IRoomImagesRepository RoomImagesRepository)
        {
            _RoomsRepository = RoomsRepository;
            _RoomImagesRepository = RoomImagesRepository;
        }
        public IRoomsRepository RoomsRepository { get { return _RoomsRepository; } }
        public IRoomImagesRepository RoomImagesRepository { get { return _RoomImagesRepository; } }
    }
}

using Catalog.DAL.Interfaces.Interfaces;
using Catalog.DAL.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.BLL.Interfaces
{
    public interface IUnitOfWork
    {    
        public IRoomsRepository RoomsRepository { get; }
        public IRoomImagesRepository RoomImagesRepository { get; }

    }
}

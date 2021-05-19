using Catalog.DAL.Interfaces.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.DAL.Entities
{
    public class RoomImages : IEntity
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public string ImgPath { get; set; }
    }
}

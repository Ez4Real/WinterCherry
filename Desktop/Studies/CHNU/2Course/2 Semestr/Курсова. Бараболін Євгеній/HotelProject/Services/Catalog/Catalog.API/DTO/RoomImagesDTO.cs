using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.DTO
{
    public class RoomImagesDTO
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public string ImgPath { get; set; }
    }
}

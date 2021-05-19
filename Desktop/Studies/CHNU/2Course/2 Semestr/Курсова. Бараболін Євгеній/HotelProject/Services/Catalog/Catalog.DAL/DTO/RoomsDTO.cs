using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.DAL.DTO
{
    public class RoomsDTO
    {
        public int Id { get; set; }
        public int RoomNum { get; set; }
        public int PeopleNum { get; set; }
        public string RoomType { get; set; }
        public string RoomIMG { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }
    }
}

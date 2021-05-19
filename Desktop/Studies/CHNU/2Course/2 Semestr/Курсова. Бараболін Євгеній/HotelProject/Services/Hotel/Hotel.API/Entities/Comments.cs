using Hotel.API.Interfaces.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.API.Entities
{
    public class Comments : IEntity
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int ClientID { get; set; }
        public DateTime CreateDate { get; set; }    
    }
}

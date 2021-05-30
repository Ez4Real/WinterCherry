using Response.API.Interfaces.IEntities;
using System;

namespace Response.API.Entities
{
    public class Comments : IEntity
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int ClientID { get; set; }
        public DateTime CreateDate { get; set; }    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Response.API.Models
{
    public class Responses
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Comment { get; set; }
        public int ClientID { get; set; }
        public DateTime CreateDate { get; set; }
    }
}

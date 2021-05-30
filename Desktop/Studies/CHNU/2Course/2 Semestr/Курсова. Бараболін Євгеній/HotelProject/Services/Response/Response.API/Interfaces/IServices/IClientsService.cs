using Response.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Response.API.Interfaces.IServices
{
    public interface IClientsService
    {
        public Task<IEnumerable<Clients>> GetAllClientsAysnc();

        public Task<Clients> GetClientsByIdAysnc(int Id);

        public Task<Clients> AddClientsAysnc(Clients clients);

        public Task<Clients> UpdateClientsAysnc(Clients clients);

        public Task<Clients> DeleteClientsAysnc(int Id);
    }
}

using Clients.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clients.API.Interfaces.IServices
{
    public interface IClientsService
    {
        public Task<IEnumerable<Entities.Clients>> GetAllClientsAysnc();

        public Task<Entities.Clients> GetClientsByIdAysnc(int Id);

        public Task<Entities.Clients> AddClientsAysnc(Entities.Clients clients);

        public Task<Entities.Clients> UpdateClientsAysnc(Entities.Clients clients);

        public Task<Entities.Clients> DeleteClientsAysnc(int Id);
    }
}

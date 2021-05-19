using Clients.API.Entities;
using Clients.API.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clients.API.Controllers
{
    public class ClientsController : ControllerBase
    {
        private IClientsService _clientsService { get; }
        public ClientsController(IClientsService clientsService)
        {
            _clientsService = clientsService;
        }

        #region ClientsAPI
        [Route("/Clients")]
        [HttpGet]
        public async Task<IEnumerable<Entities.Clients>> GetAllClients()
        {
            return await _clientsService.GetAllClientsAysnc();
        }

        [Route("/Clients/{id}")]
        [HttpGet]
        public async Task<Entities.Clients> GetClientsByIdAsync(int id)
        {
            return await _clientsService.GetClientsByIdAysnc(id);
        }

        [Route("/Clients")]
        [HttpPost]
        public async Task<Entities.Clients> AddClientsAsync([FromBody] Entities.Clients clients)
        {
            return await _clientsService.AddClientsAysnc(clients);
        }

        [Route("/Clients")]
        [HttpPut]
        public async Task<Entities.Clients> UpdateClientsAsync([FromBody] Entities.Clients clients)
        {
            return await _clientsService.UpdateClientsAysnc(clients);
        }

        [Route("/Clients/{id}")]
        [HttpDelete]
        public async Task<Entities.Clients> DeleteClientsAsync(int id)
        {
            return await _clientsService.DeleteClientsAysnc(id);
        }
        #endregion
    }
}

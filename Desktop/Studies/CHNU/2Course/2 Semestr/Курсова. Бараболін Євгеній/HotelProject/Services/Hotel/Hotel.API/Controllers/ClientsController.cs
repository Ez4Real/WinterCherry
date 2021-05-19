using Hotel.API.Entities;
using Hotel.API.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.API.Controllers
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
        public async Task<IEnumerable<Clients>> GetAllClients()
        {
            return await _clientsService.GetAllClientsAysnc();
        }

        [Route("/Clients/{id}")]
        [HttpGet]
        public async Task<Clients> GetClientsByIdAsync(int id)
        {
            return await _clientsService.GetClientsByIdAysnc(id);
        }

        [Route("/Clients")]
        [HttpPost]
        public async Task<Clients> AddClientsAsync([FromBody] Clients clients)
        {
            return await _clientsService.AddClientsAysnc(clients);
        }

        [Route("/Clients")]
        [HttpPut]
        public async Task<Clients> UpdateClientsAsync([FromBody] Clients clients)
        {
            return await _clientsService.UpdateClientsAysnc(clients);
        }

        [Route("/Clients/{id}")]
        [HttpDelete]
        public async Task<Clients> DeleteClientsAsync(int id)
        {
            return await _clientsService.DeleteClientsAysnc(id);
        }
        #endregion
    }
}

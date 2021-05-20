using AutoMapper;
using Clients.API.DTO;
using Clients.API.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clients.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientsController
    {
        private readonly IClientsService _clientsService;
        private readonly IMapper _mapper;
        public ClientsController(
            IClientsService clientsService,
            IMapper mapper)
        {
            _clientsService = clientsService;
            _mapper = mapper;
        }


        #region ClientsAPIs
        // GET: /Clients Get all Clients
        [HttpGet]
        public async Task<IEnumerable<ClientsDTO>> GetAllClientsAsync()
        {
            var clients = await _clientsService.GetAllClientsAysnc();
            var clientsDTO = _mapper.Map<IEnumerable<ClientsDTO>>(clients);
            return clientsDTO;

        }

        // GET: /Clients/{Id} Get Clients by id
        [HttpGet("{Id}")]
        public async Task<Entities.Clients> GetClientsByIdAsync(int Id)
        {
            return await _clientsService.GetClientsByIdAysnc(Id);
        }

        // POST: /Clients Add new Clients
        [HttpPost]
        public async Task<Entities.Clients> AddClientsAsync([FromBody] Entities.Clients clients)
        {
            return await _clientsService.AddClientsAysnc(clients);
        }

        // PUT: /Clients Update existing Clients
        [HttpPut]
        public async Task<Entities.Clients> UpdateClientsAsync([FromBody] Entities.Clients clients)
        {
            return await _clientsService.UpdateClientsAysnc(clients);
        }

        // DELETE: /Clients/{Id} Delete existing Clients
        [HttpDelete("{id}")]
        public async Task<Entities.Clients> DeleteClientsAsync(int id)
        {
            return await _clientsService.DeleteClientsAysnc(id);
        }
        #endregion
    }
}

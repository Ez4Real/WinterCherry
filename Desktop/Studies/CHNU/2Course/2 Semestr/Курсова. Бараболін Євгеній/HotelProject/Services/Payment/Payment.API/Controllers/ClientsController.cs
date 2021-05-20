using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Payment.Application.DTO;
using Payment.Application.Interfaces.IServices;
using Payment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.API.Controllers
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
        public async Task<Clients> GetClientsByIdAsync(int Id)
        {
            return await _clientsService.GetClientsByIdAysnc(Id);
        }

        // POST: /Clients Add new Clients
        [HttpPost]
        public async Task<Clients> AddClientsAsync([FromBody] Clients clients)
        {
            return await _clientsService.AddClientsAysnc(clients);
        }

        // PUT: /Clients Update existing Clients
        [HttpPut]
        public async Task<Clients> UpdateClientsAsync([FromBody] Clients clients)
        {
            return await _clientsService.UpdateClientsAysnc(clients);
        }

        // DELETE: /Clients/{Id} Delete existing Clients
        [HttpDelete("{id}")]
        public async Task<Clients> DeleteClientsAsync(int id)
        {
            return await _clientsService.DeleteClientsAysnc(id);
        }
        #endregion
    }
}

using Clients.API.Entities;
using Clients.API.Interfaces.Interfaces;
using Clients.API.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clients.API.Services
{

    public class ClientsService : IClientsService
    {
        private IUnitOfWork _unitOfWork { get; set; }

        public ClientsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Entities.Clients>> GetAllClientsAysnc()
        {
            return await _unitOfWork.ClientsRepository.GetAllAsync();
        }

        public async Task<Entities.Clients> GetClientsByIdAysnc(int Id)
        {
            return await _unitOfWork.ClientsRepository.GetByIdAsync(Id);
        }

        public async Task<Entities.Clients> AddClientsAysnc(Entities.Clients clients)
        {
            var res = await _unitOfWork.ClientsRepository.AddAsync(clients);
            //_unitOfWork.ClientsRepo.SaveChangesAsync();
            return res;
        }

        public async Task<Entities.Clients> UpdateClientsAysnc(Entities.Clients clients)
        {
            var res = await _unitOfWork.ClientsRepository.UpdateAsync(clients);
            //_unitOfWork.ClientsRepo.SaveChangesAsync();
            return res;
        }

        public async Task<Entities.Clients> DeleteClientsAysnc(int Id)
        {
            var res = await _unitOfWork.ClientsRepository.DeleteAsync(Id);
            //_unitOfWork.ClientsRepo.SaveChangesAsync();
            return res;
        }
    }
}

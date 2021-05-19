using Hotel.API.Entities;
using Hotel.API.Interfaces.Interfaces;
using Hotel.API.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.API.Services
{

    public class ClientsService : IClientsService
    {
        private IUnitOfWork _unitOfWork { get; set; }

        public ClientsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Clients>> GetAllClientsAysnc()
        {
            return await _unitOfWork.ClientsRepository.GetAllAsync();
        }

        public async Task<Clients> GetClientsByIdAysnc(int Id)
        {
            return await _unitOfWork.ClientsRepository.GetByIdAsync(Id);
        }

        public async Task<Clients> AddClientsAysnc(Clients clients)
        {
            var res = await _unitOfWork.ClientsRepository.AddAsync(clients);
            //_unitOfWork.ClientsRepo.SaveChangesAsync();
            return res;
        }

        public async Task<Clients> UpdateClientsAysnc(Clients clients)
        {
            var res = await _unitOfWork.ClientsRepository.UpdateAsync(clients);
            //_unitOfWork.ClientsRepo.SaveChangesAsync();
            return res;
        }

        public async Task<Clients> DeleteClientsAysnc(int Id)
        {
            var res = await _unitOfWork.ClientsRepository.DeleteAsync(Id);
            //_unitOfWork.ClientsRepo.SaveChangesAsync();
            return res;
        }
    }
}

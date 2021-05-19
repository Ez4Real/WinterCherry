using Hotel.API.Entities;
using Hotel.API.Interfaces.Interfaces;
using Hotel.API.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.API.Services
{
    public class CommentsService : ICommentsService
    {
        private IUnitOfWork _unitOfWork { get; set; }

        public CommentsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Comments>> GetAllCommentsAysnc()
        {
            return await _unitOfWork.CommentsRepository.GetAllAsync();
        }

        public async Task<Comments> GetCommentsByIdAysnc(int Id)
        {
            return await _unitOfWork.CommentsRepository.GetByIdAsync(Id);
        }

        public async Task<Comments> AddCommentsAysnc(Comments comments)
        {
            var res = await _unitOfWork.CommentsRepository.AddAsync(comments);
            //_unitOfWork.CommentsRepo.SaveChangesAsync();
            return res;
        }

        public async Task<Comments> UpdateCommentsAysnc(Comments comments)
        {
            var res = await _unitOfWork.CommentsRepository.UpdateAsync(comments);
            //_unitOfWork.CommentsRepo.SaveChangesAsync();
            return res;
        }

        public async Task<Comments> DeleteCommentsAysnc(int Id)
        {
            var res = await _unitOfWork.CommentsRepository.DeleteAsync(Id);
            //_unitOfWork.CommentsRepo.SaveChangesAsync();
            return res;
        }
    }
}

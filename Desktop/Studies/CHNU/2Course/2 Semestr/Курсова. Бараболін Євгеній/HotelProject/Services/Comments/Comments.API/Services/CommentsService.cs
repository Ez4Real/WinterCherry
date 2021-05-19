using Comments.API.Entities;
using Comments.API.Interfaces;
using Comments.API.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comments.API.Services
{
    public class CommentsService : ICommentsService
    {
        private IUnitOfWork _unitOfWork { get; set; }

        public CommentsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Entities.Comments>> GetAllCommentsAysnc()
        {
            return await _unitOfWork.CommentsRepository.GetAllAsync();
        }

        public async Task<Entities.Comments> GetCommentsByIdAysnc(int Id)
        {
            return await _unitOfWork.CommentsRepository.GetByIdAsync(Id);
        }

        public async Task<Entities.Comments> AddCommentsAysnc(Entities.Comments comments)
        {
            var res = await _unitOfWork.CommentsRepository.AddAsync(comments);
            //_unitOfWork.CommentsRepo.SaveChangesAsync();
            return res;
        }

        public async Task<Entities.Comments> UpdateCommentsAysnc(Entities.Comments comments)
        {
            var res = await _unitOfWork.CommentsRepository.UpdateAsync(comments);
            //_unitOfWork.CommentsRepo.SaveChangesAsync();
            return res;
        }

        public async Task<Entities.Comments> DeleteCommentsAysnc(int Id)
        {
            var res = await _unitOfWork.CommentsRepository.DeleteAsync(Id);
            //_unitOfWork.CommentsRepo.SaveChangesAsync();
            return res;
        }
    }
}

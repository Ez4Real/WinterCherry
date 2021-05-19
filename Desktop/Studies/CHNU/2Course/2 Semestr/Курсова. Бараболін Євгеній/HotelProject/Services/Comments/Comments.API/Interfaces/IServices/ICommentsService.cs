using Comments.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comments.API.Interfaces.IServices
{
    public interface ICommentsService
    {
        public Task<IEnumerable<Entities.Comments>> GetAllCommentsAysnc();

        public Task<Entities.Comments> GetCommentsByIdAysnc(int Id);

        public Task<Entities.Comments> AddCommentsAysnc(Entities.Comments comments);

        public Task<Entities.Comments> UpdateCommentsAysnc(Entities.Comments comments);

        public Task<Entities.Comments> DeleteCommentsAysnc(int Id);
    }
}

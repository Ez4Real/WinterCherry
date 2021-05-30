using Response.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Response.API.Interfaces.IServices
{
    public interface ICommentsService
    {
        public Task<IEnumerable<Comments>> GetAllCommentsAysnc();

        public Task<Comments> GetCommentsByIdAysnc(int Id);

        public Task<Comments> AddCommentsAysnc(Comments comments);

        public Task<Comments> UpdateCommentsAysnc(Comments comments);

        public Task<Comments> DeleteCommentsAysnc(int Id);
    }
}

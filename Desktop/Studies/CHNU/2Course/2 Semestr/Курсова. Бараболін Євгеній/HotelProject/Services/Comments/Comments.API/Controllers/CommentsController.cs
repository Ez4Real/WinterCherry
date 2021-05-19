using Comments.API.Entities;
using Comments.API.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comments.API.Controllers
{
    public class CommentsController : ControllerBase
    {
        private ICommentsService _commentsService { get; }
        public CommentsController(ICommentsService commentsService)
        {
            _commentsService = commentsService;
        }

        [Route("/Comments")]
        [HttpGet]
        public async Task<IEnumerable<Entities.Comments>> GetAllComments()
        {
            return await _commentsService.GetAllCommentsAysnc();
        }

        [Route("/Comments/{id}")]
        [HttpGet]
        public async Task<Entities.Comments> GetCommentsByIdAsync(int id)
        {
            return await _commentsService.GetCommentsByIdAysnc(id);
        }

        [Route("/Comments")]
        [HttpPost]
        public async Task<Entities.Comments> AddCommentsAsync([FromBody] Entities.Comments comments)
        {
            return await _commentsService.AddCommentsAysnc(comments);
        }

        [Route("/Comments")]
        [HttpPut]
        public async Task<Entities.Comments> UpdateCommentsAsync([FromBody] Entities.Comments comments)
        {
            return await _commentsService.UpdateCommentsAysnc(comments);
        }

        [Route("/Comments/{id}")]
        [HttpDelete]
        public async Task<Entities.Comments> DeleteCommentsAsync(int id)
        {
            return await _commentsService.DeleteCommentsAysnc(id);
        }

    }
}


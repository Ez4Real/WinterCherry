using Hotel.API.Entities;
using Hotel.API.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.API.Controllers
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
        public async Task<IEnumerable<Comments>> GetAllComments()
        {
            return await _commentsService.GetAllCommentsAysnc();
        }

        [Route("/Comments/{id}")]
        [HttpGet]
        public async Task<Comments> GetCommentsByIdAsync(int id)
        {
            return await _commentsService.GetCommentsByIdAysnc(id);
        }

        [Route("/Comments")]
        [HttpPost]
        public async Task<Comments> AddCommentsAsync([FromBody] Comments comments)
        {
            return await _commentsService.AddCommentsAysnc(comments);
        }

        [Route("/Comments")]
        [HttpPut]
        public async Task<Comments> UpdateCommentsAsync([FromBody] Comments comments)
        {
            return await _commentsService.UpdateCommentsAysnc(comments);
        }

        [Route("/Comments/{id}")]
        [HttpDelete]
        public async Task<Comments> DeleteCommentsAsync(int id)
        {
            return await _commentsService.DeleteCommentsAysnc(id);
        }

    }
}


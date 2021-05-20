using AutoMapper;
using Comments.API.DTO;
using Comments.API.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Comments.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CommentsController
    {
        private readonly ICommentsService _commentsService;
        private readonly IMapper _mapper;
        public CommentsController(
            ICommentsService commentsService,
            IMapper mapper)
        {
            _commentsService = commentsService;
            _mapper = mapper;
        }


        #region CommentsAPIs
        // GET: /Comments Get all Comments
        [HttpGet]
        public async Task<IEnumerable<CommentsDTO>> GetAllCommentsAsync()
        {
            var comments = await _commentsService.GetAllCommentsAysnc();
            var commentsDTO = _mapper.Map<IEnumerable<CommentsDTO>>(comments);
            return commentsDTO;

        }

        // GET: /Comments/{Id} Get Comments by id
        [HttpGet("{Id}")]
        public async Task<Entities.Comments> GetCommentsByIdAsync(int Id)
        {
            return await _commentsService.GetCommentsByIdAysnc(Id);
        }

        // POST: /Comments Add new Comments
        [HttpPost]
        public async Task<Entities.Comments> AddCommentsAsync([FromBody] Entities.Comments comments)
        {
            return await _commentsService.AddCommentsAysnc(comments);
        }

        // PUT: /Comments Update existing Comments
        [HttpPut]
        public async Task<Entities.Comments> UpdateCommentsAsync([FromBody] Entities.Comments comments)
        {
            return await _commentsService.UpdateCommentsAysnc(comments);
        }

        // DELETE: /Comments/{Id} Delete existing Comments
        [HttpDelete("{id}")]
        public async Task<Entities.Comments> DeleteCommentsAsync(int id)
        {
            return await _commentsService.DeleteCommentsAysnc(id);
        }
        #endregion
    }
}



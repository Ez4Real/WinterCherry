using Response.API.Entities;
using Response.API.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Response.API.Models;

namespace Response.API.Controllers
{
    public class ResponseController : ControllerBase
    {
        private IClientsService _clientsService { get; }
        private ICommentsService _commentsService { get; }
        public ResponseController(IClientsService clientsService, ICommentsService commentsService)
        {
            _clientsService = clientsService;
            _commentsService = commentsService;
        }

        #region ClientsAPI
        [Route("/Response")]
        [HttpGet]
        public async Task<IEnumerable<Responses>> GetAllResponses()
        {
            var clients = await _clientsService.GetAllClientsAysnc();
            var comments = await _commentsService.GetAllCommentsAysnc();

            var responses = new List<Responses>();

            foreach (var comment in comments)
            {
                var client = clients.Single<Clients>(clients => clients.Id == comment.ClientID);

                responses.Add(new Responses() { 
                Id = comment.Id,
                ClientID = client.Id,
                Comment = comment.Comment,
                CreateDate = comment.CreateDate,
                FirstName = client.FirstName,
                MiddleName = client.MiddleName
                });

            }

            return responses;
                
        }

        [Route("/Response/{id}")]
        [HttpGet]
        public async Task<Responses> GetResponsesByIdAsync(int id)
        {
           
            var comment = await _commentsService.GetCommentsByIdAysnc(id);

            if (comment == null)
                return new Responses();

            var client = await _clientsService.GetClientsByIdAysnc(comment.ClientID);

            

            return new Responses()
            {
                Id = comment.Id,
                ClientID = client.Id,
                Comment = comment.Comment,
                CreateDate = comment.CreateDate,
                FirstName = client.FirstName,
                MiddleName = client.MiddleName
            };

        }

        //[Route("/Response")]
        //[HttpPost]
        //public async Task<Responses> AddClientsAsync([FromBody] Responses responses)
        //{
        //    return await _clientsService.AddClientsAysnc(responses);
        //}

        //[Route("/Response")]
        //[HttpPut]
        //public async Task<Responses> UpdateClientsAsync([FromBody] Responses responses)
        //{
        //    return await _clientsService.UpdateClientsAysnc(responses);
        //}

        //[Route("/Response/{id}")]
        //[HttpDelete]
        //public async Task<Responses> DeleteClientsAsync(int id)
        //{
        //    return await _clientsService.DeleteClientsAysnc(id);
        //}
        #endregion
    }
}


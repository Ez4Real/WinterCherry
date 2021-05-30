using Clients.API.DTO;
using Clients.API.Interfaces.Interfaces;
using Clients.API.Interfaces.IRepositories;
using Clients.API.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Clients.Tests
{
    public class ClientsServiceTests
    {
        private readonly ClientsService _clientsServiceMock;
        private readonly Mock<IUnitOfWork> _unitOfWorkMock = new Mock<IUnitOfWork>();


        public ClientsServiceTests()
        {
            _clientsServiceMock = new ClientsService(_unitOfWorkMock.Object);
        }

        public object clients { get; private set; }

        [Fact]
        public async Task GetClientsByIdAysnc_ShouldReturnClients()
        {
            //Arrange
            int clientsId = 1;
            var clientsName = "Ivan";
            var clients = new API.Entities.Clients
            {
                Id = clientsId,
                FirstName = clientsName
            };

            _unitOfWorkMock.Setup(x => x.ClientsRepository.GetByIdAsync(clientsId))
                .ReturnsAsync(() => clients);
            //Act
            var client = await _clientsServiceMock.GetClientsByIdAysnc(clientsId);

            //Assert
            Assert.Equal(client, clients);
        }

        [Fact]
        public async Task GetAllClientsAysnc_ShouldReturnClients()
        {
            //Arrange
            var clientsList = new List<API.Entities.Clients>()
            {
                new API.Entities.Clients() {Id = 1, FirstName = "Pablo", LastName = "Escobar", MiddleName = "Pablito", IdentificationID = 1, CheckInAmount = 100 , DiscountAmount = 100 },
                new API.Entities.Clients() {Id = 2, FirstName = "Diane", LastName = "Ngujen", MiddleName = "Michaels", IdentificationID = 2, CheckInAmount = 0 , DiscountAmount = 0 },
                new API.Entities.Clients() {Id = 3, FirstName = "Bojack", LastName = "Horseman", MiddleName = "Mello", IdentificationID = 3, CheckInAmount = 5 , DiscountAmount = 10 }
            };
            int clientsId = 1;
            var clientsName = "Ivan";
            var clients = new API.Entities.Clients
            {
                Id = clientsId,
                FirstName = clientsName
            };

            _unitOfWorkMock.Setup(x => x.ClientsRepository.GetAllAsync())
                .ReturnsAsync(() => clientsList);
            //Act
            var client = await _clientsServiceMock.GetAllClientsAysnc();

            //Assert
            Assert.Equal(clientsList, client);
        }

        [Fact]
        public async Task AddClientsAsync_ShouldReturnClients_WhenClientsAdded()
        {
            //Arrange
            var clients = new API.Entities.Clients() { Id = 2, FirstName = "Diane", LastName = "Ngujen", MiddleName = "Michaels", IdentificationID = 2, CheckInAmount = 0, DiscountAmount = 0 };
            _unitOfWorkMock.Setup(x => x.ClientsRepository.AddAsync(clients))
                .ReturnsAsync(() => clients);
            //Act
            var clientRes = await _clientsServiceMock.AddClientsAysnc(clients);
            //Assert
            Assert.Equal(clients, clientRes);
        }

        [Fact]
        public async Task UpdateClientsAsync_ShouldReturnClients_WhenClientsUpdated()
        {
            //Arrange
            var clients = new API.Entities.Clients() { Id = 2, FirstName = "Diane", LastName = "Ngujen", MiddleName = "Michaels", IdentificationID = 2, CheckInAmount = 0, DiscountAmount = 0 };
            _unitOfWorkMock.Setup(x => x.ClientsRepository.UpdateAsync(clients))
                .ReturnsAsync(() => clients);
            //Act
            var cartItemRes = await _clientsServiceMock.UpdateClientsAysnc(clients);
            //Assert
            Assert.Equal(clients, cartItemRes);
        }

        [Fact]
        public async Task DeleteCartItemAsync_ShouldReturnTrue_WhenCartItemsDeleted()
        {
            //Arrange
            int id = 2;
            var clients = new API.Entities.Clients() { Id = 2, FirstName = "Diane", LastName = "Ngujen", MiddleName = "Michaels", IdentificationID = 2, CheckInAmount = 0, DiscountAmount = 0 };
            _unitOfWorkMock.Setup(x => x.ClientsRepository.DeleteAsync(id))
                .ReturnsAsync(() => clients);
            //Act
            var cartItemRes = await _clientsServiceMock.DeleteClientsAysnc(id);
            //Assert
            Assert.Equal(clients, cartItemRes);
        }

    }

}



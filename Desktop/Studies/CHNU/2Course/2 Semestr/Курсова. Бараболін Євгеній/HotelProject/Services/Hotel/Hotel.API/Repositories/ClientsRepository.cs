﻿using Hotel.API.EfDBContext;
using Hotel.API.Entities;
using Hotel.API.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.API.Repositories
{
    public class ClientsRepository : GenericRepository<Clients>, IClientsRepository
    {
        public ClientsRepository(HotelDbContext context) : base(context)
        {
        }
    }
}

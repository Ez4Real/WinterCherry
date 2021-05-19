using Hotel.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.API.Interfaces.IServices
{
    public interface ICheckInService
    {
        public Task<IEnumerable<CheckIn>> GetAllCheckInAysnc();

        public Task<CheckIn> GetCheckInByIdAysnc(int Id);

        public Task<CheckIn> AddCheckInAysnc(CheckIn checkin);

        public Task<CheckIn> UpdateCheckInAysnc(CheckIn checkin);

        public Task<CheckIn> DeleteCheckInAysnc(int Id);
    }
}

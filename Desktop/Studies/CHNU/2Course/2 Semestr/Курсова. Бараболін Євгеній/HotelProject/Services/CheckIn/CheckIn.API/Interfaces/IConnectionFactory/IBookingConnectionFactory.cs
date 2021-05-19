using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.API.Interfaces.IConnectionFactory
{
    public interface IBookingConnectionFactory
    {
        public IDbConnection GetSqlConnection { get; }
        public void SetConnection(string connectionString);
    }
}

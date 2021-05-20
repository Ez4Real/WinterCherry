using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Ocelot.API.Getaway.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string[] Get()
        {
            string[] list =
            {
                "Hello from Ocelot API",
                "Catalog - https://localhost:5050/swagger",
                "Booking - https://localhost:5040/swagger",
                "Clients - https://localhost:5070/swagger",
                "Comments - https://localhost:5080/swagger",
                "Payment - https://localhost:5090/swagger",
            };
            return list;
        }
    }
}
using Lesgriots.API.Data;
using Lesgriots.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesgriots.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        MaDbContext _dbConext;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, MaDbContext dbConext)
        {
            _logger = logger;
            _dbConext = dbConext;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<User> Get()
        {
            var a = _dbConext.Users.ToArray();
            return _dbConext.Users.ToArray();
        }
    }
}

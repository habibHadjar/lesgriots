
using Lesgriots.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lesgriots.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
   
    public class UsersController : ControllerBase
    {
       
        private readonly ILogger<UsersController> _logger;
        private readonly UserService _userService;

        public UsersController(ILogger<UsersController> logger, UserService userService)
        {
            _logger = logger;
            _userService = userService;

        }

        [Authorize(Roles = "admin,superadmin")]
        [HttpGet(Name = "user")]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }

        
        [HttpGet("{id}")]
        
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null) return NotFound();
            return Ok(user);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Receptbas_ASPNET.Repository.Entities;
using Receptbas_ASPNET.Repository.Interfaces;

namespace Receptbas_ASPNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _userRepo;

        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _userRepo.GetUsers();
            return Ok(users);
        }

        [Route("register")]
        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            _userRepo.CreateUser(user);
            return Created();
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login(User user)
        {
            var existingUser = _userRepo.Login(user);
            return Ok(existingUser.UserId);
        }
    }
}

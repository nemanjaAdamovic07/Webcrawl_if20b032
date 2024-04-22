using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using userapi.Domain;
using userapi.Domain.Users;

namespace userapi.Controllers
{
    [ApiController]
    [Route("[controller/users]")]
    public class UsersController
    {
        private readonly ILogger<UsersController> _logger;
        private readonly AppDbContext _context;

        public UsersController(ILogger<UsersController> logger, AppDbContext dbContext)
        {
            _logger = logger;
        }
        //[HttpGet(Name = "GetUser")]
        //public async Task<Users> GetUserAsync(string email, string pw)
        //{

        //    return;
        //}


    }
}

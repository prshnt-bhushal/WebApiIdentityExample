using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIAuthExample.Models;
using WebAPIAuthExample.Services;

namespace WebAPIAuthExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Users>>> GetUsers()
        {
            var users = await _context.Users
                .Include(u => u.Company)
                .Include(u => u.Roles)
                .ToListAsync();

            return Ok(users);
        }

    }
}

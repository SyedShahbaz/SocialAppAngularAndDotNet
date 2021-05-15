using System.Collections.Generic;
using System.Threading.Tasks;
using API.Abstraction;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IUserFetcher _fetcher;


        public UsersController(DataContext context, IUserFetcher fetcher)
        {
            _context = context;
            _fetcher = fetcher;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers() 
        {
            return await _context.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id)
        {
            return _fetcher.GetUser(id);
        }

    }
}
using System.Collections.Generic;
using DbAccess.DbModel;
using Microsoft.AspNetCore.Mvc;
using OperationContracts.Abstraction;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserFetcher _fetcher;

        public UsersController( IUserFetcher fetcher)
        {
            _fetcher = fetcher;
        }

        [HttpGet]
        public IEnumerable<AppUser> GetUsers() 
        {
            return  _fetcher.GetUsers();
        }

        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id)
        {
            return _fetcher.GetUser(id);
        }

    }
}

// TODO
// Add BusinessLogic project inside Components and move Contracts.Implementation.UserFetcher to that project.. 
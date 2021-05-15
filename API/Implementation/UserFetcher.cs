using System.Collections.Generic;
using API.Abstraction;
using API.Entities;
using API.Data;
using System.Linq;

namespace API.Implementation
{
    public class UserFetcher : IUserFetcher
    {
        private readonly DataContext _context;

        public UserFetcher(DataContext context)
        {
            _context = context;
        }

        public AppUser GetUser(int id)
        {
            return _context.Users.Find(id);
        }

        public  IEnumerable<AppUser> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
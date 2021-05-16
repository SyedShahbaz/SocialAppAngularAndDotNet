using System.Collections.Generic;
using System.Linq;
using DbAccess.Data;
using DbAccess.DbModel;
using OperationContracts.Abstraction;

namespace OperationContracts.Implementation
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

        public IEnumerable<AppUser> GetUsers()
        {
            return _context.Users.ToList();
        }

        public int Test()
        {
            return 5;
        }
    }
}

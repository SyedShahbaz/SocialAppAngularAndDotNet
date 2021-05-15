using System.Collections.Generic;
using API.Entities;
using System.Threading.Tasks;

namespace API.Abstraction
{
    public interface IUserFetcher
    {
        IEnumerable<AppUser> GetUsers();
        AppUser GetUser(int id);

    }
}
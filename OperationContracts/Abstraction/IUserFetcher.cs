using System.Collections.Generic;
using DbAccess.DbModel;

namespace OperationContracts.Abstraction
{
    public interface IUserFetcher
    {
        int Test();
        IEnumerable<AppUser> GetUsers();
        AppUser GetUser(int id);
    }
}

using OA.Core.POCO;
using OA.Core.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OA.DataAccess.Repositories
{
    public class UserRepository: IUserRepository
    {
        public async Task<IEnumerable<User>> GetAll() {
            return null;
        }
    }
}

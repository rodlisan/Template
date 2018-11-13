using $saferootprojectname$.Core.POCO;
using $saferootprojectname$.Core.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace $safeprojectname$.Repositories
{
    public class UserRepository: IUserRepository
    {
        public async Task<IEnumerable<User>> GetAll() {
            return null;
        }
    }
}

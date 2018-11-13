using $safeprojectname$.POCO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace $safeprojectname$.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
    }
}

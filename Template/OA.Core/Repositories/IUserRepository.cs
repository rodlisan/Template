using OA.Core.POCO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OA.Core.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
    }
}

using DevFreela.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevFreela.Core.Interfaces.Repositores
{
    public interface IUserRepository
    {
        Task Add(User user);
        Task<List<User>> GetAll();
        Task<User> GetUser(int id);
    }
}

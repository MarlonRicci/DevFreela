using DevFreela.Core.Entities;
using System.Threading.Tasks;

namespace DevFreela.Core.Interfaces.Repositores
{
    public interface IUserRepository
    {
        Task Add(User user);
        Task<User> GetUser(int id);
    }
}

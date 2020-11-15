using DevFreela.Core.Entities;
using DevFreela.Core.Interfaces.Repositores;
using System;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence.Repositores
{
    public class UserRepository : IUserRepository
    {
        private readonly DevFreelaDbContext _dbContext;

        public UserRepository(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }
    }
}

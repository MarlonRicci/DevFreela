using DevFreela.Core.Entities;
using DevFreela.Core.Interfaces.Repositores;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence.Repositores
{
    public class SkillRepository : ISkillRepository
    {
        private readonly DevFreelaDbContext _dbContext;

        public SkillRepository(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Skill skill)
        {
            await _dbContext.Skills.AddAsync(skill);
            await _dbContext.SaveChangesAsync();
        }
    }
}

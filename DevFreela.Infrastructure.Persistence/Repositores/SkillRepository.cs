using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DevFreela.Core.Entities;
using DevFreela.Core.Interfaces.Repositores;

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
            await _dbContext.AddAsync(skill);
            await _dbContext.SaveChangesAsync();
        }
    }
}

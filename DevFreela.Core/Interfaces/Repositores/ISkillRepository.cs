using DevFreela.Core.Entities;
using System.Threading.Tasks;

namespace DevFreela.Core.Interfaces.Repositores
{
    public interface ISkillRepository
    {
        Task Add(Skill skill);
    }
}

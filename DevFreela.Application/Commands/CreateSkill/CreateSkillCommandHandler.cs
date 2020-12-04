using DevFreela.Core.Entities;
using DevFreela.Core.Interfaces.Repositores;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.CreateSkill
{
    public class CreateSkillCommandHandler : IRequestHandler<CreateSkillCommand, CreateSkillViewModel>
    {
        private readonly ISkillRepository _skillRepository;

        public CreateSkillCommandHandler(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        public async Task<CreateSkillViewModel> Handle(CreateSkillCommand request, CancellationToken cancellationToken)
        {

            var skill = new Skill(request.Description);

            await _skillRepository.Add(skill);

            return new CreateSkillViewModel(skill.Id, skill.Description);
        }
    }
}

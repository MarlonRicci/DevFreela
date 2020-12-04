using MediatR;

namespace DevFreela.Application.Commands.CreateSkill
{
    public class CreateSkillCommand : IRequest<CreateSkillViewModel>
    {
        public CreateSkillCommand(string description)
        {
            Description = description;
        }

        public string Description { get; set; }
    }
}

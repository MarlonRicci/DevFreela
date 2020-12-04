namespace DevFreela.Application.Commands.CreateSkill
{
    public class CreateSkillViewModel
    {
        public CreateSkillViewModel(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public int Id { get; private set; }
        public string Description { get; private set; }
    }
}

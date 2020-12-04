using System.Collections.Generic;

namespace DevFreela.Application.Queries.GetAllUsers
{
    public class GetAllUsersViewModel
    {
        public GetAllUsersViewModel(int id, string name, List<UserSkillViewModel> userSkills)
        {
            Id = id;
            Name = name;
            UserSkills = userSkills;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public List<UserSkillViewModel> UserSkills { get; private set; }
    }
}

using DevFreela.Application.Queries.GetUser;
using DevFreela.Core.Interfaces.Repositores;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<GetAllUsersViewModel>>
    {
        private readonly IUserRepository _userRepository;

        public GetAllUsersQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<GetAllUsersViewModel>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAll();

            var usersViewModel = users
                .Select(s => new GetAllUsersViewModel(s.Id, s.Name, new List<UserSkillViewModel>()))
                .ToList();

            return usersViewModel;
        }
    }
}

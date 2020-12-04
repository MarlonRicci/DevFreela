using DevFreela.Application.Queries.GetAllUsers;
using MediatR;
using System.Collections.Generic;

namespace DevFreela.Application.Queries.GetUser
{
    public class GetAllUsersQuery : IRequest<List<GetAllUsersViewModel>>
    {
    }
}

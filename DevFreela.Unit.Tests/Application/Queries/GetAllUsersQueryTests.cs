using DevFreela.Application.Queries.GetAllUsers;
using DevFreela.Application.Queries.GetUser;
using DevFreela.Core.Entities;
using DevFreela.Core.Interfaces.Repositores;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace DevFreela.Unit.Tests.Application.Queries
{
    public class GetAllUsersQueryTests
    {
        [Fact]
        public async Task ExistThreeUsers_Executed_ThreeUsersViewModel()
        {
            // Arrange
            var users = new List<User>
            {
                new User("Marlon", "marlon.ricci", DateTime.Now),
                new User("Micael", "micael.ricci", DateTime.Now),
                new User("Natalia", "natalia.spigolon", DateTime.Now)
            };

            var userRepository = new Mock<IUserRepository>();
            userRepository.Setup(sr => sr.GetAll()).Returns(Task.FromResult(users));

            var getAllUsersQuery = new GetAllUsersQuery();
            var getAllUsersQueryHandler = new GetAllUsersQueryHandler(userRepository.Object);

            // Act
            var usersViewModel = await getAllUsersQueryHandler.Handle(getAllUsersQuery, new CancellationToken());

            // Assert
            Assert.NotNull(usersViewModel);
            Assert.Equal(users.Count, usersViewModel.Count);

            foreach (var user in users)
            {
                var userViewModel = usersViewModel.SingleOrDefault(s => s.Name == user.Name);

                Assert.NotNull(userViewModel);
            }

            userRepository.Verify(ur => ur.GetAll(), Times.Once);
        }
    }
}

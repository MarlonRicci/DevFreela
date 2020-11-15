using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Interfaces.Repositores
{
    public interface IUserRepository
    {
        Task Add(User user);
    }
}

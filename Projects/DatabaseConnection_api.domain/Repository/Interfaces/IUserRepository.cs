using DatabaseConnection_api.domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection_api.domain.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<bool> AddUser(CreateUser request);
        Task<IEnumerable<ReadUser>> GetUsers();
        Task<ReadUser> GetUser(int userId);
    }
}

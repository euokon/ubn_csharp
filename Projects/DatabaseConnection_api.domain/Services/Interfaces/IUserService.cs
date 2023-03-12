using DatabaseConnection_api.domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection_api.domain.Services.Interfaces
{
    public interface IUserService
    {
        Task<bool> AddUser(CreateUser request);
        Task<IEnumerable<ReadUser>> GetUsers();
        Task<ReadUser> GetUser(int userId);

    }
}

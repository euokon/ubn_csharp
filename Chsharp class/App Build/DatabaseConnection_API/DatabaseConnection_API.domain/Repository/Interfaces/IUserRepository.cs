using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection_API.domain.Models;

namespace DatabaseConnection_API.domain.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<bool> AddUser(CreateUser request);
        Task<bool> ModifyUser(UpdateUser request);
        Task<bool> UserStatus(string userStatus, int userId);
    }
}

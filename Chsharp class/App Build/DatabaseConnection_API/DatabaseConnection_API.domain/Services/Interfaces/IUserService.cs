using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection_API.domain.Models;

namespace DatabaseConnection_API.domain.Services.Interfaces
{
    public interface IUserService
    {
        Task<bool> AddUser(CreateUser request);
        Task<bool> ModifyUser(UpdateUser request);
        Task<bool> ActivateUser(int userId);
        Task<bool> DeactivateUser(int userId);
    }
}

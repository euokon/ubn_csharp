using System;
using SimpleApi.Domain.Models;

namespace SimpleApi.Domain.Repository.Interfaces
{
	public interface IUserRepository
	{
        Task<bool> AddUser(CreateUser request);
        Task<bool> UpdateUser(UpdateUser request);
        Task<bool> DeactivateUser(UserStatus request);
        Task<bool> ActivateUser(UserStatus request);
        Task<IEnumerable<ReadUser>> GetUsers();
        Task<ReadUser> GetUser(int userId);
    }
}


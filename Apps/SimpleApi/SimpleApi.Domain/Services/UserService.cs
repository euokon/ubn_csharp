using System;
using SimpleApi.Domain.Models;
using SimpleApi.Domain.Repository.Interfaces;
using SimpleApi.Domain.Services.Interfaces;

namespace SimpleApi.Domain.Services
{
	public class UserService : IUserService
    {
		private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
        }

        public async Task<bool> AddUser(CreateUser request)
        {
            var response = await _userRepository.AddUser(request);
            return response;
        }

        public async Task<bool> UpdateUser(UpdateUser request)
        {
            var response = await _userRepository.UpdateUser(request);
            return response;
        }

        public async Task<bool> DeactivateUser(UserStatus request)
        {
            var response = await _userRepository.DeactivateUser(request);
            return response;
        }

        public async Task<bool> ActivateUser(UserStatus request)
        {
            var response = await _userRepository.ActivateUser(request);
            return response;
        }

        public async Task<IEnumerable<ReadUser>> GetUsers()
        {
            var response = await _userRepository.GetUsers();
            return response;
        }

        public async Task<ReadUser> GetUser(int userId)
        {
            var response = await _userRepository.GetUser(userId);
            return response;
        }
    }
}


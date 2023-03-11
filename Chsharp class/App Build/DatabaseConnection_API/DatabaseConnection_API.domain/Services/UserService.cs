using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection_API.domain.Models;
using DatabaseConnection_API.domain.Repository.Interfaces;
using DatabaseConnection_API.domain.Services.Interfaces;

namespace DatabaseConnection_API.domain.Services
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

        public async Task<bool> ModifyUser(UpdateUser request)
        {
            var response = await _userRepository.ModifyUser(request);
            return response;
        }
        public async Task<bool> ActivateUser(int userId)
        {
            string userStatus = "Y";
            var response = await _userRepository.UserStatus(userStatus, userId);
            return response;
        }
        public async Task<bool> DeactivateUser(int userId)
        {
            string userStatus = "N";
            var response = await _userRepository.UserStatus(userStatus, userId);
            return response;
        }
    }
}

using DatabaseConnection_api.domain.Models;
using DatabaseConnection_api.domain.Repository.Interfaces;
using DatabaseConnection_api.domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection_api.domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        { _userRepository = userRepository; 
        }

        public async Task<bool> AddUser(CreateUser request)
        {
            var response = await _userRepository.AddUser(request);
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

using System;
using Microsoft.Extensions.Configuration;
using SimpleApi.Domain.Repository.Interfaces;
using Microsoft.Extensions.Logging;
using SimpleApi.Domain.Models;
using Dapper;

namespace SimpleApi.Domain.Repository
{
	public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        private readonly ILogger<UserRepository> _logger;
        private readonly IConfiguration _configuration;

        public UserRepository(AppDbContext context, ILogger<UserRepository> logger, IConfiguration config)
        {
            _context = context;
            _logger = logger;
            _configuration = config;
        }

        public async Task<bool> AddUser(CreateUser request)
        {
            bool inserted = true;

            string query = $@"INSERT into TestTable(UserName, FirstName, LastName, EmailAddress)
                            VALUES(@UserName, @FirstName, @LastName, @EmailAddress)";

            using (var connection = _context.CreateConnection())
            {
                var userCreation = await connection.ExecuteAsync(query, new
                {
                    UserName = request.UserName,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    EmailAddress = request.EmailAddress
                });
                inserted = true;
                return inserted;
            }
        }

        public async Task<bool> UpdateUser(UpdateUser request)
        {
            bool inserted = true;

            string query = $@"UPDATE TestTable SET UserName = @UserName, FirstName = @FirstName, LastName = @LastName, EmailAddress = @EmailAddress, DateModified = GETDATE() WHERE Id = @Id ";

            using (var connection = _context.CreateConnection())
            {
                var userCreation = await connection.ExecuteAsync(query, new
                {
                    UserName = request.UserName,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    EmailAddress = request.EmailAddress,
                    Id = request.Id
                });
                inserted = true;
                return inserted;
            }
        }

        public async Task<bool> DeactivateUser(UserStatus request)
        {
            bool inserted = true;

            string query = $@"UPDATE TestTable SET IsActive = false, DateModified = GETDATE() WHERE Id = @Id ";

            using (var connection = _context.CreateConnection())
            {
                var userCreation = await connection.ExecuteAsync(query, new { Id = request.Id });
                inserted = true;
                return inserted;
            }
        }

        public async Task<bool> ActivateUser(UserStatus request)
        {
            bool inserted = true;

            string query = $@"UPDATE TestTable SET IsActive = false, DateModified = GETDATE() WHERE Id = @Id ";

            using (var connection = _context.CreateConnection())
            {
                var userCreation = await connection.ExecuteAsync(query, new { Id = request.Id });
                inserted = true;
                return inserted;
            }
        }

        public async Task<IEnumerable<ReadUser>> GetUsers()
        {
            string query = "Select * from TestTable";

            using (var connection = _context.CreateConnection())
            {
                var users = await connection.QueryAsync<ReadUser>(query);
                return users.ToList();
            }
        }

        public async Task<ReadUser> GetUser(int userId)
        {
            string query = "Select * from TestTable where Id = @Id";

            using (var connection = _context.CreateConnection())
            {
                var user = await connection.QueryFirstOrDefaultAsync<ReadUser>(query, new { Id = userId });
                return user;
            }
        }
    }
}


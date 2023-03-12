using Dapper;
using DatabaseConnection_api.domain.Models;
using DatabaseConnection_api.domain.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection_api.domain.Repository
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
            bool inserted = false;

            string query = $@"INSERT INTO  TestTable(UserName, FirstName, LastName, EmailAddress)
                          VALUES(:UserName, :FirstName, :LastName, :EmailAddress)";
            // we use the "$" to allow use parameters in our query while the "@" allows us to write multiple lines

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

        public async Task<IEnumerable<ReadUser>> GetUsers()
        {
            string query = "select * from TestTable";

            using (var connection = _context.CreateConnection())
            {
                var users = await connection.QueryAsync<ReadUser>(query);
                return users.ToList();
            }
        }

        public async Task<ReadUser> GetUser(int userId)    //GetUser() gets one record, GetUsers() gets multiple
        {
            string query = "select * from TestTable where Id = :Id";

            using (var connection = _context.CreateConnection())
            {
                var user = await connection.QueryFirstOrDefaultAsync<ReadUser>
                    (query, new { Id = userId });
                return user;

            }
        }
    }
}

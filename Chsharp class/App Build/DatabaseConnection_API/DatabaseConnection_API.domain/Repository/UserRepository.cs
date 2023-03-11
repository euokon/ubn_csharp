using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DatabaseConnection_API.domain.Models;
using DatabaseConnection_API.domain.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace DatabaseConnection_API.domain.Repository
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
            string query = $@"INSERT INTO TestTable(UserName, FirstName, LastName, EmailAddress)
            VALUES(:UserName, :FirstName, :LastName, :EmailAddresss)";
            using (var connection = _context.createConnection())
            {
                var userCreation = await connection.ExecuteAsync(query, new
                {
                    UserName = request.Username,
                    FirstName = request.LastName,
                    LastName = request.LastName,
                    EmailAddress = request.EmailAddress
                });
                inserted = true;

            }
            return inserted;
        }
        public async Task<bool> ModifyUser(UpdateUser request)
        {
            bool inserted = false;
            string query = $@"UPDATE TABLE TestTable SET firstname=: FirstName, lastname=: LastName, 
                            emailaddress=: EmailAddress, datemodified = sysdate WHERE ID=:ID";
            using (var connection = _context.createConnection())
            {
                var userCreation = await connection.ExecuteAsync(query, new
                {

                    FirstName = request.LastName,
                    LastName = request.LastName,
                    EmailAddress = request.EmailAddress,
                    ID = request.Id
                });
                inserted = true;

            }
            return inserted;
        }
        public async Task<bool> UserStatus(string userStatus, int userId)
        {
            bool inserted = false;
            string query = $@"UPDATE testtable SET isactive=:UserStatus, datemodified= sysdate WHERE id=:ID";
            try
            {
                using (var connection = _context.createConnection())
                {
                    var userCreation = await connection.ExecuteAsync(query, new
                    {
                        ID = userId,
                        UserStatus = userStatus
                    });
                    inserted = true;
                }
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message + " " + ex.StackTrace;
            }
            return inserted;
        }

    }
}


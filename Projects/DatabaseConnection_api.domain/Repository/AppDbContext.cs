using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection_api.domain.Repository
{
    public class AppDbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public AppDbContext(IConfiguration configuration) 
        { 
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("oracleConn");
        }

        public IDbConnection CreateConnection() => new OracleConnection(_connectionString);
    }
}

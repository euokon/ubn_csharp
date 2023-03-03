using System;
using System.Data;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SimpleApi.Domain.Repository
{
	public class AppDbContext
	{
		private readonly IConfiguration _configuration;
		private readonly string _connectionString;
        //private DbTransaction _transaction;
        //private readonly DbConnection _connection;

        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("testDbConn");
            //_connection = new SqlConnection(_connectionString);
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);

    }
}


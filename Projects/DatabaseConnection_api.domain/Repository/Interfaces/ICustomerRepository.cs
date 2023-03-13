using DatabaseConnection_api.domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection_api.domain.Repository.Interfaces
{
    public interface ICustomerRepository
    {
        Task<List<AccountDetails>> GetAccountData(string customerId);
        Task<CustomerDetails> GetCustomerData(string customerId);
        string GetCustomerId(string accountNumber);

    }
}

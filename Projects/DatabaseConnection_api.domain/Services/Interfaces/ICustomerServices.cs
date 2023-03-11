using DatabaseConnection_api.domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection_api.domain.Services.Interfaces
{
    public interface ICustomerServices
    {
        Task<CustomerInfo> FetchCustomer(string accountNumber);
    }
}

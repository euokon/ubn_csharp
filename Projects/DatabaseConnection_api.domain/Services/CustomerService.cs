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
    public class CustomerService : ICustomerServices
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<CustomerInfo> FetchCustomer(string accountNumber)
        {
            string customerId = _customerRepository.GetCustomerId(accountNumber);
            var customer = await _customerRepository.GetCustomerData(customerId);
            var accounts = await _customerRepository.GetAccountData(customerId);
            var customerData = new CustomerInfo
            {
                CustomerName = customer.CustomerName,
                CustomerNumber = customer.CustomerNumber,
                CustomerAge = customer.CustomerAge,
                CustomerRelationshipDate = customer.CustomerRelationshipDate,
                CustomerType = customer.CustomerType,
                Gender = customer.Gender,
                RmName = customer.RmName,
                DateOfBirth = customer.DateOfBirth,
                BusinessSegment = customer.BusinessSegment,
                AccountCount = accounts.Count,
                TotalBalance = accounts.Sum(a => a.LcyBalance),
                AccountData = accounts,
            };
            return customerData;

        }
    }
}

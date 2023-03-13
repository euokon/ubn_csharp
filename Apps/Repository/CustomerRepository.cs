using System;
using System.Collections.Generic;
using System.Linq;
using UBN_CSHARP.Models;

namespace UBN_CSHARP.Repository
{
	public class UserRepository
	{
        //public UserRepository()
        //{
        //}
        public List<Customer> GetCustomers()
        {
            var customers = CustomerData.Customers.Select(a => new
            {
                CustomerId = a.CustomerId,
                CustomerName = a.CustomerName,
                CustomerType = a.CustomerType,
                Gender = a.Gender,
                CustomerRelationshipDate = a.CustomerRelationshipDate,
            });

            return (List<Customer>)customers;
        }

        public Customer GetCustomer(string custId)
        {
            var customer = CustomerData.Customers.Where(b => b.CustomerId == custId)
                .Select(a => new
            {
                CustomerId = a.CustomerId,
                CustomerName = a.CustomerName,
                CustomerType = a.CustomerType,
                Gender = a.Gender,
                CustomerRelationshipDate = a.CustomerRelationshipDate,
            });

            return (Customer)customer;
        }
    }
}


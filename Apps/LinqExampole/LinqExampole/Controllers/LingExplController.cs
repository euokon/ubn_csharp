using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinqExampole.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LinqExampole.Controllers
{
    [Route("api/[controller]")]
    public class LingExplController : Controller
    {
        [HttpGet("Customers")]
        public IActionResult GetCustomers()
        {
            var customers = CustomersData.Customers.Select(a => new
            {
                CustomerId = a.CustomerId,
                CustomerName = a.CustomerName,
                CustomerType = a.CustomerType,
                Gender = a.Gender,
                CustomerRelationshipDate = a.CustomerRelationshipDate,
            });

            if (customers == null)
                return NotFound();
            return Ok(customers);
        }

        [HttpGet("Customer/{custId}")]
        public IActionResult GetCustomer(string custId)
        {
            var customer = CustomersData.Customers.Where(b => b.CustomerId == custId)
                .Select(a => new
                {
                    CustomerId = a.CustomerId,
                    CustomerName = a.CustomerName,
                    CustomerType = a.CustomerType,
                    Gender = a.Gender,
                    CustomerRelationshipDate = a.CustomerRelationshipDate,
                });

            if (customer == null)
                return NotFound();
            return Ok(customer);
        }

        [HttpGet("Accounts")]
        public IActionResult GetAccounts()
        {
            var accounts = AccountsData.Accounts.Select(a => new
            {
                CustomerId = a.CustomerId,
                AccountNumber = a.AccountNumber,
                AccountName = a.AccountName,
                AccountClass = a.AccountClass,
                AccountStatus = a.AccountStatus,
                AccountBalance = a.AccountBalance,
                Currency = a.Currency,
                AccountOpeningDate = a.AccountOpeningDate,
            });

            //if (true)
            //{

            //}
            //else
            //{

            //}

            if (accounts == null)
                return NotFound();
            return Ok(accounts);
        }


        [HttpGet("Account/{acctNum}")]
        public IActionResult GetAccount(string acctNum)
        {
            var account = AccountsData.Accounts.Where(b => b.AccountNumber == acctNum)
                .Select(a => new
                {
                    CustomerId = a.CustomerId,
                    AccountNumber = a.AccountNumber,
                    AccountName = a.AccountName,
                    AccountClass = a.AccountClass,
                    AccountStatus = a.AccountStatus,
                    AccountBalance = a.AccountBalance,
                    Currency = a.Currency,
                    AccountOpeningDate = a.AccountOpeningDate,
                });

            if (account == null)
                return NotFound();
            return Ok(account);
        }

        [HttpGet("customers-by-gender/{custGender}")]
        public IActionResult GetCustomerByGender(string custGender)
        {
            var customer = CustomersData.Customers.Where(b => b.Gender[0].ToString().ToUpper() == custGender[0].ToString().ToUpper())
            //var customer = CustomersData.Customers.Where(b => b.Gender.Substring(0, 1) == custGender.Substring(0,1).ToUpper())
            //var customer = CustomersData.Customers.Where(b => b.Gender.StartsWith(custGender[0].ToString().ToUpper()))
                .Select(a => new
                {
                    CustomerId = a.CustomerId,
                    CustomerName = a.CustomerName,
                    CustomerType = a.CustomerType,
                    Gender = a.Gender,
                    CustomerRelationshipDate = a.CustomerRelationshipDate,
                });

            if (customer == null)
                return NotFound();
            return Ok(customer);
        }

        [HttpGet("customers-data/{acctNumber}")]
        public IActionResult GetCustomerData(string acctNumber)
        {
            var account = AccountsData.Accounts.Where(b => b.AccountNumber == acctNumber)
                .Select(a => new
                {
                    CustomerId = a.CustomerId,
                    AccountNumber = a.AccountNumber,
                    AccountName = a.AccountName,
                    AccountClass = a.AccountClass,
                    AccountStatus = a.AccountStatus,
                    AccountBalance = a.AccountBalance,
                    Currency = a.Currency,
                    AccountOpeningDate = a.AccountOpeningDate,
                });

            var custData = account.FirstOrDefault();
            // .FirstOrDefault(); to select the first item in the list

            //string custId = custData.CustomerId;

            //string anyVariable = (conditional statement) ? (if true) : (if false);

            //string custId;

            // alternative ways to write if statement

            // 1
            //if (custData != null)
            //{
            //    custId = custData.CustomerId;
            //}
            //else
            //{
            //    custId = "";
            //}

            // 2
            //if(custData != null)
            //     custId = custData.CustomerId;
            // custId = "";

            // 3
            string custId = custData != null ? custData.CustomerId : "";
            //string custId = custData == null ? "" : custData.CustomerId;

            // fetch customer accounts
            var custAccts = AccountsData.Accounts.Where(b => b.CustomerId == custId)
                .Select(a => new
                {
                    CustomerId = a.CustomerId,
                    AccountNumber = a.AccountNumber,
                    AccountName = a.AccountName,
                    AccountClass = a.AccountClass,
                    AccountStatus = a.AccountStatus,
                    AccountBalance = a.AccountBalance,
                    Currency = a.Currency,
                    AccountOpeningDate = a.AccountOpeningDate,
                });

            // fetch customer information
            var customer = CustomersData.Customers.Where(b => b.CustomerId == custId)
                .Select(a => new
                {
                    CustomerId = a.CustomerId,
                    CustomerName = a.CustomerName,
                    CustomerType = a.CustomerType,
                    Gender = a.Gender,
                    CustomerRelationshipDate = a.CustomerRelationshipDate,
                    CustomerAccounts = custAccts
                });

            // select first record in the list of one record
            var cust = customer.FirstOrDefault();

            if (cust == null)
                return NotFound();
            return Ok(cust);
        }

    }
}


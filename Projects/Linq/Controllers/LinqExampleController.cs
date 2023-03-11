using Linq.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Linq.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqExampleController : ControllerBase
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
                CustomerRelationDate = a.CustomerRelationshipDate,
            });

            return Ok(customers);
        }

        [HttpGet("Customer/{custId}")]
        public IActionResult GetCustomer(string custId) 
        {
            var customer = CustomersData.Customers.Where(a => a.CustomerId == custId)
                .Select(a => new
                 {
                     CustomerId = a.CustomerId,
                     CustomerName = a.CustomerName,
                     CustomerType = a.CustomerType,
                     Gender = a.Gender,
                     CustomerRelationDate = a.CustomerRelationshipDate,
                 });

            if (customer == null)
                return NotFound();
            return Ok(customer);
           

        }

        [HttpGet("CustomerType")]
        public IActionResult GetCustomerType()
        {
            var customer = CustomersData.Customers.Where(a => a.CustomerType.ToString() == "C")
                .Select(a => new
                {
                    CustomerId = a.CustomerId,
                    CustomerName = a.CustomerName,
                    CustomerType = a.CustomerType,
                    Gender = a.Gender,
                    CustomerRelationDate = a.CustomerRelationshipDate,
                });

            if (customer == null)
                return NotFound();
            return Ok(customer);


        }

        [HttpGet("CustomerType/{CustType}")]
        public IActionResult GetCustomerType(string CustType)
        {
            var customer = CustomersData.Customers.Where(a => a.CustomerType.ToString() == CustType.ToUpper())
                .Select(a => new
                {
                    CustomerId = a.CustomerId,
                    CustomerName = a.CustomerName,
                    CustomerType = a.CustomerType,
                    Gender = a.Gender,
                    CustomerRelationDate = a.CustomerRelationshipDate,
                });

            if (customer == null)
                return NotFound();
            return Ok(customer);


        }

        [HttpGet("CustomerRelationshipDate/{CustRelDt1}/{CustRelDt2}")]
        public IActionResult CustomerRelationDate(DateTime CustRelDt1, DateTime CustRelDt2)
        {
            var customer = CustomersData.Customers.Where
                (a => a.CustomerRelationshipDate >= CustRelDt1 && a.CustomerRelationshipDate  <= CustRelDt2)
                .Select(a => new
                {
                    CustomerId = a.CustomerId,
                    CustomerName = a.CustomerName,
                    CustomerType = a.CustomerType,
                    Gender = a.Gender,
                    CustomerRelationDate = a.CustomerRelationshipDate,
                });

            if (customer == null)
                return NotFound();
            return Ok(customer);


        }

        [HttpGet("CustomerRelationshipDate/{CustRelDt1}/{CustRelDt2}")]
        public IActionResult CustomerRelationDate(DateTime CustRelDt1, DateTime CustRelDt2)
        {
            var customer = CustomersData.Customers.Where
                (a => a.CustomerRelationshipDate >= CustRelDt1 && a.CustomerRelationshipDate <= CustRelDt2)
                .Select(a => new
                {
                    CustomerId = a.CustomerId,
                    CustomerName = a.CustomerName,
                    CustomerType = a.CustomerType,
                    Gender = a.Gender,
                    CustomerRelationDate = a.CustomerRelationshipDate,
                });

            if (customer == null)
                return NotFound();
            return Ok(customer);


        }

        [HttpGet("CustomerGender")]
        public IActionResult GetGender(string CustGender)
        {
            var customer = CustomersData.Customers.Where(
                c => c.Gender[0].ToString() == CustGender[0].ToString().ToUpper())
                //c => c.Gender.Substring(0, 1) == CustGender.Substring(0, 1).ToUpper())
                //c => c.Gender.StartsWith(CustGender[0].ToString().ToUpper()))
                .Select(c => new
                {
                    CustomerId = c.CustomerId,
                    CustomerName = c.CustomerName,
                    CustomerType = c.CustomerType,
                    Gender = c.Gender,
                    CustomerRelationDate = c.CustomerRelationshipDate,
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
                AccountBalance = a.AcccountBalance,
                Currency = a.Currency,
                AccountOpeningDate = a.AccountOpeningDate,
            });

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
                    AccountBalance = a.AcccountBalance,
                    Currency = a.Currency,
                    AccountOpeningDate = a.AccountOpeningDate,
                });

            if (account == null)
                return NotFound();
            return Ok(account);
        }

        [HttpGet("AcccountBalance/{acctBal}")]
        public IActionResult GetAcccountBalance(double acctBal)
        {
            var account = AccountsData.Accounts.Where(b => b.AcccountBalance >= acctBal)
                .Select(a => new
                {
                    CustomerId = a.CustomerId,
                    AccountNumber = a.AccountNumber,
                    AccountName = a.AccountName,
                    AccountClass = a.AccountClass,
                    AccountStatus = a.AccountStatus,
                    AccountBalance = a.AcccountBalance,
                    Currency = a.Currency,
                    AccountOpeningDate = a.AccountOpeningDate,
                });

            if (account == null)
                return NotFound();
            return Ok(account);
        }


    }

}

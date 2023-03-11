using LinkdExamples.models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace LinkdExamples.Controllers
{
    [Route("api/[controller]")]
    public class LinkedExampleController : Controller
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
        public IActionResult GetAccount()
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
        [HttpGet("CustomerCor")]
        public IActionResult GetCorporateCustomer()
        {

            var customer = CustomersData.Customers.Where(b => b.CustomerType.ToString() == "C")
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
        [HttpGet("CustomerIndivOrCor/{custType}") ]
        public IActionResult GetCustomerIndOrCor(string custType)
        {

            var customer = CustomersData.Customers.Where(b => b.CustomerType.ToString() == custType.ToUpper())
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
        [HttpGet("CustomerDate/{CustomerRelationshipDate}")]
        public IActionResult GetCustomerDate(DateTime CustomerRelationshipDate)
        {

            var customer = CustomersData.Customers.Where(b => b.CustomerRelationshipDate >= CustomerRelationshipDate)
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
        [HttpGet("CustomerBtwRelDate/{CustomerRelationshipDate}")]
        public IActionResult GetCustomerBtwRelDate(DateTime CustomerRelationshipDate, DateTime CustomerRelationshipDat)
        {

            var customer = CustomersData.Customers.Where(b => b.CustomerRelationshipDate <= CustomerRelationshipDate && b.CustomerRelationshipDate >= CustomerRelationshipDate)
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
        [HttpGet("CustomerGender/{CustGender}")]
        public IActionResult GetCustomersbyGender(String custGender)
        {

            var customer = CustomersData.Customers.Where(b => b.Gender[0]== custGender[0])
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
        [HttpGet("AccountBal/{acctBbal}")]// the AccountBal is the name of the URL, AND acctBbal is the parameter,
        //and it should match
        public IActionResult GetAccountbal(double acctBbal)
        {
            var account = AccountsData.Accounts.Where(b => b.AcccountBalance >= acctBbal)
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
                    AccountBalance = a.AcccountBalance,
                    Currency = a.Currency,
                    AccountOpeningDate = a.AccountOpeningDate,

                });

            var custData = account.FirstOrDefault();
            // string anyVariable = (conditional statement) ? (if true) : (if false);
            //string custId = custData != null ? custData.CustomerId : "";
            var customer = CustomersData.Customers.Where(b => b.CustomerId == custId)
                .Select(a => new
                {
                    CustomerId = a.CustomerId,
                    CustomerName = a.CustomerName,
                    CustomerType = a.CustomerType,
                    Gender = a.Gender,
                    CustomerRelationshipDate = a.CustomerRelationshipDate,

                });
            var cust = customer.FirstOrDefault();
                    
         
        }


    }
}

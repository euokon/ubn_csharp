using LinqExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace LinqExample.Controllers
{
    [Route("api/[controller]")]
    public class LinqExampleController : Controller
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
            return Ok(customer);
        }
        [HttpGet("Accounts")]
        public IActionResult GetAccounts()
        {
            var account = AccountsData.Accounts.Select(a => new
            {
                CustomerId = a.CustomerId,
                AccountNumnber = a.AccountNumber,
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
        [HttpGet("CorpCustomerType")]
        public IActionResult CorpCustomerType()
        {
            var customer = CustomersData.Customers.Where(a => a.CustomerType.ToString() == "C")
                .Select(a => new
                {
                    CustomerId = a.CustomerId,
                    CustomerName= a.CustomerName,
                    CustomerType = a.CustomerType,
                    CustomerRelationshipDate = a.CustomerRelationshipDate,
                 
                });
            if (customer == null)
                return NotFound();
            return Ok(customer);
        }
        [HttpGet("CustomerType/{custType}")]
        public IActionResult CustomerType(string custType)
        {
            var customer = CustomersData.Customers.Where(a => a.CustomerType.ToString() == custType.ToUpper())
                .Select(a => new
                {
                    CustomerId = a.CustomerId,
                    CustomerName = a.CustomerName,
                    CustomerType = a.CustomerType,
                    CustomerRelationshipDate = a.CustomerRelationshipDate,

                });
            if (customer == null)
                return NotFound();
            return Ok(customer);
        }
        [HttpGet("AccountOpenDate/{openDate}/{closeDate}")]
        public IActionResult AccountOpenDate(DateTime openDate, DateTime closeDate)
        {
            var accounts = AccountsData.Accounts.Where(a => (a.AccountOpeningDate >= openDate) && (a.AccountOpeningDate <= closeDate))
                .Select(a => new
                {
                    AccountNumber = a.AccountNumber,
                    AccountName = a.AccountName,
                    AccountClass = a.AccountClass,
                    AccountStatus = a.AccountStatus,
                    AccountBalance = a.AcccountBalance,
                    AccountOpeningDate = a.AccountOpeningDate,
                });
            if (accounts == null)
                return NotFound();
            return Ok(accounts);
        }
        [HttpGet("CustomerGender/{custGender}")]
        public IActionResult CustomerGender(string custGender)
        {
            var customers = CustomersData.Customers.Where(a => a.Gender.Substring(0,1) == custGender.Substring(0,1).ToUpper()
            )
                .Select(a => new
                {
                    CustomerId = a.CustomerId,
                    CustomerName = a.CustomerName,
                    CustomerType = a.CustomerType,
                    CustomerRelationshipDate = a.CustomerRelationshipDate,
                    CustomerGender = a.Gender,
                });
            if (customers == null)
                return NotFound();
            return Ok(customers);
        }
//        [HttpGet("GetAccountbalance/{acctBal}")]
//        public IActionResult GetAccountbalance(int acctBal)
//        {
//            var account = AccountsData.Accounts.Where(a => a.AcccountBalance > acctBal)
//                .Select(a => new
//                {
//                    AccountNumber = a.AccountNumber,
//                    AccountName = a.AccountName,
//                    AccountClass = a.AccountClass,
//                    AccountStatus = a.AccountStatus,
//                    AccountBalance = a.AcccountBalance,
//                    AccountOpeningDate = a.AccountOpeningDate,
//                });
//            if (accounts == null)
//                return NotFound();
//            return Ok(accounts);
//        }
//        //CustomerId = a.CustomerId,
//        //AccountNumnber = a.AccountNumber,
//        //AccountName = a.AccountName,
//        //AccountClass = a.AccountClass,
//        //AccountStatus = a.AccountStatus,
//        //AccountBalance = a.AcccountBalance,
//        //Currency = a.Currency,
//        //AccountOpeningDate = a.AccountOpeningDate,
//    });
//                if (account == null)
//                    return NotFound();
//                return Ok(account);
//}

    }

}

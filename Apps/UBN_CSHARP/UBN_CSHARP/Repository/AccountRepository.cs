using System;
using System.Collections.Generic;
using System.Linq;
using UBN_CSHARP.Models;

namespace UBN_CSHARP.Repository
{
	public class AccountRepository
	{
		//public AccountRepository()
		//{
		//}

		public List<Account> GetAccounts()
		{
            var accounts = AccountData.Accounts.Select(a => new
            {
                CustomerId = a.CustomerId,
                AccountNumber = a.AccountNumber,
                AccountName = a.AccountName,
                AccountClass = a.AccountClass,
                AccountStatus = a.AccountStatus,
                AcccountBalance = a.AcccountBalance,
                Currency = a.Currency,
                AccountOpeningDate = a.AccountOpeningDate,
            });

            return (List<Account>)accounts;
        }


        public Account GetAccount(string acctNumber)
        {
            var account = AccountData.Accounts.Where(b => b.AccountNumber == acctNumber)
                .Select(a => new
            {
                    CustomerId = a.CustomerId,
                    AccountNumber = a.AccountNumber,
                    AccountName = a.AccountName,
                    AccountClass = a.AccountClass,
                    AccountStatus = a.AccountStatus,
                    AcccountBalance = a.AcccountBalance,
                    Currency = a.Currency,
                    AccountOpeningDate = a.AccountOpeningDate,
                });

            return (Account)account;
        }

    }
}


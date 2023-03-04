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
            int data1 = 9;
            string data12 = "67";
            bool data3;
            long data4;
            double data5;

            var data6 = data1 + 20;
            int data7 = Convert.ToInt32(data12);
            string data8 = data1.ToString();
            double data9 = Convert.ToDouble(data12);

            Account acct = new Account();
            var accts = new Account();

            var account = AccountData.Accounts.Where(b => b.CustomerId == acctNumber)
            //var account = AccountData.Accounts.Where(options => options.AcccountBalance > 2000)
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


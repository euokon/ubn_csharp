using System;
using System.Security.Principal;

namespace LinqExampole.Models
{
	public class AccountsData
	{
        //public AccountsData()
        //{
        //}


        public static List<Account> Accounts = new List<Account>()
        {

            new Account ()
            {
                CustomerId = "12345678",
                AccountNumber = "0000123456",
                AccountName = "Emmanuel",
                AccountBalance = 100000,
                AccountClass = "SA_007",
                AccountOpeningDate= Convert.ToDateTime("02-Jan-2023"),
                AccountStatus = Convert.ToChar("A"),
                Currency = "NGN"
            },
            new Account ()
            {
                CustomerId = "12345678",
                AccountNumber = "0000123457",
                AccountName = "Emmanuel",
                AccountBalance = 100000,
                AccountClass = "SA_005",
                AccountOpeningDate= Convert.ToDateTime("02-Jan-2023"),
                AccountStatus = Convert.ToChar("A"),
                Currency = "USD"
            },
            new Account ()
            {
                CustomerId = "23456789",
                AccountNumber = "0000123498",
                AccountName = "Taofeek",
                AccountBalance = 100000,
                AccountClass = "SA_006",
                AccountOpeningDate= Convert.ToDateTime("02-Jan-2023"),
                AccountStatus = Convert.ToChar("A"),
                Currency = "GBP"
            },
            new Account ()
            {
                CustomerId = "23456789",
                AccountNumber = "0000123409",
                AccountName = "Taofeek",
                AccountBalance = 100000,
                AccountClass = "SA_005",
                AccountOpeningDate= Convert.ToDateTime("02-Jan-2023"),
                AccountStatus = Convert.ToChar("A"),
                Currency = "USD"
            },
            new Account ()
            {
                CustomerId = "23456789",
                AccountNumber = "0000123478",
                AccountName = "Taofeek",
                AccountBalance = 100000,
                AccountClass = "SA_007",
                AccountOpeningDate= Convert.ToDateTime("02-Jan-2023"),
                AccountStatus = Convert.ToChar("A"),
                Currency = "NGN"
            },
            new Account ()
            {
                CustomerId = "34567890",
                AccountNumber = "0000124356",
                AccountName = "Nathan",
                AccountBalance = 100000,
                AccountClass = "SA_007",
                AccountOpeningDate= Convert.ToDateTime("02-Jan-2023"),
                AccountStatus = Convert.ToChar("A"),
                Currency = "NGN"
            },
            new Account ()
            {
                CustomerId = "34567890",
                AccountNumber = "0000145456",
                AccountName = "Nathan",
                AccountBalance = 100000,
                AccountClass = "SA_006",
                AccountOpeningDate= Convert.ToDateTime("02-Jan-2023"),
                AccountStatus = Convert.ToChar("A"),
                Currency = "GBP"
            },
            new Account ()
            {
                CustomerId = "45678901",
                AccountNumber = "0000188456",
                AccountName = "Victor",
                AccountBalance = 100000,
                AccountClass = "SA_007",
                AccountOpeningDate= Convert.ToDateTime("02-Jan-2023"),
                AccountStatus = Convert.ToChar("A"),
                Currency = "NGN"
            },
            new Account ()
            {
                CustomerId = "45678901",
                AccountNumber = "00001663456",
                AccountName = "Victor",
                AccountBalance = 100000,
                AccountClass = "SA_005",
                AccountOpeningDate= Convert.ToDateTime("02-Jan-2023"),
                AccountStatus = Convert.ToChar("A"),
                Currency = "USD"
            },
            new Account ()
            {
                CustomerId = "56789012",
                AccountNumber = "0000973456",
                AccountName = "Bisola",
                AccountBalance = 100000,
                AccountClass = "SA_007",
                AccountOpeningDate= Convert.ToDateTime("02-Jan-2023"),
                AccountStatus = Convert.ToChar("A"),
                Currency = "NGN"
            },
            new Account ()
            {
                CustomerId = "67890123",
                AccountNumber = "0000975456",
                AccountName = "Mofi",
                AccountBalance = 100000,
                AccountClass = "SA_007",
                AccountOpeningDate= Convert.ToDateTime("02-Jan-2023"),
                AccountStatus = Convert.ToChar("A"),
                Currency = "NGN"
            },
            new Account ()
            {
                CustomerId = "78901234",
                AccountNumber = "0000978756",
                AccountName = "Seun",
                AccountBalance = 100000,
                AccountClass = "SA_007",
                AccountOpeningDate= Convert.ToDateTime("02-Jan-2023"),
                AccountStatus = Convert.ToChar("A"),
                Currency = "NGN"
            },
            new Account ()
            {
                CustomerId = "89012345",
                AccountNumber = "0000973646",
                AccountName = "Brian",
                AccountBalance = 100000,
                AccountClass = "SA_007",
                AccountOpeningDate= Convert.ToDateTime("02-Jan-2023"),
                AccountStatus = Convert.ToChar("A"),
                Currency = "NGN"
            },

        };

    }
}


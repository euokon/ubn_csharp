using System;
using System.Collections.Generic;

namespace UBN_CSHARP.Models
{
	public class AccountData
	{
        //public AccountData()
        //{
        //}

        public static List<Account> Accounts = new List<Account>()
        {

            new Account ()
            {
                CustomerId = "12345678",
                AccountNumber = "0000123456",
                AccountName = "Emmanuel",
                AcccountBalance = 100000,
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
                AcccountBalance = 100000,
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
                AcccountBalance = 100000,
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
                AcccountBalance = 100000,
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
                AcccountBalance = 100000,
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
                AcccountBalance = 100000,
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
                AcccountBalance = 100000,
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
                AcccountBalance = 100000,
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
                AcccountBalance = 100000,
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
                AcccountBalance = 100000,
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
                AcccountBalance = 100000,
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
                AcccountBalance = 100000,
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
                AcccountBalance = 100000,
                AccountClass = "SA_007",
                AccountOpeningDate= Convert.ToDateTime("02-Jan-2023"),
                AccountStatus = Convert.ToChar("A"),
                Currency = "NGN"
            },

        };

        //public static List<Account> Accounts()
        //        {
        //            var accounts = new List<Account>()
        //        {

        //            new Account()
        //            {
        //                CustomerId = "12345678",
        //                AccountNumber = "0000123456",
        //                AccountName = "Emmanuel",
        //                AcccountBalance = 100000,
        //                AccountClass = "SA_007",
        //                AccountOpeningDate = Convert.ToDateTime("02-Jan-2023"),
        //                AccountStatus = Convert.ToChar("A"),
        //                Currency = "NGN"
        //            },
        //            new Account()
        //            {
        //                CustomerId = "12345678",
        //                AccountNumber = "0000123457",
        //                AccountName = "Emmanuel",
        //                AcccountBalance = 100000,
        //                AccountClass = "SA_005",
        //                AccountOpeningDate = Convert.ToDateTime("02-Jan-2023"),
        //                AccountStatus = Convert.ToChar("A"),
        //                Currency = "USD"
        //            },
        //            new Account()
        //            {
        //                CustomerId = "23456789",
        //                AccountNumber = "0000123498",
        //                AccountName = "Taofeek",
        //                AcccountBalance = 100000,
        //                AccountClass = "SA_006",
        //                AccountOpeningDate = Convert.ToDateTime("02-Jan-2023"),
        //                AccountStatus = Convert.ToChar("A"),
        //                Currency = "GBP"
        //            },
        //            new Account()
        //            {
        //                CustomerId = "23456789",
        //                AccountNumber = "0000123409",
        //                AccountName = "Taofeek",
        //                AcccountBalance = 100000,
        //                AccountClass = "SA_005",
        //                AccountOpeningDate = Convert.ToDateTime("02-Jan-2023"),
        //                AccountStatus = Convert.ToChar("A"),
        //                Currency = "USD"
        //            },
        //            new Account()
        //            {
        //                CustomerId = "23456789",
        //                AccountNumber = "0000123478",
        //                AccountName = "Taofeek",
        //                AcccountBalance = 100000,
        //                AccountClass = "SA_007",
        //                AccountOpeningDate = Convert.ToDateTime("02-Jan-2023"),
        //                AccountStatus = Convert.ToChar("A"),
        //                Currency = "NGN"
        //            },
        //            new Account()
        //            {
        //                CustomerId = "34567890",
        //                AccountNumber = "0000124356",
        //                AccountName = "Nathan",
        //                AcccountBalance = 100000,
        //                AccountClass = "SA_007",
        //                AccountOpeningDate = Convert.ToDateTime("02-Jan-2023"),
        //                AccountStatus = Convert.ToChar("A"),
        //                Currency = "NGN"
        //            },
        //            new Account()
        //            {
        //                CustomerId = "34567890",
        //                AccountNumber = "0000145456",
        //                AccountName = "Nathan",
        //                AcccountBalance = 100000,
        //                AccountClass = "SA_006",
        //                AccountOpeningDate = Convert.ToDateTime("02-Jan-2023"),
        //                AccountStatus = Convert.ToChar("A"),
        //                Currency = "GBP"
        //            },
        //            new Account()
        //            {
        //                CustomerId = "45678901",
        //                AccountNumber = "0000188456",
        //                AccountName = "Victor",
        //                AcccountBalance = 100000,
        //                AccountClass = "SA_007",
        //                AccountOpeningDate = Convert.ToDateTime("02-Jan-2023"),
        //                AccountStatus = Convert.ToChar("A"),
        //                Currency = "NGN"
        //            },
        //            new Account()
        //            {
        //                CustomerId = "45678901",
        //                AccountNumber = "00001663456",
        //                AccountName = "Victor",
        //                AcccountBalance = 100000,
        //                AccountClass = "SA_005",
        //                AccountOpeningDate = Convert.ToDateTime("02-Jan-2023"),
        //                AccountStatus = Convert.ToChar("A"),
        //                Currency = "USD"
        //            },
        //            new Account()
        //            {
        //                CustomerId = "56789012",
        //                AccountNumber = "0000973456",
        //                AccountName = "Bisola",
        //                AcccountBalance = 100000,
        //                AccountClass = "SA_007",
        //                AccountOpeningDate = Convert.ToDateTime("02-Jan-2023"),
        //                AccountStatus = Convert.ToChar("A"),
        //                Currency = "NGN"
        //            },
        //            new Account()
        //            {
        //                CustomerId = "67890123",
        //                AccountNumber = "0000975456",
        //                AccountName = "Mofi",
        //                AcccountBalance = 100000,
        //                AccountClass = "SA_007",
        //                AccountOpeningDate = Convert.ToDateTime("02-Jan-2023"),
        //                AccountStatus = Convert.ToChar("A"),
        //                Currency = "NGN"
        //            },
        //            new Account()
        //            {
        //                CustomerId = "78901234",
        //                AccountNumber = "0000978756",
        //                AccountName = "Seun",
        //                AcccountBalance = 100000,
        //                AccountClass = "SA_007",
        //                AccountOpeningDate = Convert.ToDateTime("02-Jan-2023"),
        //                AccountStatus = Convert.ToChar("A"),
        //                Currency = "NGN"
        //            },
        //            new Account()
        //            {
        //                CustomerId = "89012345",
        //                AccountNumber = "0000973646",
        //                AccountName = "Brian",
        //                AcccountBalance = 100000,
        //                AccountClass = "SA_007",
        //                AccountOpeningDate = Convert.ToDateTime("02-Jan-2023"),
        //                AccountStatus = Convert.ToChar("A"),
        //                Currency = "NGN"
        //            },

        //        };

        //            return accounts;
        //        }

    }


}


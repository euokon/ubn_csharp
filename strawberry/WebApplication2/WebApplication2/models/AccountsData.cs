using System.Security.Principal;

namespace LinkdExamples.models
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
                AcccountBalance = 140000,
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
                AcccountBalance = 130000,
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
                AcccountBalance = 100600,
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
                AcccountBalance = 300000,
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
                AcccountBalance = 400000,
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
                AcccountBalance = 700000,
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
                AcccountBalance = 200000,
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
                AcccountBalance = 900000,
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
                AcccountBalance = 5000000,
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
                AcccountBalance = 120000,
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

    }





}



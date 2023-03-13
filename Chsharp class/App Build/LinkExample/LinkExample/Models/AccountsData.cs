namespace LinqExample.Models
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
                AcccountBalance = 2500000,
                AccountClass = "SA_007",
                AccountOpeningDate= Convert.ToDateTime("02-Jun-2023"),
                AccountStatus = Convert.ToChar("A"),
                Currency = "NGN"
            },
            new Account ()
            {
                CustomerId = "12345678",
                AccountNumber = "0000123457",
                AccountName = "Emmanuel",
                AcccountBalance = 50000000,
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
                AcccountBalance = 1250180000,
                AccountClass = "SA_006",
                AccountOpeningDate= Convert.ToDateTime("03-Apr-2023"),
                AccountStatus = Convert.ToChar("A"),
                Currency = "GBP"
            },
            new Account ()
            {
                CustomerId = "23456789",
                AccountNumber = "0000123409",
                AccountName = "Taofeek",
                AcccountBalance = 45600000,
                AccountClass = "SA_005",
                AccountOpeningDate= Convert.ToDateTime("20-Aug-2023"),
                AccountStatus = Convert.ToChar("A"),
                Currency = "USD"
            },
            new Account ()
            {
                CustomerId = "23456789",
                AccountNumber = "0000123478",
                AccountName = "Taofeek",
                AcccountBalance = 567100000,
                AccountClass = "SA_007",
                AccountOpeningDate= Convert.ToDateTime("12-Dec-2023"),
                AccountStatus = Convert.ToChar("A"),
                Currency = "NGN"
            },
            new Account ()
            {
                CustomerId = "34567890",
                AccountNumber = "0000124356",
                AccountName = "Nathan",
                AcccountBalance = 678100000,
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
                AcccountBalance = 6743100000,
                AccountClass = "SA_006",
                AccountOpeningDate= Convert.ToDateTime("05-May-2023"),
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
                AccountOpeningDate= Convert.ToDateTime("23-Feb-2023"),
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
                AccountOpeningDate= Convert.ToDateTime("10-Sep-2023"),
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
                AccountOpeningDate= Convert.ToDateTime("13-Oct-2023"),
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
                AccountOpeningDate= Convert.ToDateTime("15-Nov-2023"),
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
                AccountOpeningDate= Convert.ToDateTime("11-Jun-2023"),
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
                AccountOpeningDate= Convert.ToDateTime("13-Mar-2023"),
                AccountStatus = Convert.ToChar("A"),
                Currency = "NGN"
            },

        };

    }


    
}

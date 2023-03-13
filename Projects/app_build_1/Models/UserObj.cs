namespace app_build_1.Models
{   
    public class Users
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Gender { get; set; }

        public DateTime CustomerRelationshipDate { get; set; }
        public char CustomerType { get; set; }
    }

    public class Accounts
    {
        public string CustomerId { get; set; }
        public string AccountNumber { get; set; }
        public double AccountBalance { get; set; }
        public DateTime AccountOpeningDate { get; set; }
        public char AccountStatus { get; set; }
        public string Currency { get; set; }
        public string AccountClass { get; set; }

    }
}

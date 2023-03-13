namespace Linq.Models
{
    public class Customer
    {
        internal string CustomerRelationDate;

        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Gender { get; set; }
        public DateTime CustomerRelationshipDate { get; set; }
        public char CustomerType { get; set; }
    }

    public class Account
    {
        public string CustomerId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public double AcccountBalance { get; set; }
        public DateTime AccountOpeningDate { get; set; }
        public char AccountStatus { get; set; }
        public string Currency { get; set; }
        public string AccountClass { get; set; }
    }
}

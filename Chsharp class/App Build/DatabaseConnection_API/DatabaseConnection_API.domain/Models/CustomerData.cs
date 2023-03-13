using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection_API.domain.Models
{
    public class AccountDetails
    {

        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string Branchname { get; set; }
        public double AccountBalance { get; set; }
        public string AccountClass { get; set; }
        public string Currency { get; set; }
        public string AccountStatus { get; set; }
        public string AccountOpeningDate { get; set; }
    }

    public class CustomerDetails
    {
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public DateTime CustomerRelationshipDate { get; set; }
        public string CustomerType { get; set; }
        public string CustomerGender { get; set; }
        public string RmName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CustomerAge { get; set; }
        public double TotalBalance { get; set; }
        public string AccountCount { get; set; }
        public List <AccountDetails> AccountData    { get; set; }

    }






}
}

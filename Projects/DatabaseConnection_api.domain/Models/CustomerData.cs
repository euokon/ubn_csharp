using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection_api.domain.Models
{
    //public class CustomerData
    //{
    //}

    public class AccountDetails
    {
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string BranchName { get; set; }
        public double LcyBalance { get; set; }
        public double AcyBalance { get; set; }
        public DateTime AccountOpeningDate { get; set; }
        public string AccountClass { get; set; }
        public string Currency { get; set; }
        public string AccountStatus { get; set; }
    }

    public class CustomerDetails
    {
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public DateTime CustomerRelationshipDate { get; set; }
        public string CustomerType { get; set; }
        public string Gender { get; set; }
        public string RmName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int CustomerAge { get; set; }
        public double TotalBalance { get; set; }
        public int AccountCount { get; set; }
        public string BusinessSegment { get; set; }
    }

    public class CustomerInfo2
    {
        public CustomerDetails Customer { get; set; }
        public List<AccountDetails> AccountData { get; set; }

    }

    public class CustomerInfo : CustomerDetails
    {
        public List<AccountDetails> AccountData { get; set; }

    }


}

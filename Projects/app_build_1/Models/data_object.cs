namespace app_build_1.Models
{
    public class data_object
    {
        public data_object() 
        { 
        }



        public class CustomerEntity
        { 
            public string CustomerName { get; set; }
            public string AccountNumber { get; set; }
            public string Gender { get; set; }
            public double AccountBalance { get; set; }
            public DateTime CustRelationshipDtae { get; set; }
            public int CustRelationshipAge { get; set; }
            public long CustomerId { get; set; }
        }
    }
}

using System;
namespace UBN_CSHARP.Models
{
	public class DataObj
	{
		private readonly string username;
		public DataObj()
		{
			username = "taofeek";
		}

		public class CustomerEntity
		{
			public string CustomerName { get; set; }
			public string AccountNumber { get; set; }
			public string Gender { get; set; }
			public double AccountBalance { get; set; }
			public DateTime CustRelationshipDate { get; set; }
			public int CustRelationshipAge { get; set; }
			public long CustomerId { get; set; }
        }
	}
}


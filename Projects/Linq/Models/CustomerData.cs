namespace Linq.Models
{
    public class CustomersData
    {
        //public CustomersData()
        //{
        //}

        public static List<Customer> Customers = new List<Customer>()
        {

            new Customer ()
            {
                CustomerId = "12345678",
                CustomerName = "Outlier",
                Gender = "*",
                CustomerRelationshipDate= Convert.ToDateTime("01-Jan-1914"),
                CustomerType = Convert.ToChar("I"),
            },
            new Customer ()
            {
                CustomerId = "23456789",
                CustomerName = "Uba-nadi'm",
                Gender = "Male",
                CustomerRelationshipDate= Convert.ToDateTime("10-Apr-1952"),
                CustomerType = Convert.ToChar("I"),
            },
            new Customer ()
            {
                CustomerId = "34567890",
                CustomerName = "Nnem-oma",
                Gender = "Female",
                CustomerRelationshipDate= Convert.ToDateTime("28-08-1958"),
                CustomerType = Convert.ToChar("C"),
            },
            new Customer ()
            {
                CustomerId = "45678901",
                CustomerName = "Diokpa-Edu",
                Gender = "Male",
                CustomerRelationshipDate= Convert.ToDateTime("01-Sep-1980"),
                CustomerType = Convert.ToChar("C"),
            },
            new Customer ()
            {
                CustomerId = "56789012",
                CustomerName = "Uchechukwu",
                Gender = "Male",
                CustomerRelationshipDate= Convert.ToDateTime("07-Apr-1984"),
                CustomerType = Convert.ToChar("I"),
            },
            new Customer ()
            {
                CustomerId = "67890123",
                CustomerName = "Emma-nwanem",
                Gender = "Male",
                CustomerRelationshipDate= Convert.ToDateTime("22-Jan-1986"),
                CustomerType = Convert.ToChar("I"),
            },
            new Customer ()
            {
                CustomerId = "78901234",
                CustomerName = "Ada-Uba",
                Gender = "Female",
                CustomerRelationshipDate= Convert.ToDateTime("12-Mar-1988"),
                CustomerType = Convert.ToChar("I"),
            },
            new Customer ()
            {
                CustomerId = "89012345",
                CustomerName = "Victor",
                Gender = "Male",
                CustomerRelationshipDate= Convert.ToDateTime("30-Apr-1993"),
                CustomerType = Convert.ToChar("I"),
            }

        };

    }
}

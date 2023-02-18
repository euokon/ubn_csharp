using System;
using System.Collections.Generic;

namespace UBN_CSHARP.Models
{
	public class CustomerData
	{
        //public UserData()
        //{
        //}

        public static List<Customer> Customers = new List<Customer>()
        {

            new Customer ()
            {
                CustomerId = "12345678",
                CustomerName = "Emmanuel",
                Gender = "Male",
                CustomerRelationshipDate= Convert.ToDateTime("02-Jan-2023"),
                CustomerType = Convert.ToChar("I"),
            },
            new Customer ()
            {
                CustomerId = "23456789",
                CustomerName = "Taofeek",
                Gender = "Male",
                CustomerRelationshipDate= Convert.ToDateTime("02-Jan-2023"),
                CustomerType = Convert.ToChar("I"),
            },
            new Customer ()
            {
                CustomerId = "34567890",
                CustomerName = "Nathan",
                Gender = "Male",
                CustomerRelationshipDate= Convert.ToDateTime("02-Jan-2023"),
                CustomerType = Convert.ToChar("C"),
            },
            new Customer ()
            {
                CustomerId = "45678901",
                CustomerName = "Victor",
                Gender = "Male",
                CustomerRelationshipDate= Convert.ToDateTime("02-Jan-2023"),
                CustomerType = Convert.ToChar("C"),
            },
            new Customer ()
            {
                CustomerId = "56789012",
                CustomerName = "Bisola",
                Gender = "Female",
                CustomerRelationshipDate= Convert.ToDateTime("02-Jan-2023"),
                CustomerType = Convert.ToChar("I"),
            },
            new Customer ()
            {
                CustomerId = "67890123",
                CustomerName = "Mofi",
                Gender = "Female",
                CustomerRelationshipDate= Convert.ToDateTime("02-Jan-2023"),
                CustomerType = Convert.ToChar("I"),
            },
            new Customer ()
            {
                CustomerId = "78901234",
                CustomerName = "Seun",
                Gender = "Male",
                CustomerRelationshipDate= Convert.ToDateTime("02-Jan-2023"),
                CustomerType = Convert.ToChar("I"),
            },
            new Customer ()
            {
                CustomerId = "89012345",
                CustomerName = "Brian",
                Gender = "Male",
                CustomerRelationshipDate= Convert.ToDateTime("02-Jan-2023"),
                CustomerType = Convert.ToChar("I"),
            }

        };



        //public static List<Customer> Customers() 
        //{
        //    var customers = new List<Customer>() {
        //    new Customer ()
        //    {
        //        CustomerId = "12345678",
        //        CustomerName = "Emmanuel",
        //        Gender = "Male",
        //        CustomerRelationshipDate= Convert.ToDateTime("02-Jan-2023"),
        //        CustomerType = Convert.ToChar("I"),
        //    },
        //    new Customer ()
        //    {
        //        CustomerId = "23456789",
        //        CustomerName = "Taofeek",
        //        Gender = "Male",
        //        CustomerRelationshipDate= Convert.ToDateTime("02-Jan-2023"),
        //        CustomerType = Convert.ToChar("I"),
        //    },
        //    new Customer ()
        //    {
        //        CustomerId = "34567890",
        //        CustomerName = "Nathan",
        //        Gender = "Male",
        //        CustomerRelationshipDate= Convert.ToDateTime("02-Jan-2023"),
        //        CustomerType = Convert.ToChar("C"),
        //    },
        //    new Customer ()
        //    {
        //        CustomerId = "45678901",
        //        CustomerName = "Victor",
        //        Gender = "Male",
        //        CustomerRelationshipDate= Convert.ToDateTime("02-Jan-2023"),
        //        CustomerType = Convert.ToChar("C"),
        //    },
        //    new Customer ()
        //    {
        //        CustomerId = "56789012",
        //        CustomerName = "Bisola",
        //        Gender = "Female",
        //        CustomerRelationshipDate= Convert.ToDateTime("02-Jan-2023"),
        //        CustomerType = Convert.ToChar("I"),
        //    },
        //    new Customer ()
        //    {
        //        CustomerId = "67890123",
        //        CustomerName = "Mofi",
        //        Gender = "Female",
        //        CustomerRelationshipDate= Convert.ToDateTime("02-Jan-2023"),
        //        CustomerType = Convert.ToChar("I"),
        //    },
        //    new Customer ()
        //    {
        //        CustomerId = "78901234",
        //        CustomerName = "Seun",
        //        Gender = "Male",
        //        CustomerRelationshipDate= Convert.ToDateTime("02-Jan-2023"),
        //        CustomerType = Convert.ToChar("I"),
        //    },
        //    new Customer ()
        //    {
        //        CustomerId = "89012345",
        //        CustomerName = "Brian",
        //        Gender = "Male",
        //        CustomerRelationshipDate= Convert.ToDateTime("02-Jan-2023"),
        //        CustomerType = Convert.ToChar("I"),
        //    }
        //    };
        //    return customers;

        //}

    }
}


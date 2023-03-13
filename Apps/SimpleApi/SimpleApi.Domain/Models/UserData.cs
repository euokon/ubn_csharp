using System;
namespace SimpleApi.Domain.Models
{
    //public class UserData
    //{
    //	public UserData()
    //	{
    //	}
    //}

    public class CreateUser
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }

    public class UpdateUser : CreateUser
    {
        public int Id { get; set; }
    }

    public class UserStatus
    {
        public int Id { get; set; }
    }

    public class ReadUser : CreateUser
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool? IsActive { get; set; }
    }
}


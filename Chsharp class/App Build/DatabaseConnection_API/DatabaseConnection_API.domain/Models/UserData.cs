using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection_API.domain.Models
{
    public class CreateUser
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
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
            public DateTime? DateCreated { get; set; }
            public DateTime? DateModified { get; set; }
            public bool IsActive { get; set; }
        }
    
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection_api.domain.Models
{
    public class CreateUser
    {
        // strings can take null values by default. To ensure strings don't accept null entries, use
        // [Required] in the line preceeding the string
        [Required]
        public string UserName { get; set; }
        [Required]
        public string FirstName { get; set; }
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
    { public int Id { get; set; }
      public DateTime DateCreated { get; set; }
      public DateTime? DateModified { get; set; }  //The "?" means the DataModified column can accept null entries
      public char IsActive { get; set; }

    }

}

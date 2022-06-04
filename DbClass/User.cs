using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DbClass
{
    [Table("User")]
    public class User
    {
        [Key]
        public string UserId{ get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string PaypalNumber { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }
    }
}

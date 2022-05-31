using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DbClass
{
    [Table("Paypal")]
    public class Paypal
    {
        [Key]
        public string PPID { get; set; }

        public string PaypalNumber { get; set; }

        [ForeignKey("UserId")]
        public ICollection<User> UserId { get; set; } 
    }
}

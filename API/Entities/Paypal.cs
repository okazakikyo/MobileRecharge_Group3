using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    [Table("Paypal")]
    public class Paypal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string PPID { get; set; }

        public string PaypalNumber { get; set; }

        [ForeignKey("UserId")]
        public ICollection<User> UserId { get; set; }
    }
}

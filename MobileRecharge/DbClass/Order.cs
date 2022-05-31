using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DbClass
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public string OrderId { get; set; }

        public DateTime Date { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("PPID")]
        public ICollection<Paypal> PPID { get; set; }

        [ForeignKey("UserId")]
        public ICollection<User> UserId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string OrderId { get; set; }

        public DateTime Date { get; set; }

        public decimal Price { get; set; }

        public ICollection<OrderDetail> DetailID { get; set; }

        [ForeignKey("PPID")]
        public Paypal PPID { get; set; }

        [ForeignKey("UserId")]
        public User UserId { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DbClass
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ChargeId")]
        public ICollection<ChargeList> ChargeId { get; set; }

        [ForeignKey("PostId")]
        public ICollection<PostPaid> PostId { get; set; }

        [ForeignKey("OrderId")]
        public ICollection<Order> OrderId { get; set; }
    }
}

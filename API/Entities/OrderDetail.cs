using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("ChargeId")]
        public ChargeList ChargeId { get; set; }

        [ForeignKey("PostId")]
        public PostPaid PostId { get; set; }

        [ForeignKey("OrderId")]
        public Order OrderId { get; set; }
    }
}

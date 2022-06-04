using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    [Table("PostPaid")]
    public class PostPaid
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostId { get; set; }

        public string Code { get; set; }

        public string CallTime { get; set; }

        public string Data { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("UserId")]
        public User UserId { get; set; }
    }
}

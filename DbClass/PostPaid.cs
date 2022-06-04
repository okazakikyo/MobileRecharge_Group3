using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DbClass
{
    [Table("PostPaid")]
    public class PostPaid
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostId{ get; set; }

        public string Code { get; set; }

        public string CallTime { get; set; }

        public string Data { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("UserId")]
        public ICollection<User> UserId { get; set; }
    }
}

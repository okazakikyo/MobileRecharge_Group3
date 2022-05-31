using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DbClass
{
    [Table("Feedback")]
    public class Feedback
    {
        [Key]
        public int FeedId { get; set; }

        public string Vote { get; set; }

        public string Description { get; set; }

        [ForeignKey("UserId")]
        public ICollection<User> UserId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
        [Table("Feedback")]
        public class Feedback
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int FeedId { get; set; }

            public string Vote { get; set; }

            public string Description { get; set; }

            [ForeignKey("UserId")]
            public User UserId { get; set; }
        }
}

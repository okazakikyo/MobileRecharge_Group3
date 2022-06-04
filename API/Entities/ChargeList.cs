using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    [Table("ChargeList")]
    public class ChargeList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ChargeId { get; set; }

        public string Title { get; set; }

        public string CallTime { get; set; }

        public string Data { get; set; }

        public string Durations { get; set; }

        public string Target { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Repair.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "ntext")]
        public string Content { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public DateTime date { get; set; }
        [MaxLength(250)]
        public string Subject { get; set; }
    }
}

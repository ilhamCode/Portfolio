using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Repair.Models
{
    public class Servie
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Title { get; set; }
        [Column(TypeName = "ntext")]
        public string Content { get; set; }
        [MaxLength(250)]
        public string CoverImage { get; set; }
        public DateTime Date { get; set; }
        public int ViewCount { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public ICollection<CategoryToBlog> CategoryToBlogs { get; set; }


    }
}

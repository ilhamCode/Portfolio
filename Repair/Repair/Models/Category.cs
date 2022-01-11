using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Repair.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Subtitle { get; set; }
        public ICollection<CategoryToBlog> CategoryToBlogs { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Repair.Models
{
    public class CategoryToBlog
    {
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int BlogId { get; set; }
        public Servie Blog { get; set; }

    }
}

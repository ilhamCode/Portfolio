using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Repair.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Location { get; set; }
        [MaxLength(250)]
        public string Sublocation { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }
        [MaxLength(250)]
        public string WorkTime { get; set; }
        [MaxLength(250)]
        public string Email { get; set; }
    }
}

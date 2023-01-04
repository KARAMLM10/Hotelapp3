using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Data
{
    public class Guest
    {
        [Key]
        public int GuestId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Lastname { get; set; }
        [Range(15, 100)]
        public int Age { get; set; }
    }
}

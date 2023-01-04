using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Data
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        [Required]
        [MaxLength(100)]
        public string type { get; set; }
        [Required]
        //[Range(20, 40)]
        public string beds { get; set; }
        
    }
}

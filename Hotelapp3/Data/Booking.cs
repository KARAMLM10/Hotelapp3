using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Data
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        public Room Room { get; set; }
        public int RoomId { get; set; }
      
        public Guest Guest { get; set; }
        public int GuestId { get; set; }
        [Required]
        public DateTime DateStart { get; set; }
        [Required]
        public DateTime DateEnd { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Data
{
    public class Booking
    {
        public int Id { get; set; }

        public Room Room { get; set; }
        public int RoomId { get; set; }
      
        public Guest Guest { get; set; }
        public int GuestId { get; set; }
 
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

    }
}

using Hotelapp3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Controller.Bookings
{
    public class ReadBooking : Interface
    {
        public ApplicationDBContext dbContext { get; set; }
        public ReadBooking(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("här är alla bookningar");
            //foreach (var guest in dbContext.Guest.OrderBy(g => g.Name))
            //{
            //    Console.WriteLine(guest.Name);
            //    Console.WriteLine(guest.Id);
            //    //Console.WriteLine(guest.Lastname);
            //    //Console.WriteLine(guest.Age);
            //}

            foreach (var bok in dbContext.Booking.OrderBy(x => x.Id))
            {
                var guest = dbContext.Guest.FirstOrDefault(x => x.Id.Equals(bok.GuestId));
                var room = dbContext.Room.FirstOrDefault(x => x.Id.Equals(bok.RoomId));
                Console.WriteLine($"\t {bok.DateStart} \t {bok.DateEnd} \t{bok.GuestId} "
                   + $"\t{bok.RoomId} \t{guest.Name} \t{room.type} "); 
            }
            //foreach (var guest in dbContext.Guest.OrderBy(x => x.Id))
            //{
            //    Console.WriteLine($"{guest.Id} \t {guest.Name} \t{guest.Lastname} \r{guest.Age}");
            //}


        }

    }
}

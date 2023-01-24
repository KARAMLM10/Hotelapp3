using Hotelapp3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Controller.Bookings
{
    public class ReadBooking : Interfaces
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

            foreach (var bok in dbContext.Booking.OrderBy(x => x.BookingId))
            {
                var guest = dbContext.Guest.FirstOrDefault(x => x.GuestId.Equals(bok.GuestId));
                var room = dbContext.Room.FirstOrDefault(x => x.RoomId.Equals(bok.RoomId));
                Console.WriteLine($"  \nBooking ID \t{bok.BookingId} \n Booking Date Start \t {bok.DateStart} \n Booking Date End \t {bok.DateEnd} \n Booking Guest ID \t{bok.GuestId} "
                   + $" \n Booking Room ID \t{bok.RoomId} \n Guest Name \t{guest.Name} \n Room Type \t{room.type} "); 
            }
            Console.WriteLine("press any key to countino");
            Console.ReadLine();
            //var num = Convert.ToInt32(Console.ReadLine());
            //if (num == 0)
            //{
            //    return;
            //}
            //else if (num == 9)
            //{
            //    Console.WriteLine(Mainmenu.ShowMenu());
            //}
            //foreach (var guest in dbContext.Guest.OrderBy(x => x.Id))
            //{
            //    Console.WriteLine($"{guest.Id} \t {guest.Name} \t{guest.Lastname} \r{guest.Age}");
            //}


        }

    }
}

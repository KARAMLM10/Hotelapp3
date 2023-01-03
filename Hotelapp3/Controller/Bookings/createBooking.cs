using Hotelapp3.Controller.Room;
using Hotelapp3.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Controller.Bookings
{
    public class createBooking : Interface
    {
        public ApplicationDBContext dbContext { get; set; }
        public createBooking(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {

            // var bookingToCreate = new Booking();

            // Console.Clear();
            // Console.WriteLine(" How many days would you like to booking the Room?");
            // int numberOfDays = Convert.ToInt32(Console.ReadLine());
            // bookingToCreate.DateStart = new DateTime();
            // while (bookingToCreate.DateStart > DateTime.Now.Date)
            // {
            //     Console.WriteLine("\n From which date would you like your booking to start from? (yyyy-mm-dd)");
            //     bookingToCreate.DateStart = Convert.ToDateTime(Console.ReadLine());
            // }

            // if (numberOfDays == 1) bookingToCreate.DateEnd = bookingToCreate.DateStart;
            // else if (numberOfDays > 1) bookingToCreate.DateEnd = bookingToCreate.DateStart.AddDays(numberOfDays);

            // List<DateTime> newBookingAllDates = new List<DateTime>();
            // for (var dt = bookingToCreate.DateStart; dt <= bookingToCreate.DateEnd; dt = dt.AddDays(1))
            // {
            //     newBookingAllDates.Add(dt);
            // }


            // Console.WriteLine("vilken rum vill du boka?");
            // Console.WriteLine("=====================");
            // Console.WriteLine("här är alla Rooms");
            // foreach (var room in dbContext.Room.OrderBy(r => r.type))
            // {
            //     Console.WriteLine($"{room.Id} \t{room.Area} \t{room.type}");
            // }
            // Console.WriteLine("Ange room type: ");
            // var typeInput = Console.ReadLine();
            // Console.WriteLine("Ange Area: ");
            // var areaInput = Console.ReadLine();

            // dbContext.Room.Add(new Data.Room
            // {
            //     // Id = idInput
            //     type = typeInput,
            //     Area = areaInput

            // });
            // //dbContext.SaveChanges();
            // Console.Clear();
            // Console.WriteLine(" Your booking details");
            // Console.WriteLine(" ==================================================================");
            // Console.WriteLine(" Start\t\tEnd\t\tNo. of days");
            // Console.WriteLine($" {bookingToCreate.DateStart.ToShortDateString()}\t{bookingToCreate.DateEnd.ToShortDateString()}\t{numberOfDays} \t{typeInput} \t{areaInput}");

            // // dbContext.Add(bookingToCreate);
            // //dbContext.SaveChanges();
            //// Console.ForegroundColor = ConsoleColor.Green;
            // Console.Clear();
            // Console.WriteLine(" Booking successful!");
            // Console.WriteLine(" ==============================================================================");


            // Console.WriteLine(" Start\t\tEnd\t\tNo. of days");
            // List<ReadRoom> availableRooms = new List<ReadRoom>();

            //foreach (var room in dbContext.Room.ToList())
            //{
            //    bool roomIsFree = true;
            //    foreach (var boking in dbContext.Booking.Include(b => b.RoomBooking).Where(b => b.RoomBooking == room))
            //    {
            //        for (var dt = boking.DateStart; dt <= boking.DateEnd; dt = dt.AddDays(1))
            //        {
            //            if (newBookingAllDates.Contains(dt))
            //            {
            //                roomIsFree = true;

            //            }
            //        }

            //        // if the car is already booked on the date of the new booking...
            //        // we dont need to check any of the other bookings... the car isnt available
            //        // so we break out of the loop and check the next car
            //        if (!roomIsFree)
            //        {
            //            break;
            //        }
            //    }


            // finally if the car is free we can add it to our list of available cars
            //if (roomIsFree)
            //{
            //    availableRooms.Add(room);
            //}
            // }

            //Console.Clear();
            //Console.WriteLine(" Your booking details");
            //Console.WriteLine(" ==================================================================");
            //Console.WriteLine(" Start\t\tEnd\t\tNo. of days");
            //Console.WriteLine($" {bookingToCreate.DateStart.ToShortDateString()}\t{bookingToCreate.DateEnd.ToShortDateString()}\t{numberOfDays}");

            //if (availableRooms.Count() < 1)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("\n\n There are no rooms available for these dates. Please try another date");
            //    Console.ForegroundColor = ConsoleColor.Gray;

            //    Console.WriteLine(" Press any key to continue");
            //    Console.ReadLine();
            //    return; // end method
            //}
            //else
            //{
            //    // Display the available cars
            //    Console.WriteLine("\n\n\n These rooms are available for booking");
            //    Console.WriteLine("\n id\ttype\t\tAre");
            //    Console.WriteLine(" ==================================================================");

            //    foreach (var room in availableRooms.OrderBy(r => r.id))
            //    {
            //        Console.WriteLine($" {room.id}\t");
            //        Console.WriteLine(" ------------------------------------------------------------------");
            //    }
            //}

            //Console.WriteLine("\n Please choose a room (id) from the available rooms");
            //string roomidBooking = Console.ReadLine();
            //bookingToCreate.RoomBooking = dbContext.Room
            //    .Where(c => c.id == roomidForBooking)
            //    .FirstOrDefault();

            //dbContext.Add(bookingToCreate);
            //dbContext.SaveChanges();
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.Clear();




            //Console.WriteLine("Ange namn: ");
            //var nameInput = Console.ReadLine();
            //Console.WriteLine("Ange efternamn: ");
            //var LastnameInput = Console.ReadLine();

            //Console.WriteLine("Ange ålder: ");
            //var ageInput = Convert.ToInt32(Console.ReadLine());

            //dbContext.Guest.Add(new Data.Guest
            //{
            //    Name = nameInput,
            //    Age = ageInput,
            //    Lastname = LastnameInput

            //});
            // dbContext.SaveChanges();

            Console.WriteLine("vilken rum vill du boka?");
            Console.WriteLine("=====================");
            Console.WriteLine("här är alla Rooms");
            foreach (var room in dbContext.Room.OrderBy(r => r.Id))
            {
                Console.WriteLine($"{room.Id} \t{room.Area} \t{room.type}");
            }
            Console.WriteLine("Ange id: ");
            var roomid = Convert.ToInt32( Console.ReadLine());
            Console.Clear();
            //Console.WriteLine("Ange type: ");
            //var TypeInput = Console.ReadLine();

            //dbContext.Room.Add(new Data.Room
            //{
            //    type = typeInput,
            //    Area = areaInput

            //});
            //dbContext.SaveChanges();

            Console.WriteLine("här är alla Guests");
            foreach (var guest in dbContext.Guest.OrderBy(x => x.Id))
            {
                Console.WriteLine($"{guest.Id} \t {guest.Name} \t{guest.Lastname} \r{guest.Age}");
            }
            Console.WriteLine("ange guest id");
            var guestid = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("ange guest name");
            //var guestname= Console.ReadLine();
           Console.Clear();
            Console.WriteLine(" How many days would you like to book the room?");
            int numberOfDays = Convert.ToInt32(Console.ReadLine());

            Console.Write("Mata in start datum yyyy-MM-dd: ");
            var DateStart1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(DateStart1);

            Console.Write("Mata in slut datum yyyy-MM-dd: ");
            var DateEnd2 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(DateEnd2);
            Console.Clear() ;

            //var booking = new Booking();
            //booking.Guest = guestid;
            
            dbContext.Booking.Add(new Data.Booking
            {
               RoomId = roomid,
               GuestId = guestid,
                DateStart = DateStart1,
                DateEnd = DateEnd2

            });
            dbContext.SaveChanges();


            //Console.WriteLine("vill du forsätta tryck på (0) om inte tryck på (9)");
            //var num = Convert.ToInt32(Console.ReadLine());
            //if (num == 0)
            //{
            //    return;
            //}
            //else if (num == 9)
            //{
            //    Console.WriteLine(Mainmenu.ShowMenu());
            //}



            //var createBooking = new Data.Booking();

            //Console.Clear();
            //Console.WriteLine("How many nights are you staying?: ");
            //int nights = Convert.ToInt32(Console.ReadLine());

            //createBooking.DateStart = new DateTime(2001, 01, 01, 23, 59, 59);

            //while (createBooking.DateStart > DateTime.Now.Date)
            //{
            //    Console.WriteLine("\n Type in your arrival date: ");
            //    createBooking.DateStart = Convert.ToDateTime(Console.ReadLine());
            //}

            //if (nights == 1) createBooking.DateEnd = createBooking.DateStart;
            //else if (nights > 1) createBooking.DateEnd = createBooking.DateStart.AddDays(nights);


            //List<DateTime> allDatesForBooking = new List<DateTime>();
            //for (var dateTime = createBooking.DateStart; dateTime <= createBooking.DateEnd; dateTime = dateTime.AddDays(1))
            //{
            //    allDatesForBooking.Add(dateTime);
            //}

            //List<Data.Room> availability = new List<Data.Room>();

            //foreach (var rooms in dbContext.Room.ToList())
            //{
            //    bool freeRoom = true;
            //    foreach (var booking in dbContext.Booking.OrderBy(b => b.RoomBooking).Where(b => b.RoomBooking == rooms))
            //    {
            //        for (var dateTime = booking.DateStart; dateTime <= booking.DateEnd; dateTime = dateTime.AddDays(1))
            //        {
            //            if (allDatesForBooking.Contains(dateTime)) freeRoom = false;
            //        }
            //        if (!freeRoom) break;
            //    }

            //    if (freeRoom) availability.Add(rooms);

            //}
            //dbContext.Add(createBooking);
            //dbContext.SaveChanges();

        }

    }
}

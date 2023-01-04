using Hotelapp3.Controller.Guest;
using Hotelapp3.Controller.Bookings;
using Hotelapp3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Controller.Bookings
{
    public class BookingMenu : Interfaces
    {

        public ApplicationDBContext dbContext { get; set; }
        public BookingMenu(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {


            var appbuilder = new appbuilder();
            var DbContext = appbuilder.appBuilder();
            // bool Main = true;
            while (true)
            {
                Console.WriteLine("1- Booka ett Rum");
                Console.WriteLine("2- read all bokings");
                var sel = Convert.ToInt32(Console.ReadLine());
                switch (sel)
                {
                    case 1:
                        var action = new createBooking(DbContext);
                        action.Run();
                        break;


                    case 2:
                        var action2 = new ReadBooking(DbContext);
                        action2.Run();

                        break;
                }
                break;
            }
            //List<Interfaces> actions = new List<Interfaces>();

            //var c = new createBooking(DbContext);
            //var r = new ReadBooking(DbContext);
            //actions.Add(c);
            //actions.Add(r);
        }

    }
}

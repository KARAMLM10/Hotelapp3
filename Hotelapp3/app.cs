using Hotelapp3.Controller;
using Hotelapp3.Controller.Bookings;
using Hotelapp3.Controller.Guest;
using Hotelapp3.Controller.Room;
using Hotelapp3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Hotelapp3
{
    public class app
    {
        public void Run()
        {

            var appbuilder = new appbuilder();
            var DbContext = appbuilder.appBuilder();
           // bool Main = true;
            while (true)
            {
                var sel = Mainmenu.ShowMenu();

                switch (sel)
                {
                    case 1:
                        var action1 = new GuestMenu(DbContext);
                        action1.Run();
                        break;
                    case 2:
                        var action2 = new BookingMenu(DbContext);
                        action2.Run();
                        break;
                    case 3:
                        var action3 = new RoomMenu(DbContext);
                        action3.Run();
                        break;
                    
                   
                    default:
                        break;
                }
                
            }
           


        }
    }
}

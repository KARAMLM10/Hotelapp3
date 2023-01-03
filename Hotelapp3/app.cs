using Hotelapp3.Controller;
using Hotelapp3.Controller.Guest;
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
                        var action = new GuestMenu(DbContext);
                        action.Run();
                        break;
                    case 2:
                        var action1 = new BookingMenu(DbContext);
                        action1.Run();
                        break;
                    case 3:
                        var action3 = new RoomMenu(DbContext);
                        action3.Run();
                        break;
                    //case 4:
                    //var action4 = new DeletGuest(DbContext);
                    //action4.Run();
                    //break;
                    case 0:
                        break;
                    default:
                        break;
                }
                break;
            }
           


        }
    }
}

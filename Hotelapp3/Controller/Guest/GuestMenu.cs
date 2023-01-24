using Hotelapp3.Controller.Guest;
using Hotelapp3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Controller.Guest
{
    public class GuestMenu : Interfaces
    {
        public ApplicationDBContext dbContext { get; set; }
        public GuestMenu(ApplicationDBContext context)
        {
            dbContext = context;
        }


        public void Run()
        {

            var appbuilder = new appbuilder();
            var DbContext = appbuilder.appBuilder();
            //bool Main = true;
            while (true)

            {
                Console.Clear();
                Console.WriteLine("Guest Menu Site");
                Console.WriteLine("=====================");
                Console.WriteLine("1. Create new Guest");
                Console.WriteLine("2. Read all Guests");
                Console.WriteLine("3. Update Guest");
                Console.WriteLine("4. Delete Guest");

                var sel = Convert.ToInt32(Console.ReadLine());

                switch (sel)
                {
                    case 1:
                        var action = new createGuest(DbContext);
                        action.Run();
                        break;
                    case 2:
                        var action1 = new ReadGuest(DbContext);
                        action1.Run();
                        break;
                    case 3:
                        var action3 = new UpdateGuest(DbContext);
                        action3.Run();
                        break;
                    case 4:
                        var action4 = new DeletGuest(DbContext);
                        action4.Run();
                        break;
                    default:
                        break;
                }
                break;
            }
            //List<Interfaces> actions = new List<Interfaces>();

            //var c = new createGuest(DbContext);
            //var r = new ReadGuest(DbContext);
            //var u = new UpdateGuest(DbContext);
            //var d = new DeletGuest(DbContext);

            //actions.Add(c);
            //actions.Add(r);
            //actions.Add(u);
            //actions.Add(d);




        }

    }
}

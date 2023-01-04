using Hotelapp3.Controller.Guest;
using Hotelapp3.Controller.Room;
using Hotelapp3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Controller.Room
{
    public class RoomMenu : Interfaces
    {
        public ApplicationDBContext dbContext { get; set; }
        public RoomMenu(ApplicationDBContext context)
        {
            dbContext = context;
        }

        public void Run()
        {
            var appbuilder = new appbuilder();
            var DbContext = appbuilder.appBuilder();
            //  bool Main = true;
            while (true)
            {
                Console.WriteLine("1. skapa ny room");
                Console.WriteLine("2. Read all Rooms");
                Console.WriteLine("4. Delete en room");
                Console.WriteLine("3. Update en room");
                Console.WriteLine("7. gå till mainmenu");
                var sel = Convert.ToInt32(Console.ReadLine());

                switch (sel)
                {
                    case 1:
                        var action1 = new createRoom(DbContext);
                        action1.Run();
                        break;
                    case 2:
                        var action2 = new ReadRoom(DbContext);
                        action2.Run();
                        break;
                    case 3:
                        var action3 = new UpdateRoom(DbContext);
                        action3.Run();
                        break;
                    case 4:
                        var action4 = new DeletRoom(DbContext);
                        action4.Run();
                        break;

                    default:
                        break;
                }
                break;
            }
            //List<Interfaces> actions = new List<Interfaces>();

            //var c = new createRoom(DbContext);
            //var r = new ReadRoom(DbContext);
            //var u = new UpdateRoom(DbContext);
            //var d = new DeletRoom(DbContext);

            //actions.Add(c);
            //actions.Add(r);
            //actions.Add(u);
            //actions.Add(d);
        }

    }
}

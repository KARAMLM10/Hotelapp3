using Hotelapp3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Controller.Room
{
    public class UpdateRoom : Interfaces
    {
        public ApplicationDBContext dbContext { get; set; }
        public UpdateRoom(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            Console.Clear();

            Console.WriteLine("ändra befintlig room");
            foreach (var room in dbContext.Room)
            {
                Console.WriteLine($"id: {room.Id}");
                //Console.WriteLine($"Area: {room.Area}");
                Console.WriteLine("====================");
            }
            Console.WriteLine("Välj Id på den room som du vill uppdatera");
            var roomIdToUpdate = Convert.ToInt32(Console.ReadLine());
            var roomToUpdate = dbContext.Room.First(p => p.Id == roomIdToUpdate);
            Console.Clear();
            Console.WriteLine("Ange nya type: ");
            var typeUpdate = Console.ReadLine();

            Console.WriteLine("Ange nya beds: ");
            var areaUpdate = Console.ReadLine();

            roomToUpdate.type = typeUpdate;
            roomToUpdate.beds = areaUpdate;
            dbContext.SaveChanges();
            //Console.WriteLine("vill du forsätta i Room menu tryck på (0) om inte tryck på (9)");
            //var num = Convert.ToInt32(Console.ReadLine());
            //if (num == 0)
            //{
            //    return;
            //}
            //else if (num == 9)
            //{
            //    Console.WriteLine(Mainmenu.ShowMenu());
            //}
            Console.WriteLine("press any key to continho");
            Console.ReadLine();


        }

    }
}

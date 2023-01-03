using Hotelapp3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Controller.Room
{
    public class DeletRoom : Interface
    {
        public ApplicationDBContext dbContext { get; set; }
        public DeletRoom(ApplicationDBContext context)
        {
            dbContext = context;
        }

        public void Run()
        {
            Console.Clear();

            Console.WriteLine("Ta bort Ett Room, vilken ?");
            foreach (var room in dbContext.Room)
            {
                Console.WriteLine($"type: {room.type}");
                Console.WriteLine($"Area: {room.Area}");
                Console.WriteLine("====================");

            }

            Console.WriteLine("Välj Id på det room som du vill radera");
            var roomtypeToDelete = Console.ReadLine();
            var roomToDelete = dbContext.Room.First(p => p.type == roomtypeToDelete);
            dbContext.Room.Remove(roomToDelete);
            dbContext.SaveChanges();
            Console.WriteLine("vill du forsätta tryck på (0) om inte tryck på (9)");
            var num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                return;
            }
            else if (num == 9)
            {
                Console.WriteLine(Mainmenu.ShowMenu());
            }

        }
    }
}

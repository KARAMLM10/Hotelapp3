using Hotelapp3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Controller.Room
{
    public class DeletRoom : Interfaces
    {
        public ApplicationDBContext dbContext { get; set; }
        public DeletRoom(ApplicationDBContext context)
        {
            dbContext = context;
        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Delet Room");
            Console.WriteLine("===================");
            Console.WriteLine("Ta bort Ett Room, vilken ?");
            foreach (var room in dbContext.Room)
            {
                Console.WriteLine($"Room ID: {room.RoomId}");
                Console.WriteLine($"Room type: {room.type}");
                Console.WriteLine($"Room beds: {room.beds}");
                Console.WriteLine("====================");
            }

            Console.WriteLine("Välj ID på det Rum du vill radera");
            var roomidToDelete = Convert.ToInt32( Console.ReadLine());
            var roomToDelete = dbContext.Room.First(p => p.RoomId == roomidToDelete);
            dbContext.Room.Remove(roomToDelete);
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

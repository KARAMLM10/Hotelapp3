using Hotelapp3.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Controller.Room
{
    public class ReadRoom : Interfaces
    {
        //internal object id;

        public ApplicationDBContext dbContext { get; set; }
        public ReadRoom(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            Console.Clear();
            
            Console.WriteLine("här är alla Rooms");
            foreach (var room in dbContext.Room.OrderBy(r => r.type))
            {
                Console.WriteLine($"{room.Id} \t{room.beds} \t{room.type}");
                

            }
                //Console.WriteLine("vill du forsätta i Room menu tryck på (0) om inte tryck på (9)");
                //var num = Convert.ToInt32(Console.ReadLine());
                //if (num == 0)
                //{
                //    return;
                //}
                //else if (n == 9)
                //{
                //    Console.WriteLine(Mainmenu.ShowMenu());
                //}
                Console.WriteLine("press any key to go to mainmenu");
                Console.ReadLine();

            
        }
    }
}

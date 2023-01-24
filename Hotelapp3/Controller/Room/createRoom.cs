using Hotelapp3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Controller.Room
{
    public class createRoom : Interfaces
    {
        public ApplicationDBContext dbContext { get; set; }
        public createRoom(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("1- CREATE en ny Room");
            Console.WriteLine("=====================");
            Console.WriteLine("Ange type Namn: ");
            var typeInput = Console.ReadLine();
            Console.WriteLine("Ange antal Sängar: ");
            var areaInput = Console.ReadLine();

            dbContext.Room.Add(new Data.Room
            {
                type = typeInput,
                beds = areaInput
                
            });
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

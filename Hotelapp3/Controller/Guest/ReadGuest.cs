using Hotelapp3.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Controller.Guest
{
    public class ReadGuest : Interface
    {
        public ApplicationDBContext dbContext { get; set; }
        public ReadGuest(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("här är alla Guests");
            //foreach(var guest in dbContext.Guest.Include(g=>g.Name))
            //{
            //    Console.WriteLine(guest.Name);
            //    Console.WriteLine(guest.Id);
            //    Console.WriteLine(guest.Lastname);
            //    Console.WriteLine(guest.Age);
            //}
            foreach(var guest in dbContext.Guest.OrderBy(x => x.Id))
            {
                Console.WriteLine($"{guest.Id} \t {guest.Name} \t{guest.Lastname} \r{guest.Age}");
            }

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

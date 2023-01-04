using Hotelapp3.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Controller.Guest
{
    public class ReadGuest : Interfaces
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
            foreach(var guest in dbContext.Guest.OrderBy(x => x.GuestId))
            {
                Console.WriteLine($"{guest.GuestId} \t {guest.Name} \t{guest.Lastname} \r{guest.Age}");
            }

            //Console.WriteLine("vill du forsätta i guest menu tryck på (0) om inte tryck på (9)");
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

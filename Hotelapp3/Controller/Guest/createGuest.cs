using Hotelapp3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Controller.Guest
{
    public class createGuest : Interface
    {
        public ApplicationDBContext dbContext { get; set; }
        public createGuest(ApplicationDBContext context)
        {
            dbContext = context;
        }
    
    
        public void Run()
        {
            //Console.WriteLine("vad vill du göra?");

            Console.WriteLine("1- CREATE en ny person");
            Console.WriteLine("=====================");
             Console.WriteLine("Ange namn: ");
             var nameInput = Console.ReadLine();
            Console.WriteLine("Ange efternamn: ");
            var LastnameInput = Console.ReadLine();

            Console.WriteLine("Ange ålder: ");
             var ageInput = Convert.ToInt32(Console.ReadLine());
           
            
            
            
            dbContext.Guest.Add(new Data.Guest
            {
                Name = nameInput,
                Age = ageInput,
               Lastname = LastnameInput

            });
            dbContext.SaveChanges();

            Console.WriteLine("vill du forsätta tryck på (0) om inte tryck på (9)");
            var num = Convert.ToInt32(Console.ReadLine());
            if(num == 0)
            {
             return;
            }
            else if(num == 9)
            {
                Console.WriteLine(Mainmenu.ShowMenu());
            }

        }
    }
}

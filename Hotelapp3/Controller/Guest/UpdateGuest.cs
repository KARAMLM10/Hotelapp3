using Hotelapp3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Controller.Guest
{
    public class UpdateGuest : Interfaces
    {
        public ApplicationDBContext dbContext { get; set; }
        public UpdateGuest(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Guest Update Site");
            Console.WriteLine("======================");
            Console.WriteLine("Ändra befintlig person");
            foreach (var person in dbContext.Guest)
            {
                Console.WriteLine($"Guest ID: {person.GuestId}");
                Console.WriteLine($"Guest Namn: {person.Name}");
                Console.WriteLine($"Guest Last Name {person.Lastname}");
                Console.WriteLine($"Guest Age {person.Age}");
                Console.WriteLine("====================");
            }

            Console.WriteLine("Välj ID på den Person du vill uppdatera");
            var personIdToUpdate = Convert.ToInt32(Console.ReadLine());
            var personToUpdate = dbContext.Guest.First(p => p.GuestId == personIdToUpdate);
            Console.Clear();

            Console.WriteLine("Ange den nya namn: ");
            var nameUpdate = Console.ReadLine();

            Console.WriteLine("Ange den nya efternamn: ");
            var lastnameUpdate = Console.ReadLine();

            Console.WriteLine("Ange den nya ålder: ");
            var ageUpdate = Convert.ToInt32(Console.ReadLine());


            personToUpdate.Age = ageUpdate;
            personToUpdate.Name = nameUpdate;
            personToUpdate.Lastname = lastnameUpdate;
            dbContext.SaveChanges();
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

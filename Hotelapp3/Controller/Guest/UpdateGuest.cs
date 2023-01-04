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

            Console.WriteLine("ändra befintlig person");
            foreach (var person in dbContext.Guest)
            {
                Console.WriteLine($"Id: {person.Id}");
                Console.WriteLine($"Namn: {person.Name}");
                Console.WriteLine("====================");
            }

            Console.WriteLine("Välj Id på den Person som du vill uppdatera");
            var personIdToUpdate = Convert.ToInt32(Console.ReadLine());
            var personToUpdate = dbContext.Guest.First(p => p.Id == personIdToUpdate);
            Console.Clear();

            Console.WriteLine("Ange nya namn: ");
            var nameUpdate = Console.ReadLine();

            Console.WriteLine("Ange nya Lastname: ");
            var lastnameUpdate = Console.ReadLine();

            Console.WriteLine("Ange nya Age: ");
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

using Hotelapp3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Controller.Guest
{
    public class DeletGuest : Interfaces
    {
        public ApplicationDBContext dbContext { get; set; }
        public DeletGuest(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            Console.Clear();

            Console.WriteLine("Ta bort en person, vilken ?");
            foreach (var person in dbContext.Guest)
            {
                Console.WriteLine($"Id: {person.Id}");
                Console.WriteLine($"Namn: {person.Name}");
                Console.WriteLine("====================");

            }

            Console.WriteLine("Välj Id på den Person som du vill radera");
            var personIdToDelete = Convert.ToInt32(Console.ReadLine());
            var personToDelete = dbContext.Guest.First(p => p.Id == personIdToDelete);
            dbContext.Guest.Remove(personToDelete);
            dbContext.SaveChanges();
            //Console.WriteLine("vill du forsätta i guest menu tryck på (0) om inte tryck på (9)");
            //var num = Convert.ToInt32(Console.ReadLine());
            //if (num == 0)
            //{
            //    return;
            //}
            //else if (num == 9)
            //{
            //    Console.Clear();
            //    Console.WriteLine(Mainmenu.ShowMenu());
            //}
            Console.WriteLine("press any key to continho");
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Controller
{
    public class Mainmenu
    {
        
            public static int ShowMenu()
            {
                Console.WriteLine("1:Guest");
                Console.WriteLine("2:Booking");
                Console.WriteLine("3:Room");
                
                Console.WriteLine("0: Exit");
              
                var sel = Convert.ToInt32(Console.ReadLine());
            
               return sel;
            }
        
    }
}

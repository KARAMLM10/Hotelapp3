﻿using Hotelapp3.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Controller.Room
{
    public class ReadRoom : Interface
    {
        internal object id;

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
                Console.WriteLine($"{room.Id} \t{room.Area} \t{room.type}");
                

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
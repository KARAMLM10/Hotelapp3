using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelapp3.Data
{
    public class DataInitializer
    {

        public void MigrateAndSeed(ApplicationDBContext dbContext)
        {
            dbContext.Database.Migrate();
            SeedRooms(dbContext);
            SeedGuests(dbContext);
            dbContext.SaveChanges();
        }
        private void SeedGuests(ApplicationDBContext dBContext)
        {
            if (!dBContext.Guest.Any(c => c.Name == "leo"))
            {
                dBContext.Guest.Add(new Guest
                {
                    Name = "leo",
                    Lastname = "messi",
                    Age = 34
                });
            }

            if (!dBContext.Guest.Any(c => c.Name == "angel"))
            {
                dBContext.Guest.Add(new Guest 
                {
                    Name="angel",
                    Lastname="di maria",
                    Age=28
                });
            }

            if (!dBContext.Guest.Any(c => c.Name == "David"))
            {
                dBContext.Guest.Add(new Guest
                {
                    Name="David",
                    Lastname="villa",
                    Age=24
                });
            }
            if (!dBContext.Guest.Any(c => c.Name == "julian"))
            {
                dBContext.Guest.Add(new Guest
                {
                    Name = "julian",
                    Lastname = "alvarez",
                    Age = 21
                });
            }

        }
        private void SeedRooms(ApplicationDBContext dBContext)
        {
            if (!dBContext.Room.Any(c => c.type == "Dubbelsäng1-area 30"))
            {
                dBContext.Room.Add(new Room
                {
                    type="Dubbelsäng1-area 30",
                    beds="2"
                });
            }

            if (!dBContext.Room.Any(c => c.type == "Dubbelsäng2-area37"))
            {
                dBContext.Room.Add(new Room
                {
                    type = "Dubbelsäng2-area37",
                    beds = "2"
                });
            }

            if (!dBContext.Room.Any(c => c.type == "singelsäng1-area20"))
            {
                dBContext.Room.Add(new Room
                {
                    type = "singelsäng1-area20",
                    beds = "1"
                });
            }

            if (!dBContext.Room.Any(c => c.type == "singelsäng2-area27"))
            {
                dBContext.Room.Add(new Room
                {
                    type = "singelsäng2-area27",
                    beds = "1"
                });
            }


        }

    }
}

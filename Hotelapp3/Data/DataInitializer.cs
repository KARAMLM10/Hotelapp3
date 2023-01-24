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
            if (!dBContext.Guest.Any(c => c.GuestId == 1))
            {
                dBContext.Guest.Add(new Guest
                {
                    Name = "leo",
                    Lastname = "messi",
                    Age = 34
                });
            }

            if (!dBContext.Guest.Any(c => c.GuestId == 2))
            {
                dBContext.Guest.Add(new Guest 
                {
                    Name="angel",
                    Lastname="di maria",
                    Age=28
                });
            }

            if (!dBContext.Guest.Any(c => c.GuestId == 3))
            {
                dBContext.Guest.Add(new Guest
                {
                    Name="David",
                    Lastname="villa",
                    Age=24
                });
            }
            if (!dBContext.Guest.Any(c => c.GuestId == 4))
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
            if (!dBContext.Room.Any(c => c.RoomId == 1))
            {
                dBContext.Room.Add(new Room
                {
                    type= "Double Beds (1) -area 30",
                    beds="2"
                });
            }

            if (!dBContext.Room.Any(c => c.RoomId == 2))
            {
                dBContext.Room.Add(new Room
                {
                    type = "Double Beds (2)-area 37",
                    beds = "2"
                });
            }

            if (!dBContext.Room.Any(c => c.RoomId == 3))
            {
                dBContext.Room.Add(new Room
                {
                    type = "Single Bed (1)-area 20",
                    beds = "1"
                });
            }

            if (!dBContext.Room.Any(c => c.RoomId == 4))
            {
                dBContext.Room.Add(new Room
                {
                    type = "Single Bed (2)-area 27",
                    beds = "1"
                });
            }


        }

    }
}

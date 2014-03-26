using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Blog.Models
{
    public class ClassRoom
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
    }

    public class ClassRoomDbContext : DbContext
    {
        public DbSet<ClassRoom> ClassRooms { get; set; }
    }
}
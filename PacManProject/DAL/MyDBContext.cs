using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManProject
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("PacManProject")
        {

        }

        public DbSet<WallsAndDots> WallsAndDots { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<Entity> Entities { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}

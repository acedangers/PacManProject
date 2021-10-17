using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManProject
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("DefaultConnection")
        {

        }

        public DbSet<MapObject> MapObjects { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<GameCharacter> GameCharacters { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}

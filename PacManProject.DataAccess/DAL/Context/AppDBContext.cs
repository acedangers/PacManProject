using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PacManProject.DataAccess.DAL.Models;


namespace PacManProject.DataAccess.DAL.Context
{
    public class AppDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appconfig.json", optional: false).Build();

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            }
        }

        public AppDBContext(DbContextOptions<AppDBContext> options ) : base(options)
        {

        }

        public DbSet<MapObject> MapObjects { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<GameCharacter> GameCharacters { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}

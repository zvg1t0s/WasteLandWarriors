using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WasteLandWarriors.Entities;
namespace WasteLandWarriors.Data
{
    public class GameModeContext : DbContext
    {
        public DbSet<User> Users;
        public DbSet<Constructions> Constructions;

        public GameModeContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("");
        }
    }
}

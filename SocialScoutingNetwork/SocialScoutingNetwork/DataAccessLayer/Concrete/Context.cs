using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=77.245.159.10\\MSSQLSERVER2019; Database=SocialScoutingNetwork;user=scoutingdb;password=123Aa!123");
            //optionsBuilder.UseSqlServer("Server=DESKTOP-K2JUCK9; Database=SocialScoutingNetwork;Integrated Security=True");
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contactt> Contacts { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}

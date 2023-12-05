using EFCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data
{
    public class FootballLeagueDbContext : DbContext
    //dotnet add package Microsoft.EntityFrameworkCore --version 7 FROM THIS FOLDER's COMMAND PROMPT
    //dotnet tool install --global dotnet-ef --version 7
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coaches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=FootballLeague_EFCore;Trusted_Connection=True;TrustServerCertificate=True").LogTo(Console.WriteLine, LogLevel.Information).EnableSensitiveDataLogging().EnableDetailedErrors();
        }

        //Needed only for Seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
                new Team
                {
                    Id = 1,
                    Name = "Tivoli Gardens F.C.",
                    DateCreated = DateTimeOffset.UtcNow.DateTime
                },
                    new Team
                    {
                        Id = 2,
                        Name = "Waterhouse F.C.",
                        DateCreated = DateTimeOffset.UtcNow.DateTime
                    },
                    new Team
                    {
                        Id = 3,
                        Name = "Humble Lions F.C.",
                        DateCreated = DateTimeOffset.UtcNow.DateTime
                    }
                ) ;

            //base.OnModelCreating(modelBuilder);
        }
    }
}

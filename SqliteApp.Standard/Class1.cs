using Microsoft.EntityFrameworkCore;
using System;
using XamarinApp;

namespace SqliteApp.Standard
{
   public class DatabaseContext: DbContext
    {
        public DbSet<Review> Reviews { get; set; }

        private readonly string _databasePath;

        public DatabaseContext(string databasePath)
        {
            _databasePath = databasePath;

            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_databasePath}");
        }
    }
}

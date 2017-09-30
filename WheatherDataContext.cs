using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WheatherToDatabaseConverter{

    public class WheatherDataContext : DbContext
    {
        public DbSet<WheatherModel> WheatherRecords { get; set; }
        public DbSet<RegionModel> Regions { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=WheatherData.db");
        }
    }
}
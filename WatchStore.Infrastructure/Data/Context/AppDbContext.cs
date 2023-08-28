using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchStore.Infrastructure.Data.Models;

namespace WatchStore.Infrastructure.Data.Context
{
    public class AppDbContext:DbContext
    {
       public DbSet<WristWatch>WristWatches { get; set; }
        public AppDbContext()
        {
                
        }
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) 
        {
                
        }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=DESKTOP-GF2KG8S\SQLEXPRESS;Initial Catalog=WristWatches; Trusted_Connection=True;Encrypt=False";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

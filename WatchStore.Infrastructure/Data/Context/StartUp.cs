using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchStore.Infrastructure.Data.Context
{
    public class StartUp
    {
        public void RegisterDbContext(IServiceCollection services)
        {
            var connectionString = @"Server=DESKTOP-GF2KG8S\SQLEXPRESS;Initial Catalog=WristWatches; Trusted_Connection=True;Encrypt=False";
            services.AddDbContext<AppDbContext>(op => op.UseSqlServer(connectionString));
        }
    }
}

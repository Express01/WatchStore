using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchStore.Infrastructure.Data.Context;
using WatchStore.Infrastructure.Data.Models;

namespace WatchStore.Infrastructure.Data.Repositories
{
    public class WatchRepository : IWatchesRepository
    {
        private readonly AppDbContext _appDbContext;
        public WatchRepository()
        {
                _appDbContext = new AppDbContext();
        }
        public async Task<List<WristWatch>> SearchAsync(string query)
        {
             return  await _appDbContext.WristWatches.Include(x=>x.Brend).Include(x=>x.Gender).Where(e=>EF.Functions.FreeText(e.Name,query)).ToListAsync();
        }
      
    }
}

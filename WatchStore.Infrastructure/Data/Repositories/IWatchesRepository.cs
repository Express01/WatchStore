using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchStore.Infrastructure.Data.Models;

namespace WatchStore.Infrastructure.Data.Repositories
{
    public interface IWatchesRepository
    {
        public Task<List<WristWatch>> SearchAsync(string brendOrGender);
    }
}

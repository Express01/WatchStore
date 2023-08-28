using WatchStore.Infrastructure.Data.Models;
using WatchStore.Infrastructure.Data.Repositories;
using WatchStore.Web.Models;

namespace WatchStore.Web.Services
{
    public class WristWatchService : IWristWatchService
    {
        private readonly IWatchesRepository _watchesRepository;
        public WristWatchService(IWatchesRepository watchesRepository)
        {
            _watchesRepository = watchesRepository;
        }
        public async Task<List<WristWatchViewModel>> GetAllByBrendOrGenderAsync(string query)
        {

            var dbModel = await _watchesRepository.SearchAsync(query);
            return dbModel.Select(x => new WristWatchViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Picture = x.Picture,
                Price = x.Price,
                BrendName = x.Brend.BrendName,
                Gender = x.Gender.GenderName
            }).ToList();



        }
    }
}

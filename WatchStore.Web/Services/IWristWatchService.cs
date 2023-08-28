using WatchStore.Web.Models;

namespace WatchStore.Web.Services
{
    public interface IWristWatchService
    {
        Task<List<WristWatchViewModel>> GetAllByBrendOrGenderAsync(string brendOrGender);
    }
}
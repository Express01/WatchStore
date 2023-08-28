using Microsoft.AspNetCore.Mvc;
using WatchStore.Web.Services;

namespace WatchStore.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly IWristWatchService _watchService;

        public SearchController(IWristWatchService watchService)
        {
            _watchService = watchService;
        }

        public async Task<IActionResult> Index(string query)
        {
            var watches= await _watchService.GetAllByBrendOrGenderAsync(query);
            return View("Index",watches);
        }
    }
}

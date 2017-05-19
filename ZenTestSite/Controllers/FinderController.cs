using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZenTestSite.Models.DataBase;
using ZenTestSite.Models;

namespace ZenTestSite.Controllers
{
    public class FinderController : BaseController
    {
        public FinderController(IItemsRepository itemsRepository) : base(itemsRepository)
        {

        }

        [HttpGet]
        public async Task<IActionResult> Find([FromQuery]int maxAge)
        {
            var finder = new Finder(_itemsRepository);
            var people = await finder.FindPeople(maxAge);
            ViewData["Title"] = "Find";
            return View("Table",people);
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var finder = new Finder(_itemsRepository);
            var people = await finder.All();
            ViewData["Title"] = "All Data";
            return View("Table", people);
        }
    }
}

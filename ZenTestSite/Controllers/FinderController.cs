using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZenTestSite.Models.DataBase;
using ZenTestSite.Models.DTO;
using ZenTestSite.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
            return View(people);
        }
    }
}

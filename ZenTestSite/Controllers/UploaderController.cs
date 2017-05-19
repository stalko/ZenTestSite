using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZenTestSite.Models.DTO;
using ZenTestSite.Models.DataBase;
using ZenTestSite.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ZenTestSite.Controllers
{
    public class UploaderController : BaseController
    {
        public UploaderController(IItemsRepository itemsRepository) : base(itemsRepository)
        {

        }

        [HttpPost]
        public async Task<IActionResult> FromUrl([FromBody]UploaderUrlDTO data)
        {
            UrlParser parser = new UrlParser(_itemsRepository);
            await parser.Execute(data.Url);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> FromText([FromBody]UploaderTextDTO data)
        {
            Parser parser = new Parser(_itemsRepository);
            await parser.Execute(data.Text);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> FromFile([FromBody]UploaderFileDTO data)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}

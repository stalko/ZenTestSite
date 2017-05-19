using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZenTestSite.Models.DTO;
using ZenTestSite.Models.DataBase;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ZenTestSite.Controllers
{
    public class UploaderController : Controller
    {
        private readonly IItemsRepository _todoRepository;

        public UploaderController(IItemsRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        [HttpPost]
        public IActionResult FromUrl([FromBody]UploaderUrlDTO data)
        {
            return View();
        }

        [HttpPost]
        public IActionResult FromText([FromBody]UploaderTextDTO data)
        {
            return View();
        }

        [HttpPost]
        public IActionResult FromFile([FromBody]UploaderFileDTO data)
        {
            return View();
        }
    }
}

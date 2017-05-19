using Microsoft.AspNetCore.Mvc;

namespace ZenTestSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
		}

		public IActionResult Uploader()
		{
			return View();
		}

        public IActionResult Error()
        {
            return View();
        }
    }
}

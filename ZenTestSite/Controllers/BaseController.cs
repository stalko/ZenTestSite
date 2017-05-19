using Microsoft.AspNetCore.Mvc;
using ZenTestSite.Models.DataBase;

namespace ZenTestSite.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IItemsRepository _itemsRepository;

        public BaseController(IItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

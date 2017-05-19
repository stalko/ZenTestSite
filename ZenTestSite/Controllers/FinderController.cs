using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZenTestSite.Models.DataBase;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ZenTestSite.Controllers
{
    public class FinderController : BaseController
    {
        public FinderController(IItemsRepository todoRepository) : base(todoRepository)
        {

        }
    }
}

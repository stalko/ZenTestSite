using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZenTestSite.Models.DTO;
using ZenTestSite.Models.DataBase;
using ZenTestSite.Models;
using System.IO;
using System.Diagnostics;

namespace ZenTestSite.Controllers
{
    public class UploaderController : BaseController
    {
        public UploaderController(IItemsRepository itemsRepository) : base(itemsRepository)
        {

        }

        [HttpPost]
        public async Task<IActionResult> FromText([FromBody]UploaderTextDTO data)
        {
            var parser = new Parser(_itemsRepository);
            await parser.Execute(data.Text);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> FromUrl([FromBody]UploaderUrlDTO data)
        {
            var parser = new UrlParser(_itemsRepository);
            await parser.Execute(data.Url);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> FromFile(UploaderFileDTO model)
        {
            var parser = new FileParser(_itemsRepository);
            if (model.File.Length > 0)
            {
                var filePath = Path.GetTempFileName();
                try
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await model.File.CopyToAsync(stream);
                    }
                    await parser.Execute(filePath);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                finally
                {
                    var fi = new FileInfo(filePath);
                    if (fi.Exists) fi.Delete();
                }
            }
            return RedirectToAction("Index", "Home");
        }
    }
}

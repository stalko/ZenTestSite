using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenTestSite.Models.DataBase;
using Newtonsoft.Json;
using ZenTestSite.Models.DTO;

namespace ZenTestSite.Models
{
    public class Parser
    {
        protected string Text { get; set; }
        private List<ItemsDTO> ListItems { get; set; }
        private IItemsRepository Repository { get; set; }

        public Parser(IItemsRepository rep)
        {
            Repository = rep;
        }

        protected async virtual Task GetText(string str)
        {
            Text = str;
        }

        protected virtual void Processing()
        {
            ListItems = JsonConvert.DeserializeObject<List<ItemsDTO>>(Text);
        }

        protected async Task SaveToDB()
        {
            var items = ListItems.Select(i => new Items() { Age = i.age, Name = i.name }).ToList();
            await Repository.AddRange(items);
        }

        public async Task Execute(string str)
        {
            await GetText(str);
            Processing();
            await SaveToDB();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenTestSite.Models.DataBase;
using ZenTestSite.Models.DTO;

namespace ZenTestSite.Models
{
    public class Finder
    {
        private IItemsRepository Repository { get; set; }

        public Finder(IItemsRepository rep)
        {
            Repository = rep;
        }

        public async Task<IEnumerable<SearchDTO>> FindPeople(int maxAge)
        {
            return await Repository.Find(maxAge);
        }
        public async Task<IEnumerable<SearchDTO>> All()
        {
            return await Repository.All();
        }
    }
}

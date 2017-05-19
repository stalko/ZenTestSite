using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenTestSite.Models.DTO;

namespace ZenTestSite.Models.DataBase
{
    public interface IItemsRepository
    {
        Task AddRange(List<Items> items);
        Task<IEnumerable<SearchDTO>> Find(int maxAge);
    }
}

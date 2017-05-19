using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenTestSite.Models.DTO;

namespace ZenTestSite.Models.DataBase
{
    public class ItemsRepository : IItemsRepository
    {
        private readonly ItemsContext _context;

        public ItemsRepository(ItemsContext context)
        {
            _context = context;
        }
        public async Task AddRange(List<Items> items)
        {
            await _context.Items.AddRangeAsync(items);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<SearchDTO>> Find(int maxAge)
        {
            return await _context.Items.Where(i => maxAge >= i.Age)
                .Select(i => new SearchDTO() { Age = i.Age, Name = i.Name }).ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZenTestSite.Models.DataBase
{
    public class ItemsRepository : IItemsRepository
    {
        private readonly ItemsContext _context;

        public ItemsRepository(ItemsContext context)
        {
            _context = context;

            if (_context.Items.Count() == 0)
                Add(new Items { Name = "Item1" });
        }

        public IEnumerable<Items> GetAll()
        {
            return _context.Items.ToList();
        }

        public void Add(Items item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
        }

        public Items Find(long key)
        {
            return _context.Items.FirstOrDefault(t => t.Key == key);
        }

        public void Remove(long key)
        {
            var entity = _context.Items.First(t => t.Key == key);
            _context.Items.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Items item)
        {
            _context.Items.Update(item);
            _context.SaveChanges();
        }
    }
}

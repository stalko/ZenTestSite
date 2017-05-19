﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZenTestSite.Models.DataBase
{
    public interface IItemsRepository
    {
        void AddRange(List<Items> items);
        IEnumerable<Items> GetAll();
        Items Find(long key);
        void Remove(long key);
        void Update(Items item);
    }
}

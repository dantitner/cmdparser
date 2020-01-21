using System;
using System.Collections.Generic;
using System.Text;
using UserContext.Models;

namespace UserContext.Interfaces
{
    interface IStorage
    {
        IEnumerable<Item> GetAll();
        bool TryFind(string itemName, int quantity);
        IEnumerable<Item> Find(Func<Item, Boolean> predicate);
        Item Find(string itemName);
        void Add(Item item);
        void Add(IEnumerable<Item> items);
        bool Delete(string itemName, int quantity);
    }
}

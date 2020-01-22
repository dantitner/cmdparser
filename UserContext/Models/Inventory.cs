using System;
using System.Collections.Generic;
using System.Text;
using UserContext.Interfaces;
using System.Linq;

namespace UserContext.Models
{
    public class Inventory : IStorage
    {
        public List<Item> Items { get; set; }

        public void Add(Item item)
        {
            if (TryFind(item.itemName, item.Quantity))
            {
                Find(item.itemName).Quantity += item.Quantity;
            }
            else
                Items.Add(item);
        }

        public void Add(IEnumerable<Item> items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }

        public bool Delete(string itemName, int quantity)
        {
            if (TryFind(itemName, quantity))
            {
                Find(itemName).Quantity -= quantity;
                return true;
            }
            else
                return false;
                
        }

        public IEnumerable<Item> Find(Func<Item, bool> predicate)
        {
            return Items.Where(predicate);
        }

        public Item Find(string itemName)
        {
            return Items.Find(n => n.itemName == itemName);
        }

        public IEnumerable<Item> GetAll()
        {
            return Items;
        }

        public bool TryFind(string itemName, int quantity)
        {
            bool result = false;
            foreach (var item in Items)
            {
                if (item.itemName == itemName)
                    if (item.Quantity >= quantity)
                        result = true;
            }
            return result;
        }
    }
}

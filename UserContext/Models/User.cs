using System;
using System.Collections.Generic;
using System.Text;

namespace UserContext.Models
{
    class User
    {
        public int Money { get; set; }
        public Inventory Innventory { get; set; }
        public List<Recipe> Recipes { get; set; }

    }
}

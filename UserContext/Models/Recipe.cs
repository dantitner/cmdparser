using System;
using System.Collections.Generic;
using System.Text;

namespace UserContext.Models
{
    public class Recipe
    {
        public List<RecipeRequiredItem> RequiredItems { get; set; }
        public Item ItemToCreate;
    }
}

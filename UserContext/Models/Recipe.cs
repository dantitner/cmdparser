using System;
using System.Collections.Generic;
using System.Text;

namespace UserContext.Models
{
    class Recipe
    {
        public List<RecipeRequiredItem> RequiredItems { get; set; }
        public Type ItemToCreate;
    }
}

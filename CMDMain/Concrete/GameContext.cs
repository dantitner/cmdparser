using System;
using System.Collections.Generic;
using System.Text;
using UserContext.Models;

namespace CMDMain.Concrete
{
    class GameContext
    {
        public User User { get; set; }
        public Dictionary<string,Recipe> Recipes { get; }

        public GameContext()
        {
            User = new User();
            Recipes = new Dictionary<string, Recipe>();
            Recipes.Add("torch", 
                new Recipe()
                {
                    ItemToCreate = new Item() {itemName = "Torch", Quantity = 4},
                    RequiredItems = new List<RecipeRequiredItem>()
                    {
                        new RecipeRequiredItem(){itemName = "Stick", Quantity = 1},
                        new RecipeRequiredItem(){ itemName = "Coal", Quantity = 1}
                    }
                });
        }

    }
}

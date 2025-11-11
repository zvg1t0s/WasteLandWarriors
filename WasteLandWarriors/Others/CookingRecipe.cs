using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.Others
{
    internal class CookingRecipe
    {
        public Loot[,] Items { get; private set; }
        public RecipeType recipeType;
        public Loot FinalLootItem;
        public string EngName;
        public static List<CookingRecipe> recipeList = new List<CookingRecipe>();
        public Loot[] itemsOrder;
        public CookingRecipe(Loot[,] items, RecipeType recipeType, Loot loot, string engName)
        {
            Items = items;
            this.recipeType = recipeType;
            FinalLootItem = loot;
            EngName = engName;
            itemsOrder = new Loot[Items.Length];
            for (int orderid = 0, i = 0; i < Items.GetLength(0); i++)
            {
                for (int j = 0; j < Items.GetLength(1); j++)
                {
                    itemsOrder[orderid++] = items[i, j];
                }
            }
        }
        public static void CreateRecipes()
        {
            
            recipeList.Add(new CookingRecipe(new Loot[,]
            {
                { Loot.loots.FirstOrDefault(l => l.Name == "Сырая рыба")},
            },RecipeType.Easy, Loot.loots.FirstOrDefault(l => l.Name == "Жареная рыба"), "fried_fish"));

        }
    }
    
}
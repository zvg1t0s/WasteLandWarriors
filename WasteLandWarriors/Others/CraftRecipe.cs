using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.Others
{
    internal class CraftRecipe
    {
        public Loot[,] Items { get;private set; }
        public RecipeType recipeType;
        public Loot FinalLootItem;
        public string EngName;
        public static List<CraftRecipe> recipeList = new List<CraftRecipe>();
        public Loot[] itemsOrder;
        public CraftRecipe(Loot[,] items, RecipeType recipeType, Loot loot, string engName)
        {
            Items = items;
            this.recipeType = recipeType;
            FinalLootItem = loot;
            EngName = engName;
            itemsOrder = new Loot[Items.Length];
            for (int orderid = 0, i = 0; i < Items.GetLength(0); i++) { 
                for(int j = 0;  j < Items.GetLength(1); j++)
                {
                    itemsOrder[orderid++] = items[i, j];
                }
            }
        }
        public static void CreateRecipes()
        {
            recipeList.Add(new CraftRecipe(new Loot[,]
            {
                {Loot.loots.FirstOrDefault(l => l.Name == "Металл") },
                {Loot.loots.FirstOrDefault(l => l.Name == "Металл") }
            }, RecipeType.Medium, Loot.loots.FirstOrDefault(l => l.Name == "Отмычка"),"LockPick"));

            recipeList.Add(new CraftRecipe(new Loot[,]
            {
                {Loot.loots.FirstOrDefault(l => l.Name == "Микросхема"), Loot.loots.FirstOrDefault(l => l.Name == "Микросхема"), Loot.loots.FirstOrDefault(l => l.Name == "Микросхема"),},
                {Loot.loots.FirstOrDefault(l => l.Name == "Радиозапчасть"), Loot.loots.FirstOrDefault(l => l.Name == "Радиозапчасть"), Loot.loots.FirstOrDefault(l => l.Name == "Радиозапчасть"),}
            },RecipeType.Extra, Loot.loots.FirstOrDefault(l => l.Name == "Ноутбук"), "Notebook"));

        }
    }
    public enum RecipeType
    {
        Easy = 0,
        Medium = 1,
        Hard = 2,
        Extra = 3,
        Legendary = 4,
    }
}

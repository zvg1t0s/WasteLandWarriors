using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.Others
{
    internal class Loot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool isUsable { get; set; }
        public int BotSellPrice { get; set; }
        public int SellPrice { get; set; }
        // 0-noloot 1-usableLoot 2-weapon 3-clothes 4-helmet 5-armour 6-backpack 7-weaponAmmo
        public int LootType { get; set; }
        public bool isDropable { get; set; }
        public int modelId { get; set; }
        public static List<Loot> loots = new List<Loot>();
        public Loot(int Id, string Name, string Description, int modelId, bool isUsable, int BotSellPrice, int SellPrice, int LootType, bool isDropable)
        {

            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.modelId = modelId;
            this.isUsable = isUsable;
            this.BotSellPrice = BotSellPrice;
            this.SellPrice = SellPrice;
            this.LootType = LootType;
            this.isDropable = isDropable;
        }
        public static void Create()
        {
            loots.Add(new Loot(0,"Яблоко зелёное","Вкусное яблоко", 19576,true,50,100,0,true));
            loots.Add(new Loot(1, "Яблоко красное", "Вкусное яблоко", 19575, true, 50, 100, 0, true));
        }
    }
}

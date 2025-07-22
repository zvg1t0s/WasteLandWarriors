using SampSharp.GameMode;
using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WasteLandWarriors.Display;
using WasteLandWarriors.WorldObjects;

namespace WasteLandWarriors.Others
{
    public enum LootType
    {
        None,
        Trash,
        Meal,
        Medical,
        Weapon,
        Expensive,
        
    }
    internal class Loot
    {
        public static int Idd = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool isUsable { get; set; }
        public int BotSellPrice { get; set; }
        public int SellPrice { get; set; }
        // 0-noloot 1-usableLoot 2-weapon 3-clothes 4-helmet 5-armour 6-backpack 7-weaponAmmo
        public LootType lootType { get; set; }
        public bool isDropable { get; set; }
        public int modelId { get; set; }
        public int previewModelId { get; }
        public int weight { get; }
        public float rotation { get; }
        public static List<Loot> loots = new List<Loot>();
        public Loot( string Name, string Description, int modelId, int previewmodelId, bool isUsable, int BotSellPrice, int SellPrice, LootType lootType, bool isDropable, int weight, float rotation)
        {
            Idd++;
            this.Id = Idd;
            this.Name = Name;
            this.Description = Description;
            this.modelId = modelId;
            this.previewModelId = previewmodelId;
            this.isUsable = isUsable;
            this.BotSellPrice = BotSellPrice;
            this.SellPrice = SellPrice;
            this.lootType = lootType;
            this.isDropable = isDropable;
            this.weight = weight;
            this.rotation = rotation;
        }
        public static void Create()
        {
            loots.Add(new Loot("Яблоко","Вкусное яблоко", 19576, 19576, true,50,100,LootType.Meal,true, 100, 0.1f));
            loots.Add(new Loot("Аптечка","Стандартный набор", 11738, 11738, true,100,250,LootType.Medical,true,300, 0.0f));
            loots.Add(new Loot("Бинт", "Стандартный бинт", 11736, 11736, true, 100, 250, LootType.Medical, true,100,0.0f));
            loots.Add(new Loot("M4", "Легендарная винтовка США", 356, 356, true,5000,10000,LootType.Expensive,true,2700,0.0f));
            loots.Add(new Loot("Патроны 5.56", "Патроны 5.56 для M4", 2043, 2043, true, 100,200,LootType.Weapon,true,600,0.0f));
            loots.Add(new Loot("Коробка", "Просто коробка.", 926, 926, false, 0, 5, LootType.Trash, true, 100,0.0f));
            loots.Add(new Loot("Золото", "Всё еще в цене.", 19941, 19941, false, 75, 200, LootType.Expensive, true,1000,0.0f));
            loots.Add(new Loot("Сигареты", "А что не убивает в наше время?", 19896, 19896, true, 15, 20, LootType.Trash, true,100,0.0f));
            loots.Add(new Loot("Водка", "Убивает микробы и организм.", 19821, 19821, false, 20, 50, LootType.Trash, true,300,0.0f));
            loots.Add(new Loot("Пустынный орел", "Не помню как называется эта пушка, но помню звук, с которым она разрывает ебальник", 348, 348, true, 1000, 2000, LootType.Weapon, true,1300,0.0f));
            loots.Add(new Loot(".44 Magnum", "Первое, что приходит в голову", 19995, 19995, true, 30, 40, LootType.Weapon, true,100,0.0f));
            loots.Add(new Loot("Лёгкий бронежилет", "Стандарный легковесный бронежилет, выдерживает выстрелы из пистолета мелкого калибра", 1242, 1242, true, 100, 250, LootType.Expensive, true,2500,0.0f));
            loots.Add(new Loot("Бронежилет", "Стандарный бронежилет регулярных войск США, обеспечивает защиту от бронебойных пуль и других мощных боеприпасов.", 19515, 19515, true, 200, 500, LootType.Expensive, true, 8500,90.0f));
            loots.Add(new Loot("Мотоциклетный шлем", "Обычный мотоциклетный шлем, выдержит разве что выстрел из мелкокалиберного пистолета.", 18977, 18977, true, 50, 100, LootType.Expensive, true, 1500, 90.0f));
            loots.Add(new Loot("Армейский шлем", "Шлем штурмовых войск США, выдержит выстрел из что выстрел штурмовой винтовки.", 19107, 19107, true, 50, 100, LootType.Expensive, true, 1500, 90.0f));
            loots.Add(new Loot("Средний рюкзак", "Рюкзак средней вместительности, вмещает в себя до 40 кг", 371, 371, true, 1000, 2000, LootType.Expensive, true, 1500, 90.0f));
            loots.Add(new Loot("Рюкзак путешественника", "Рюкзак большой вместительности, вмещает в себя до 80 кг", 19559, 19559, true, 5000, 10000, LootType.Expensive, true, 1500, 90.0f));

        }
        public static void Use(int id,int slotid, Player p)
        {
            Loot current = loots.Find(l => l.Id == id);

            switch (current.Name)
            {
                case "Яблоко":
                    p.SetAttachedObject(0,current.modelId,SampSharp.GameMode.Definitions.Bone.RightHand, new Vector3(0.1,0.02,0), new Vector3(0,0,0), new Vector3(0,0,0), SampSharp.GameMode.SAMP.Color.Tomato, SampSharp.GameMode.SAMP.Color.Tomato);
                    p.ApplyAnimation("VENDING", "VEND_EAT1_P", 1, false, true, true, false, 0,true);
                    p.inventory.DeleteItem(slotid);
                    p.inventory.currentWeight -= loots.Find(l => l.Name == "Яблоко").weight;
                    p.PlaySound(32200);
                    break;
                case "Бинт":
                    p.ApplyAnimation("PED", "GUM_EAT", 4.3f, false, true, true, false,3000,true);
                    p.PlaySound(20802);
                    p.inventory.DeleteItem(slotid);
                    p.inventory.currentWeight -= loots.Find(l => l.Name == "Яблоко").weight;
                    break;
                case "M4":
                    if (p.inventory.weaponSlotsInfo[5] == 0)
                    {
                        p.inventory.weaponSlotsInfo[5] = loots.Find(l => l.Name == "M4").Id;
                        p.inventory.weaponslots[5].PreviewModel = loots.Find(l => l.Name == "M4").previewModelId;
                        p.inventory.currentWeight -= loots.Find(l => l.Name == "M4").weight;
                        p.inventory.DeleteItem(slotid);
                        return;
                    }
                    break;
                case "Патроны 5.56":
                    if (p.inventory.weaponSlotsInfo[5] == loots.Find(p => p.Name == "M4").Id)
                    {
                        p.inventory.weaponslotsAmmoNum[5] += 50;
                        p.GiveWeapon(SampSharp.GameMode.Definitions.Weapon.M4, 50);
                        p.inventory.DeleteItem(slotid);
                        p.inventory.currentWeight -= loots.Find(p => p.Name == "M4").weight;
                        p.inventory.Close();
                        p.ApplyAnimation("RIFLE", "RIFLE_LOAD", 4.1f, false, true,true,false,0,true);
                        p.PlaySound(36401);
                        p.CancelSelectTextDraw();
                        return;
                    }
                    break;
                case "Пустынный орел":
                    if (p.inventory.weaponSlotsInfo[0] == 0)
                    {
                        Loot l = loots.Find(p => p.Name == "Пустынный орел");
                        p.inventory.weaponSlotsInfo[0] = l.Id;
                        p.inventory.weaponslots[0].PreviewModel = l.previewModelId;
                        p.inventory.currentWeight -= l.weight;
                        p.inventory.DeleteItem(slotid);
                    }
                    break;
                case ".44 Magnum":
                    if (p.inventory.weaponSlotsInfo[0] == loots.Find(p => p.Name == "Пустынный орел").Id)
                    {
                        p.inventory.weaponslotsAmmoNum[0] += 7;
                        p.GiveWeapon(SampSharp.GameMode.Definitions.Weapon.Deagle, 7);
                        p.inventory.DeleteItem(slotid);
                        p.inventory.currentWeight -= loots.Find(p => p.Name == "Пустынный орел").weight;
                        p.inventory.Close();
                        p.ApplyAnimation("COLT45", "COLT45_RELOAD", 4.1f, false, true, true, false, 0, true);
                        p.PlaySound(36401);
                        p.CancelSelectTextDraw();
                        return;
                    }
                    break;
                case "Лёгкий бронежилет":
                    if (p.inventory.ArmorSlot == 0)
                    {
                        Loot l = loots.Find(p => p.Name == "Лёгкий бронежилет");
                        p.inventory.ArmorSlot = l.Id;
                        p.inventory.armourButton.PreviewModel = l.previewModelId;
                        p.Armour = 50;
                        p.inventory.currentWeight -= l.weight;
                        p.inventory.DeleteItem(slotid);
                        p.ApplyAnimation("PLAYIDLES", "TIME", 10.1f, false, true, true, false, 2000, true);
                        p.PlaySound(5600);

                    }
                    else
                    {
                        p.SendClientMessage("На вас уже одет бронежилет, снимите текущий, чтобы одеть новый.");
                    }
                    p.inventory.Close();
                    p.CancelSelectTextDraw();
                    break;
                case "Бронежилет":
                    if (p.inventory.ArmorSlot == 0)
                    {
                        Loot l = loots.Find(p => p.Name == "Бронежилет");
                        p.inventory.ArmorSlot = l.Id;
                        p.inventory.armourButton.PreviewModel = l.previewModelId;
                        p.inventory.armourButton.PreviewRotation = new SampSharp.GameMode.Vector3(p.inventory.armourButton.PreviewRotation.X,(l.rotation * -1),p.inventory.armourButton.PreviewRotation.Z);
                        p.Armour = 100;
                        p.inventory.currentWeight -= l.weight;
                        p.inventory.DeleteItem(slotid);
                        p.ApplyAnimation("PLAYIDLES", "TIME", 4.1f, false, true, true, false, 2000, true);
                        p.PlaySound(5600);

                    }
                    else
                    {
                        p.SendClientMessage("На вас уже одет бронежилет, снимите текущий, чтобы одеть новый.");
                    }
                    p.inventory.Close();
                    
                    p.CancelSelectTextDraw();
                    break;
                case "Мотоциклетный шлем":
                    if (p.inventory.helmetSlot == 0)
                    {
                        Loot l = loots.Find(p => p.Name == "Мотоциклетный шлем");
                        p.inventory.helmetSlot = l.Id;
                        p.inventory.helmetbutton.PreviewModel = l.previewModelId;
                        p.SetAttachedObject(1, 18977, Bone.Head, new SampSharp.GameMode.Vector3(0.0709, 0.0160, 0.0), new SampSharp.GameMode.Vector3(85.8998, 89.2000, 1.1530), new SampSharp.GameMode.Vector3(1.1530, 1.0730, 1.0), 0, 0);
                        p.inventory.currentWeight -= l.weight;
                        p.inventory.DeleteItem(slotid);
                        p.ApplyAnimation("GOGGLES", "GOGGLES_PUT_ON", 4.1f,false,true,true,false,0,true);
                        p.inventory.Close();
                    }
                    break;
                case "Армейский шлем":
                    if (p.inventory.helmetSlot == 0)
                    {
                        Loot l = loots.Find(p => p.Name == "Армейский шлем");
                        p.inventory.helmetSlot = l.Id;
                        p.inventory.helmetbutton.PreviewModel = l.previewModelId;
                        p.SetAttachedObject(1, 19107, Bone.Head, new SampSharp.GameMode.Vector3(0.1589, 0.0000, 0.0000), new SampSharp.GameMode.Vector3(0.0000, 0.0000, 0.0000), new SampSharp.GameMode.Vector3(1.2000, 1.0129, 1.1950), 0, 0);
                        p.inventory.currentWeight -= l.weight;
                        p.inventory.DeleteItem(slotid);
                        p.ApplyAnimation("GOGGLES", "GOGGLES_PUT_ON", 4.1f, false, true, true, false, 0, true);
                        p.inventory.Close();
                    }
                    break;
                case "Средний рюкзак":
                    if (p.inventory.backpackSlot == 0)
                    {
                        Loot l = loots.Find(p => p.Name == "Средний рюкзак");
                        p.inventory.backpackSlot = l.Id;
                        p.inventory.backpackButton.PreviewModel = l.previewModelId;
                        p.SetAttachedObject(0, 371, Bone.Spine, new SampSharp.GameMode.Vector3(0.0789, -0.1180, 0.0000), new SampSharp.GameMode.Vector3(4.3999, 88.3000, -6.6999), new SampSharp.GameMode.Vector3(0.9129, 1.0000, 0.7880), 0, 0);
                        p.inventory.maxWeight = 40000;
                        p.inventory.currentWeight -= l.weight;
                        p.inventory.DeleteItem(slotid);
                        p.inventory.Close();
                    }
                    break;
                case "Рюкзак путешественника":
                    if (p.inventory.backpackSlot == 0)
                    {
                        Loot l = loots.Find(p => p.Name == "Рюкзак путешественника");
                        p.inventory.backpackSlot = l.Id;
                        p.inventory.backpackButton.PreviewModel = l.previewModelId;
                        p.SetAttachedObject(0, 19559, Bone.Spine, new SampSharp.GameMode.Vector3(0.1299, -0.0519, 0.0), new SampSharp.GameMode.Vector3(0.0, 87.3999, 0.0), new SampSharp.GameMode.Vector3(1.0, 1.0, 1.0), 0, 0);
                        p.inventory.maxWeight = 80000;
                        p.inventory.currentWeight -= l.weight;
                        p.inventory.DeleteItem(slotid);
                        p.inventory.Close();
                    }
                    break;
                default: break;
            }


            /**
            if (id == 4) {
                p.ApplyAnimation("COP_AMBIENT", "COPLOOK_SHAKE",1,false,false,false,true,2000);
                p.inventory.DeleteItem(slotid);
                p.PlaySound(5602);
                return;
            }
            if(id == 5)
            {
                if (p.inventory.weaponSlotsInfo[5] == 0)
                {
                    p.inventory.weaponSlotsInfo[5] = 4;
                    p.inventory.weaponslots[5].PreviewModel = loots.Find(l => l.Id == 4).previewModelId;
                    p.inventory.DeleteItem(slotid);
                    return;
                }
            }
            if(id == 6)
            {
                if(p.inventory.weaponSlotsInfo[5] == 4)
                {
                    p.inventory.weaponslotsAmmoNum[5] += 50;
                    p.GiveWeapon(SampSharp.GameMode.Definitions.Weapon.M4,50);
                    p.inventory.DeleteItem(slotid);
                    
                    return;
                }
            }
            **/

        }
        public static void Info(int id, Player p)
        {
            Loot loot = loots.Find(i => i.Id == id);
            var lootinfo = new MessageDialog($"{loot.Name}", $"{{FFFFFF}}{loot.Description}\n\n\n{{e61e1e}}Продажа NPC:{{0e630f}} {loot.BotSellPrice}$\n\n\n{{e61e1e}}Вес: {{FFA500}}{Convert.ToDouble(loot.weight) / 1000} kg.", "OK");
            lootinfo.Show(p);
            return;
        }
        public static void Drop(int id,int slotid, Player p)
        {
            
            Loot loot = loots.Find(i => i.Id == id);
            if (loot.isDropable)
            {
                
                PlayerLootObject.Create(loot, p.Position, p.VirtualWorld);
                p.inventory.DeleteItem(slotid);
                p.inventory.currentWeight -= loot.weight;
                p.CancelSelectTextDraw();
                return;
            }
            else
            {
                p.SendClientMessage(SampSharp.GameMode.SAMP.Color.Red, "Данный предмет нельзя выбросить.");
            }
        }
    }

}

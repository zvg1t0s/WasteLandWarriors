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
using WasteLandWarriors.AC;
using WasteLandWarriors.Display;
using WasteLandWarriors.Entities;
using WasteLandWarriors.Systems;
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
        Nature,
        
    }
    public class Loot
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
        public Vector3 rotation { get; }
        public static List<Loot> loots = new List<Loot>();
        public Loot( string Name, string Description, int modelId, int previewmodelId, bool isUsable, int BotSellPrice, int SellPrice, LootType lootType, bool isDropable, int weight, Vector3 rotation)
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
            loots.Add(new Loot("Яблоко","Вкусное яблоко", 19576, 19576, true,50,100,LootType.Meal,true, 100, new Vector3(0,0,0)));
            loots.Add(new Loot("Аптечка","Стандартный набор", 11738, 11738, true,100,250,LootType.Medical,true,300, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Бинт", "Стандартный бинт", 11736, 11736, true, 100, 250, LootType.Medical, true,100, new Vector3(0, 0, 0)));
            loots.Add(new Loot("M4", "Легендарная винтовка США", 356, 356, true,5000,10000,LootType.Expensive,true,2700, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Патроны 5.56", "Патроны 5.56 для M4", 2043, 2043, true, 100,200,LootType.Weapon,true,600, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Коробка", "Просто коробка.", 926, 926, false, 0, 5, LootType.Trash, true, 100, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Золото", "Всё еще в цене.", 19941, 19941, false, 75, 200, LootType.Expensive, true,1000,new Vector3(0, 0, 0)));
            loots.Add(new Loot("Сигареты", "А что не убивает в наше время?", 19896, 19896, true, 15, 20, LootType.Trash, true,100,new Vector3(0, 0, 0)));
            loots.Add(new Loot("Водка", "Убивает микробы и организм.", 19821, 19821, false, 20, 50, LootType.Trash, true,300,new Vector3(0, 0, 0)));
            loots.Add(new Loot("Пустынный орел", "Не помню как называется эта пушка, но помню звук, с которым она разрывает ебальник", 348, 348, true, 1000, 2000, LootType.Weapon, true,1300,new Vector3(0, 0, 0)));
            loots.Add(new Loot(".44 Magnum", "Первое, что приходит в голову", 19995, 19995, true, 30, 40, LootType.Weapon, true,100,new Vector3(0, 0, 0)));
            loots.Add(new Loot("Лёгкий бронежилет", "Стандарный легковесный бронежилет, выдерживает выстрелы из пистолета мелкого калибра", 1242, 1242, true, 100, 250, LootType.Expensive, true,2500,new Vector3(0, 0, 0)));
            loots.Add(new Loot("Бронежилет", "Стандарный бронежилет регулярных войск США, обеспечивает защиту от бронебойных пуль и других мощных боеприпасов.", 19515, 19515, true, 200, 500, LootType.Expensive, true, 8500, new Vector3(0, 0, 90)));
            loots.Add(new Loot("Мотоциклетный шлем", "Обычный мотоциклетный шлем, выдержит разве что выстрел из мелкокалиберного пистолета.", 18977, 18977, true, 50, 100, LootType.Expensive, true, 1500, new Vector3(0, 0, 90)));
            loots.Add(new Loot("Армейский шлем", "Шлем штурмовых войск США, выдержит выстрел из что выстрел штурмовой винтовки.", 19107, 19107, true, 50, 100, LootType.Expensive, true, 1500, new Vector3(0, 0, 90)));
            loots.Add(new Loot("Средний рюкзак", "Рюкзак средней вместительности, вмещает в себя до 40 кг", 371, 371, true, 1000, 2000, LootType.Expensive, true, 1500, new Vector3(0, 0, 90)));
            loots.Add(new Loot("Рюкзак путешественника", "Рюкзак большой вместительности, вмещает в себя до 80 кг", 19559, 19559, true, 5000, 10000, LootType.Expensive, true, 1500, new Vector3(0, 0, 90)));
            loots.Add(new Loot("Винтовка Remington 700", "Та самая легендарная винтовка.", 358, 358, true, 2000, 4000, LootType.Weapon, true, 3100, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Патроны .308 Win", "Патроны для винтовки Remington 700 [3 шт]",2039, 2061, true, 20, 50, LootType.Weapon, true, 300, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Дрова", "Гнилое полено.", 19793, 19793, true, 10, 15, LootType.Nature, true, 500, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Спички", "Внутри 20 шт.", 11748, 11748, true, 10, 15, LootType.Trash, true, 20, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Бутылка воды", "Бутылка воды обьемом 0.5л", 1950, 1950, true,10,10,LootType.Meal,true, 500, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Банка газировки", "Та самая банка газировки \"Sprunk\", напоминающая вам о былых временах.", 1546, 1546, true, 15, 20, LootType.Meal, true, 500, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Пиво", "Бутылка светлого нефильтрованного.", 1543, 1543, true, 10, 15, LootType.Meal, true, 500, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Хлеб", "Буханка чёрствого хлеба.", 19579, 19579, true, 3, 5, LootType.Meal, true, 100, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Сухпаёк", "Старый армейский сухпаёк, всё еще пригоден в пищу.", 2663, 2663, true, 15, 25, LootType.Meal, true, 100, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Пустая канистра", "Старая ржавая канистра, пахнет бензином.", 1650, 1650, true, 20, 30, LootType.Trash, true, 500, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Канистра с бензином", "Старая ржавая канистра с бензином.", 1650, 1650, true, 20, 30, LootType.Trash, true, 5000, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Палатка", "Старая палатка, но всё еще пригодна.", 1576, 1576, true, 20, 30, LootType.Trash, true, 1500, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Мыло", "Кусок хозяйственного мыла с едким запахом.", 19874, 19874, true, 5, 10, LootType.Trash, true, 100, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Тяжелый шлем", "Шлем спецвойск swat, выдерживает выстрелы из крупнокалиберного оружия.", 19141, 19141, true, 200, 500, LootType.Expensive, true, 3000, new Vector3(0, 0, 90)));
            loots.Add(new Loot("Огнетушитель", "Тушить жопу Майнера", 366, 366, true, 200, 500, LootType.Expensive, true, 3000, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Металл", "Металлический лист", 19843, 19843, false, 200, 500, LootType.Expensive, true, 3000, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Отмычка", "Отмычка ебучая", 11716, 11716, false, 200, 500, LootType.Expensive, true, 100, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Микросхема", "Микросхема", 19273, 19273, false, 200, 500, LootType.Expensive, true, 100, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Радиозапчасть", "Радиозапчасть", 18875, 18875, false, 200, 500, LootType.Expensive, true, 100, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Корпус ноутбука", "Корпус ноутбука", 19894, 19894, false, 200, 500, LootType.Expensive, true, 100, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Ноутбук", "Ноутбук ебучий", 19893, 19893, false, 200, 500, LootType.Expensive, true, 100, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Сырая рыба", "Воняет пиздой", 19630, 19630, false, 10, 15, LootType.Meal, true, 100, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Жареная рыба", "Горячая рыба обжаренная на костре", 19630, 19630, false, 10, 15, LootType.Meal, true, 100, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Топор", "Порно!", 2228, 2228, false, 10, 15, LootType.Meal, true, 100, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Ягода", "Ягода ебаная", 19575, 19575, false, 10, 15, LootType.Meal, true, 100, new Vector3(0, 0, 0)));
            //1303
            loots.Add(new Loot("Медная руда", "Медная руда", 1303, 1303, false, 10, 15, LootType.Nature, true, 100, new Vector3(0, 0, 0)));
            loots.Add(new Loot("Железная руда", "Железная руда", 1303, 1303, false, 10, 15, LootType.Nature, true, 100, new Vector3(0, 0, 0)));


        }
        public static void Use(int id,int slotid, Player p)
        {
            Loot current = loots.Find(l => l.Id == id);

            switch (current?.Name)
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
                    p.Health = 100;
                    RakcheatNatives.AC_SetPlayerHealth(p, 100);
                    p.PlaySound(20802);
                    p.inventory.DeleteItem(slotid);
                    p.inventory.currentWeight -= loots.Find(l => l.Name == "Бинт").weight;
                    if (p.diseases.dislocation)
                    {
                        p.diseases.dislocation = false;
                        p.SendClientMessage("{20730F}Вы использовали бинт и вправили вывих.");
                        p.PlaySound(17804);
                    }
                    else if (p.diseases.bleed != Systems.bleedingType.None)
                    {
                        p.diseases.bleed = bleedingType.None;
                        p.SendClientMessage("{20730F}Вы использовали бинт и остановили кровотечение.");
                        p.PlaySound(17804);
                    }
                    break;
                case "M4":
                    if (p.inventory.weaponSlotsInfo[4] == 0)
                    {
                        p.inventory.weaponSlotsInfo[4] = loots.Find(l => l.Name == "M4").Id;
                        p.inventory.weaponslots[4].PreviewModel = loots.Find(l => l.Name == "M4").previewModelId;
                        p.inventory.currentWeight -= loots.Find(l => l.Name == "M4").weight;
                        p.inventory.DeleteItem(slotid);
                        return;
                    }
                    break;
                case "Патроны 5.56":
                    if (p.inventory.weaponSlotsInfo[4] == loots.Find(p => p.Name == "M4").Id)
                    {
                        p.inventory.weaponslotsAmmoNum[4] += 50;
                        RakcheatNatives.AC_GivePlayerWeapon(p, Weapon.M4, 50);
                      //  p.GiveWeapon(SampSharp.GameMode.Definitions.Weapon.M4, 50);
                        p.inventory.DeleteItem(slotid);
                        p.inventory.currentWeight -= loots.Find(p => p.Name == "Патроны 5.56").weight;
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
                        p.inventory.weaponSlotsInfo[1] = l.Id;
                        p.inventory.weaponslots[1].PreviewModel = l.previewModelId;
                        p.inventory.currentWeight -= l.weight;
                        p.inventory.DeleteItem(slotid);
                    }
                    break;
                case ".44 Magnum":
                    if (p.inventory.weaponSlotsInfo[1] == loots.Find(p => p.Name == "Пустынный орел").Id)
                    {
                        p.inventory.weaponslotsAmmoNum[1] += 7;
                        RakcheatNatives.AC_GivePlayerWeapon(p, Weapon.Deagle, 7);
                       // p.GiveWeapon(SampSharp.GameMode.Definitions.Weapon.Deagle, 7);
                        p.inventory.DeleteItem(slotid);
                        p.inventory.currentWeight -= loots.Find(p => p.Name == ".44 Magnum").weight;
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
                        RakcheatNatives.AC_SetPlayerArmour(p, 50);
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
                        p.inventory.armourButton.PreviewRotation = new SampSharp.GameMode.Vector3(p.inventory.armourButton.PreviewRotation.X,(l.rotation.Z * -1),p.inventory.armourButton.PreviewRotation.Z);
                        RakcheatNatives.AC_SetPlayerArmour(p, 100);
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
                case "Винтовка Remington 700":
                    if (p.inventory.weaponSlotsInfo[5] == 0)
                    {
                        p.inventory.weaponSlotsInfo[5] = loots.Find(l => l.Name == "Винтовка Remington 700").Id;
                        p.inventory.weaponslots[5].PreviewModel = loots.Find(l => l.Name == "Винтовка Remington 700").previewModelId;
                        p.inventory.currentWeight -= loots.Find(l => l.Name == "Винтовка Remington 700").weight;
                        p.inventory.DeleteItem(slotid);
                        return;
                    }
                    break;
                case "Патроны .308 Win":
                    if (p.inventory.weaponSlotsInfo[5] == loots.Find(p => p.Name == "Винтовка Remington 700").Id)
                    {
                        p.inventory.weaponslotsAmmoNum[5] += 3;
                        RakcheatNatives.AC_GivePlayerWeapon(p, Weapon.Sniper, 1);
                       // p.GiveWeapon(SampSharp.GameMode.Definitions.Weapon.Sniper, 1);
                        p.inventory.DeleteItem(slotid);
                        p.inventory.currentWeight -= loots.Find(p => p.Name == "Патроны .308 Win").weight;
                        p.inventory.Close();
                        p.SetArmedWeapon(Weapon.Sniper);
                        p.ApplyAnimation("RIFLE", "RIFLE_LOAD", 4.1f, false, true, true, false, 0, true);
                        p.PlaySound(36401);
                        p.CancelSelectTextDraw();
                        return;
                    }
                    break;
                case "Бутылка воды":
                    if (p.waterNum <= 80)
                    {
                        p.waterNum += 20;
                        p.playerInterface.WaterNum.Text = p.waterNum.ToString();
                        p.inventory.currentWeight -= loots.Find(p => p.Name == "Бутылка воды").weight;
                        p.inventory.DeleteItem(slotid);
                        p.inventory.Close();
                        p.PlaySound(32201);
                        p.ApplyAnimation("BAR", "DNK_STNDM_LOOP", 4.1f, false, true, true, false, 0, true);
                        p.CancelSelectTextDraw();
                        return;
                    }
                    break;
                case "Банка газировки":
                    if(p.waterNum <= 80)
                    {
                        p.waterNum += 20;
                        p.playerInterface.WaterNum.Text = p.waterNum.ToString();
                        p.inventory.currentWeight -= loots.Find(p => p.Name == "Банка газировки").weight;
                        p.inventory.DeleteItem(slotid);
                        p.inventory.Close();
                        p.PlaySound(32201);
                        p.ApplyAnimation("BAR", "DNK_STNDM_LOOP", 4.1f, false, true, true, false, 0, true);
                        p.CancelSelectTextDraw();
                        return;
                    }
                    break;
                case "Спички":
                    if(p.spichki != 20)
                    {
                        p.spichki = 20;
                        p.inventory.currentWeight -= loots.Find(p => p.Name == "Спички").weight;
                        p.inventory.DeleteItem(slotid);
                        p.inventory.Close();
                        p.SendClientMessage("{0E6307}Вы открыли коробку спичек [20 шт]");
                        p.CancelSelectTextDraw();
                    }
                    break;
                case "Сигареты":
                    if (p.cigarettes != 20)
                    {
                        p.cigarettes = 20;
                        p.inventory.currentWeight -= loots.Find(p => p.Name == "Сигареты").weight;
                        p.inventory.DeleteItem(slotid);
                        p.inventory.Close();
                        p.SendClientMessage("{0E6307}Вы открыли пачку сигарет [20 шт]");
                        p.CancelSelectTextDraw();
                    }
                    break;
                case "Дрова":
                    if(p.spichki >= 1)
                    {
                        p.spichki -= 1;
                        p.inventory.currentWeight -= loots.Find(p => p.Name == "Дрова").weight;
                        p.inventory.DeleteItem(slotid);
                        p.SendClientMessage("{0E6307}Вы использовали спички и разожгли костёр.");
                        CampFire.Create(p.Position);
                        p.CancelSelectTextDraw();
                        p.inventory.Close();
                    }
                    break;
                case "Тяжелый шлем":
                    if (p.inventory.helmetSlot == 0)
                    {
                        Loot l = loots.Find(p => p.Name == "Тяжелый шлем");
                        p.inventory.helmetSlot = l.Id;
                        p.inventory.helmetbutton.PreviewModel = l.previewModelId;
                        p.SetAttachedObject(1, 19141, Bone.Head, new SampSharp.GameMode.Vector3(0.1089, 0.0100, 0), new SampSharp.GameMode.Vector3(0.0000, 0.0000, 0.0000), new SampSharp.GameMode.Vector3(1.2000, 1.0129, 1.1950), 0, 0);
                        p.inventory.currentWeight -= l.weight;
                        p.inventory.DeleteItem(slotid);
                        p.ApplyAnimation("GOGGLES", "GOGGLES_PUT_ON", 4.1f, false, true, true, false, 0, true);
                        p.inventory.Close();
                    }
                    break;
                case "Канистра с бензином":
                    if (VehicleManager.FindClosedCar(p, 10) != null)
                    {
                        /// Car.allCars.FirstOrDefault(b => b.vehicle.Id == Car.FindClosedCar(p).Id).Fuel += 10;
                        VehicleManager.FindClosedCar(p, 10).Fuel += 10;
                        p.SendClientMessage("{0E6307}Вы заправили транспорт с канистры.");
                        p.inventory.currentWeight -= loots.Find(p => p.Name == "Канистра с бензином").weight;
                        p.inventory.DeleteItem(slotid);
                       // PlayerLootObject.AddtoInventory(p, 27);
                        p.inventory.Close();
                        p.CancelSelectTextDraw();
                    }
                    else
                    {
                        p.SendClientMessage("Вы вылили топливо из канистры.");
                        p.inventory.DeleteItem(slotid);
                      //  PlayerLootObject.AddtoInventory(p, 27);
                        p.inventory.Close();
                        p.CancelSelectTextDraw();
                    }
                        break;
                case "Огнетушитель":
                    if (p.inventory.weaponSlotsInfo[0] == 0)
                    {
                        Loot l = loots.Find(p => p.Name == "Огнетушитель");
                        RakcheatNatives.AC_GivePlayerWeapon(p, Weapon.FireExtinguisher, 20000);
                        p.SetArmedWeapon(Weapon.FireExtinguisher);
                        p.inventory.weaponSlotsInfo[0] = l.Id;
                        p.inventory.weaponslots[0].PreviewModel = l.previewModelId;
                        p.inventory.currentWeight -= l.weight;
                        p.inventory.DeleteItem(slotid);
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
        public void Info(Player p)
        {
            
            var lootinfo = new MessageDialog($"{Name}", $"{{FFFFFF}}{Description}\n\n\n{{e61e1e}}Продажа NPC:{{0e630f}} {BotSellPrice}$\n\n\n{{e61e1e}}Вес: {{FFA500}}{Convert.ToDouble(weight) / 1000} kg.", "OK");
            lootinfo.Show(p);
            return;
        }
        public void Info(Player p, int condition)
        {

            var lootinfo = new MessageDialog($"{Name}", $"{{FFFFFF}}{Description}\n\n\n{{e61e1e}}Продажа NPC:{{0e630f}} {BotSellPrice}$\n\n\n{{e61e1e}}Вес: {{FFA500}}{Convert.ToDouble(weight) / 1000} kg\n\n\n{{e61e1e}}Состояние: {{FFA500}}{condition}", "OK");
            lootinfo.Show(p);
            return;
        }
        public void Drop(Loot l,int condition,int slotid, Player p)
        {
            
            Loot loot = loots.Find(i => i == l);
            if (loot.isDropable)
            {
                
                PlayerLootObject.Create(loot,condition, p.Position, p.VirtualWorld);
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

using SampSharp.GameMode;
using SampSharp.GameMode.SAMP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasteLandWarriors.Others;

namespace WasteLandWarriors.WorldObjects
{
    internal class WorldLootSpawnpoints
    {
        public static int Idd = 0;
        int Id {  get; set; }
        public SampSharp.GameMode.Vector3 Position { get; set; }

        public string Description { get; set; }
        public int VirtualWorld { get;set; }

        public LootType lootType { get; set; }

        public static List<WorldLootSpawnpoints> lootSpawns = new List<WorldLootSpawnpoints>();

        

        public WorldLootSpawnpoints(Vector3 pos, string desc, int vw, LootType loot)
        {
            Idd++;
            Id = Idd;

            Position = pos;
            Description = desc;
            VirtualWorld = vw;

            lootType = loot;
        }
        public static void Create()
        {
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(318.62314, 1146.3755, 8.5859375), "ангар ферма 1", 0, LootType.Trash));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(314.94275, 1146.4631, 8.5859375), "ангар ферма 2",0, LootType.Trash));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(312.06485, 1146.1653, 8.5859375), "ангар ферма 3",0, LootType.Trash));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(301.14612, 1144.3557, 9.1374855), "у двери дома на ферме",0, LootType.Trash));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1349.5199, 1519.7617, 3001.0913), "болька на тумбе",1011, LootType.Medical));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1351.1698, 1529.4872, 3000.5916), "болька на трупе 1",1011, LootType.Medical));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1352.5359, 1531.277, 3000.6172), "болька на трупе 2",1011, LootType.Medical));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1345.1202, 1529.9883, 3001.1665), "болька на столе 1" ,1011, LootType.Medical));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1342.1926, 1531.0657, 3001.1665), "болька на столе 2", 1011, LootType.Medical));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1334.5996, 1531.5676, 3000.9724), "На дальней каталке",1011, LootType.Medical));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1346.81, 1511.9468, 2999.5967), "болька на упавшем автомате с едой", 1011, LootType.Meal));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1340.8671, 1511.3815, 2999.2869), "болька на кресле", 1011, LootType.Trash));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1347.4851, 1526.1783, 3000.2446), "болька на полу 1", 1011, LootType.Medical));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1341.1509, 1518.3593, 3000.3877), "болька на палете", 1011, LootType.Trash));


        }
        public static void SpawnLoot()
        {
            int counter = 0;
            foreach(var loot in lootSpawns)
            {
                Random r = new Random();
                
                if(r.Next(4) < 2)
                {

                    List<Loot> s = Loot.loots.FindAll(l => l.lootType == loot.lootType);
                    
                    Random rnd = new Random();
                    int index = rnd.Next(s.Count);
                    if (index != -1) {
                        PlayerLootObject.Create(s[index], loot.Position, loot.VirtualWorld);
                        counter++;
                    }

                }
            }
            Player.SendClientMessageToAll($"Заспавнилось лута: {counter}");
            
        }

    }
}

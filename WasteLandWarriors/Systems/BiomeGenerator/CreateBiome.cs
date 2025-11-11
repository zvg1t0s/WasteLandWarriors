using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasteLandWarriors.Systems.BiomeGenerator.BiomeObjectMiniGames;
using WasteLandWarriors.WorldObjects;

namespace WasteLandWarriors.Systems.BiomeGenerator
{
    public class CreateBiome
    {
        public static List<GeneratedObject> genObjects = new List<GeneratedObject>();
        public static void Create()
        {
           // genObjects.ForEach(genObjects => genObjects.Delete());

            foreach (var obj in genObjects.ToList()) {
                obj.Delete();
                genObjects.Remove(obj);
            }

            var mixedForestObj = new List<BiomeObject>();
            mixedForestObj.Add(new BiomeObject("Береза молодая", 770, BiomeObjectType.Tree, -0.1f,new TreeMiniGame()));
            mixedForestObj.Add(new BiomeObject("Береза молодая 2", 763, BiomeObjectType.Tree, -0.1f, new TreeMiniGame()));
            mixedForestObj.Add(new BiomeObject("Береза молодая 3", 770, BiomeObjectType.Tree, -0.1f, new TreeMiniGame()));
            mixedForestObj.Add(new BiomeObject("Упавшее дерево", 835, BiomeObjectType.FallenTree, 2.5f, new TreeMiniGame()));
            mixedForestObj.Add(new BiomeObject("Упавшее дерево 2", 844, BiomeObjectType.FallenTree, 1.0f, new TreeMiniGame()));
            mixedForestObj.Add(new BiomeObject("Упавшее дерево 3", 845, BiomeObjectType.FallenTree, 0.0f, new TreeMiniGame()));
            mixedForestObj.Add(new BiomeObject("Упавшее дерево переплетенное", 839, BiomeObjectType.FallenTree, 0.0f, new TreeMiniGame()));
            mixedForestObj.Add(new BiomeObject("Зеленый куст", 813, BiomeObjectType.grass, 0.3f, new BushMiniGame()));
            mixedForestObj.Add(new BiomeObject("Зеленый куст 2", 823, BiomeObjectType.grass, 0.3f, new BushMiniGame()));

            var deadForestObj = new List<BiomeObject>();

            deadForestObj.Add(new BiomeObject("Мертвое дерево", 832, BiomeObjectType.FallenTree, 0.5f, new TreeMiniGame()));
            deadForestObj.Add(new BiomeObject("Камень", 830, BiomeObjectType.FallenTree, 0f, new TreeMiniGame()));
            deadForestObj.Add(new BiomeObject("Пень", 831, BiomeObjectType.FallenTree, 0.5f, new TreeMiniGame()));
            deadForestObj.Add(new BiomeObject("Мертвое дерево", 846, BiomeObjectType.FallenTree, 0.5f, new TreeMiniGame()));
            deadForestObj.Add(new BiomeObject("Мертвое дерево", 838, BiomeObjectType.FallenTree, 0.5f, new TreeMiniGame()));
            deadForestObj.Add(new BiomeObject("Мертвое дерево", 829, BiomeObjectType.FallenTree, 0.5f, new TreeMiniGame()));

            var mineObj = new List<BiomeObject>();

            mineObj.Add(new BiomeObject("Медь", 807, BiomeObjectType.Rock, 0.0f, new CopperMiniGame(), 0, 18248, "cw_junkyarddigcs_t", "Was_scrpyd_rustmetal"));
            mineObj.Add(new BiomeObject("Жезело", 807, BiomeObjectType.Rock, 0f, new IronMiniGame(), 0, 3294, "cxrf_payspray", "Metalox64"));

            var mixedForestBiome = new Biome("Смешанный лес", mixedForestObj);

            var deadForestBiome = new Biome("Мертвый лес", deadForestObj);

            var mineBiome = new Biome("Рудник", mineObj);

            genObjects.AddRange(BiomeGenerator.Generate(mixedForestBiome, 150, WorldMapZones.forestNearLBK1));

            genObjects.AddRange(BiomeGenerator.Generate(deadForestBiome, 150, WorldMapZones.deadForest1));
           // genObjects.AddRange(BiomeGenerator.Generate(deadForestBiome, 100, WorldMapZones.deadForest1));
            genObjects.AddRange(BiomeGenerator.Generate(mineBiome, 50, WorldMapZones.mineZone));
            


        }
        public static void Use(Player p)
        {
            if (genObjects.Count() < 1)
            {
                return;
            }
            foreach (var obj in genObjects.ToList())
            {
                if (p.IsInRangeOfPoint(5f, obj.position))
                {
                    obj.Use(p);
                    break;
                    /**
                    if (obj.Use(p)) { 
                        obj.Delete();
                        genObjects.Remove(obj);
                    }
                    break;
                    **/
                }
            }
        }
    }
}

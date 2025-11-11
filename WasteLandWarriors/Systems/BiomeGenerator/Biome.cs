using SampSharp.GameMode.World;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasteLandWarriors.WorldObjects;

namespace WasteLandWarriors.Systems.BiomeGenerator
{
    public class Biome
    {
        public string Name { get; set; }

        public List<BiomeObject> BiomeObjects;


        public Biome(string Name, List<BiomeObject> biomeObjects)
        {
            this.Name = Name;
            this.BiomeObjects = biomeObjects;
        }
        /**
        public static void Create()
        {
            var les = new List<BiomeObject>();
            
            les.Add(new BiomeObject("Береза молодая", 770, BiomeObjectType.Tree, 0.0f));
            les.Add(new BiomeObject("Береза молодая 2", 763, BiomeObjectType.Tree, 0.0f));
            les.Add(new BiomeObject("Береза молодая 3", 770, BiomeObjectType.Tree, 0.0f));
            les.Add(new BiomeObject("Упавшее дерево", 835, BiomeObjectType.FallenTree, 0.5f));
            les.Add(new BiomeObject("Упавшее дерево 2", 844, BiomeObjectType.FallenTree, 1.0f));
            les.Add(new BiomeObject("Упавшее дерево 3", 845, BiomeObjectType.FallenTree, 0.0f));
            les.Add(new BiomeObject("Зеленый куст", 813, BiomeObjectType.grass, 0.1f));
            les.Add(new BiomeObject("Зеленый широкий куст 2", 14468, BiomeObjectType.grass, 0.1f));


            biomes.Add(new Biome("Лес", les));
        }
        **/
        /**
        public void Generate(GangZone gz)
        {
            Random r = new Random();
            var x = gz.MaxX - gz.MinX;
            var y = gz.MaxY - gz.MinY;

            int randomnum = 0;
            if(x * y < 6000)
            {
                randomnum = 15;
            }
            else if (x * y < 18000)
            {
                randomnum = 50;
            }
            else if (x * y < 50000)
            {
                randomnum = 100;
            }
            else
            {
                randomnum = 200;
            }

                for (int i = 0; i < r.Next(randomnum / 2, randomnum); i++)
                {
                    
                    int index = r.Next(BiomeObjects.Count);
                    if (index != -1)
                    {


                        double scaledx = (r.NextDouble() * x) + gz.MinX;



                        double scaledy = (r.NextDouble() * y) + gz.MinY;

                        BiomeObjects[index].Generate(new SampSharp.GameMode.Vector2(scaledx, scaledy));

                    }
                }
        }
        public void ShowToPlayer(Player p)
        {
            foreach (var biomeObj in BiomeObjects) { 
                biomeObj.ShowToPlayer(p);
            }
        }
        public static void Dispose()
        {
            foreach (var biome in biomes)
            {

                foreach (var obj in biome.BiomeObjects)
                {
                    obj.Dispose();
                }
            }
        }
        **/

    }
}

using SampSharp.GameMode.World;
using SampSharpGameMode1.Physics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.Systems.BiomeGenerator
{
    internal class BiomeGenerator
    {
        public static List<GeneratedObject> Generate(Biome biome, int count, GangZone biomeZone)
        {

            var x = biomeZone.MaxX - biomeZone.MinX;
            var y = biomeZone.MaxY - biomeZone.MinY;

            Random r = new Random();
            var GeneratedObjects = new List<GeneratedObject>();
            float gridStep = 2;
            float halfx = x / 2;
            float halfy = y / 2;

            for (int i = 0; i < count; i++)
            {
                bool placed = false;
                int index = r.Next(biome.BiomeObjects.Count);
                var chosen = biome.BiomeObjects[index];
                int attemps = 0;
                    while (!placed && attemps < 10)
                    {
                    attemps++;
                        double scaledx = (r.NextDouble() * x) + biomeZone.MinX;
                        double scaledy = (r.NextDouble() * y) + biomeZone.MinY;

                        foreach (var g in GeneratedObjects)
                        {
                            if (Vector2.Distance(new Vector2(g.position.X, g.position.Y), new Vector2((float)scaledx, (float)scaledy)) > gridStep)
                            {
                                break;
                            }
                            else
                            {
                            
                                continue;
                            }
                        }
                        placed = true;
                    float scaledz = 0;
                    ColAndreas.FindZ_For2DCoord((float)scaledx, (float)scaledy, out scaledz);
                    float rotY = 0;
                    float rotX = 0;
                    float rotZ = 0;
                    ColAndreas.RayCastLineAngle(new SampSharp.GameMode.Vector3(scaledx , scaledy, scaledz + 700), new SampSharp.GameMode.Vector3(scaledx, scaledy, scaledz - 1000), out _, out _,out _,out rotX, out rotY, out rotZ);
                    GeneratedObjects.Add(new GeneratedObject(chosen.Name, chosen.modelId, chosen.type, new SampSharp.GameMode.Vector3((float)scaledx, (float)scaledy, scaledz + chosen.zMinus), new SampSharp.GameMode.Vector3(rotX,rotY,rotZ), chosen.miniGame, chosen.textureSlot, chosen.texturemodelId, chosen.textureLib, chosen.textureName, chosen.color));

                    }
                

            }
            return GeneratedObjects;
        }
        
    }
}

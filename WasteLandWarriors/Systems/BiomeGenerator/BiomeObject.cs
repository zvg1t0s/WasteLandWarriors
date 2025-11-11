using SampSharp.GameMode;
using SampSharp.GameMode.SAMP;
using SampSharp.GameMode.World;
using SampSharp.Streamer.World;
using SampSharpGameMode1.Physics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasteLandWarriors.Systems.BiomeGenerator.BiomeObjectMiniGames;

namespace WasteLandWarriors.Systems.BiomeGenerator
{
    public class BiomeObject
    {
       
        public string Name = string.Empty;

        public int modelId = 0;

        public float zMinus { get; }

        public BiomeObjectType type  { get; set; }

        public int textureSlot = 0;

        public int texturemodelId = 0;

        public string textureLib = string.Empty;
        public string textureName = string.Empty;

        public Color color = default;

        public IBiomeObjectMiniGame miniGame;
        public BiomeObject(string Name, int modelId, BiomeObjectType type, float zMinus, IBiomeObjectMiniGame miniGame, int textureslot = 0, int texturemodelObject = 0, string textureLib = "", string textureName = "", Color color = default)
        {
            this.Name = Name;
            this.modelId = modelId;
            this.type = type;
            this.zMinus = zMinus;
            this.miniGame = miniGame;
            textureSlot = textureslot;
            texturemodelId = texturemodelObject;
            this.textureLib = textureLib;
            this.textureName = textureName;
            this.color = color;
        }

        
        /**
        public void Generate(Vector2 position)
        {
            float z = 0f;
            ColAndreas.FindZ_For2DCoord(position.X ,position.Y, out z);

            Random r = new Random();

            dyn = new DynamicObject(modelId, new SampSharp.GameMode.Vector3(position.X, position.Y, z  + zMinus), new Vector3(0,0,(double)r.Next(0,360)));
            
        }

        public void ShowToPlayer(Player p)
        {
            dyn.Player = p;
        }
        public void Dispose()
        {
            if(dyn != null) dyn.Dispose();
            
           
        }
        **/
    }
    public enum BiomeObjectType
    {
        None = 0,
        Tree = 1,
        FallenTree = 2,
        Rock = 3,
        grass = 4,
        other = 5,

    }
}

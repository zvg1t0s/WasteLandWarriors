using SampSharp.GameMode;
using SampSharp.GameMode.SAMP;
using SampSharp.GameMode.World;
using SampSharp.Streamer.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasteLandWarriors.Others;
using WasteLandWarriors.Systems.BiomeGenerator.BiomeObjectMiniGames;

namespace WasteLandWarriors.Systems.BiomeGenerator
{
    public class GeneratedObject
    {
        public string Name;

        public DynamicObject Obj;

        public BiomeObjectType type;

        public Vector3 position;

        public TextLabel text;

        public IBiomeObjectMiniGame miniGame;

        public GeneratedObject(string Name,int modelId, BiomeObjectType type, Vector3 position, Vector3 rotation,IBiomeObjectMiniGame miniGame, int textureslot = 0, int texturemodelObject = 0, string textureLib = "", string textureName = "", Color color = default)
        {
            this.Name = Name;
            this.type = type;
            this.position = position;
            Obj = new DynamicObject(modelId, position, rotation);
            Obj.SetMaterial(textureslot, texturemodelObject, textureLib, textureName, color);
            text = new TextLabel(Name,-1,new Vector3(position.X, position.Y, position.Z + 1), 5, 0);
            text.TestLOS = false;
            this.miniGame = miniGame;


        }

        public void Use(Player p)
        {
            miniGame.Play(p, this);
            
        }

        public void Delete()
        {
            this.Obj.Dispose();
            this.text.Dispose();

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampSharp.GameMode;
using SampSharp.GameMode.World;
using SampSharp.Streamer;
using SampSharp.Streamer.Events;
using SampSharp.Streamer.World;
using WasteLandWarriors.Data;
using WasteLandWarriors.Entities;


namespace WasteLandWarriors.Services
{
    internal class ConstuctionsService 
    {
       // private GameModeContext _gamemodeContext;
        public static List<DynamicObject> objects = new List<DynamicObject>();

        public async Task Create(Player p,ConstructionType type, Vector3 pos, Vector3 rotation)
        {
            
            var construction = new Constructions();
           // var player  = await _gamemodeContext.Users.FirstOrDefaultAsync(s => s.NickName == p.Name);
            //construction.OwnerId = player.Id;
            construction.ConstructionType = type;
            construction.posX = pos.X;
            construction.posY = pos.Y;
            construction.posZ = pos.Z;
            construction.rotX = rotation.X;
            construction.rotY = rotation.Y;
            construction.rotZ = rotation.Z;

            switch (construction.ConstructionType)
            {
                case ConstructionType.None:
                    construction.ModelId = 10;
                    break;
                case ConstructionType.Chest:
                    construction.ModelId = 19918;
                    construction.Health = 150;
                    break;
                case ConstructionType.SmallWall:
                    construction.ModelId = 19366;
                    construction.Health = 100;
                    break;
                case ConstructionType.Wall:
                    construction.ModelId = 19458;
                    construction.Health = 150;
                    break;
                case ConstructionType.Door:
                    construction.ModelId = 9625;
                    construction.Health = 250;
                    break;
                case ConstructionType.Window:
                    construction.ModelId = 19412;
                    construction.Health = 100;
                    break;
                case ConstructionType.Bed:
                    construction.ModelId = 1812;
                    construction.Health = 50;
                    break;
                case ConstructionType.Oven:
                    construction.ModelId = 19527;
                    construction.Health = 50;
                    break;

                default:
                    break;


            }
            var obj = new DynamicObject(construction.ModelId, pos, rotation, 0, 0, p, 200);
            objects.Add(obj);
            obj.Edit(p);

            obj.Edited += OnEditConstruct;

            void OnEditConstruct(object sender, PlayerEditEventArgs e){
                
            }
            
        }

    }
}

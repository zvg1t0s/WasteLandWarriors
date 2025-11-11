using SampSharp.GameMode;
using SampSharp.Streamer.Definitions;
using SampSharp.Streamer.World;
using SampSharp.Streamer.Events;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampSharp.GameMode.Events;
using WasteLandWarriors.Events;

namespace WasteLandWarriors.Entities
{
    internal class CampFire
    {
        public static int idd = 0;
        public int id = 0;
        public DynamicObject campfireObject;
        public Vector3 position;
        public DynamicArea area;

        public static List<CampFire> campFires = new List<CampFire>();
        public CampFire(Vector3 pos) {
            id = idd;
            idd++;
            campfireObject = new DynamicObject(19632, new Vector3(pos.X, pos.Y, pos.Z - 1));
            area = DynamicArea.CreateCircle(pos.X, pos.Y, 5, 0,0);

            area.Enter += Onentered;
            area.Leave += OnExit;
            
            

            campfireObject.World = 0;
            campfireObject.Interior = 0;
            campfireObject.ShowInWorld(0);
        }
        public void Onentered(object sender, PlayerEventArgs e)
        {
            e.Player.SendClientMessage("{0E6307}Вы чувствуете тепло от костра.");
            var p  = (Player)e.Player;
            p.parameters.nearCampFire = true;
        }
        public void OnExit(object sender, PlayerEventArgs e)
        {
            e.Player.SendClientMessage("{0E6307}Вы больше не чувствуете тепло.");
            var p = (Player)e.Player;
            p.parameters.nearCampFire = false;
        }
        public static void Create(Vector3 pos)
        {
            campFires.Add(new CampFire(pos));
        }
        
        public void Delete()
        {
            campfireObject?.Dispose();
            position = Vector3.Zero;
            area.Enter -= Onentered;
            area.Leave -= OnExit;
            area?.Dispose();
        }
        public static void DeleteAll()
        {
            foreach (var item in campFires)
            {
                item.Delete();
            }
        }
        
    }
}

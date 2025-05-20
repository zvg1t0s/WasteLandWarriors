using SampSharp.GameMode.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.WorldObjects
{
    internal static class WorldMapZones
    {
        
        public static void Create(Player pl)
        {
            GangZone gz1 = new GangZone(87.0f, 1789.5f, 303f, 1943.5f);
            gz1.Color = new SampSharp.GameMode.SAMP.Color(0x7FFF00FF);
            gz1.Show(pl);

            GangZone gz2 = new GangZone(-459f, 2195.5f, -334f, 2273.5f);
            gz2.Color = new SampSharp.GameMode.SAMP.Color(0x7FFF00FF);
            gz2.Show(pl);
            GangZone gz3 = new GangZone(549f, 88.5f, 615f, 149.5f);
            gz3.Color = new SampSharp.GameMode.SAMP.Color(0x7FFF00FF);
            gz3.Show(pl);
            GangZone gz4 = new GangZone(549f, 88.5f, 615f, 149.5f);
            gz4.Color = new SampSharp.GameMode.SAMP.Color(0x00FF7FFF);
            gz4.Show(pl);
        }
    }
}

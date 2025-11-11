using SampSharp.GameMode.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.Systems.BiomeGenerator.BiomeObjectMiniGames
{
    public interface IBiomeObjectMiniGame
    {
         void Play(Player p, GeneratedObject obj);
        

        

    }
}

using SampSharp.GameMode;
using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.SAMP;
using SampSharp.GameMode.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.Systems
{
    internal class ApplyAnimationWithAttachedObjectManager
    {
        public static void ApplyAnimationWithAttachedObject(Player p,int index, Bone bone, int modelId, Vector3 position, Vector3 rotation, Vector3 scale, string lib, string name, float fDelta, bool loop = false, bool lockx = false, bool locky = false, bool freeze = false, int time = 1000)
        {
            p.ApplyAnimation(lib, name, fDelta, loop, lockx, locky, freeze, time);
            p.SetAttachedObject(9, modelId, bone, position,rotation,scale, 0, 0);
            Timer timer = new Timer(time, false);
            timer.Tick += Ticker;
            void Ticker(object sender, EventArgs e)
            {
            p.RemoveAttachedObject(9);
            timer.Dispose();
            }
            
        }
    }
}

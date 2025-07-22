using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Display;
using SampSharp.GameMode.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.Events
{
    internal class Authorization
    {
        public static void ShowAuth(Player p)
        {
            p.ToggleSpectating(true);
            p.InterpolateCameraPosition(new SampSharp.GameMode.Vector3(-831.23755, 664.3757, 62.61588), new SampSharp.GameMode.Vector3(2018.7303, 2957.5984, 60.81522), 110000, CameraCut.Move);
            p.InterpolateCameraLookAt(new SampSharp.GameMode.Vector3(-831.23755, 664.3757, 62.61588), new SampSharp.GameMode.Vector3(2018.7303, 2957.5984, 60.81522), 1000, CameraCut.Cut);
            var authDialog = new InputDialog("Spawn", "Spawn",true,"Да");
            authDialog.Response += authDialog_Response;
            authDialog.Show(p);

            void authDialog_Response(object sender, DialogResponseEventArgs e)
            {
                if(e.DialogButton == DialogButton.Left)
                {
                    p.SetSpawnInfo(0, 285, new SampSharp.GameMode.Vector3(2177.5847, 1584.5847, 1000), 270f);
                    p.Interior = 1;
                    p.VirtualWorld = 1010;
                    p.PutCameraBehindPlayer();
                    
                    
                    // WaterCount(this);
                    p.ToggleSpectating(false);
                    p.Spawn();
                }
            }
        }
        
    }
}

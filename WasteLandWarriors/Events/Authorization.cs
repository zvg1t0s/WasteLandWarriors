using SampSharp.Core.Natives.NativeObjects;
using SampSharp.GameMode;
using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Display;
using SampSharp.GameMode.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WasteLandWarriors.AC;
using WasteLandWarriors.Systems;

namespace WasteLandWarriors.Events
{
    internal class Authorization
    {
        public static void ShowAuth(Player p)
        {
            // p.ToggleSpectating(true);
            // p.InterpolateCameraPosition(new SampSharp.GameMode.Vector3(-831.23755, 664.3757, 62.61588), new SampSharp.GameMode.Vector3(2018.7303, 2957.5984, 60.81522), 110000, CameraCut.Move);
            // p.InterpolateCameraLookAt(new SampSharp.GameMode.Vector3(-831.23755, 664.3757, 62.61588), new SampSharp.GameMode.Vector3(2018.7303, 2957.5984, 60.81522), 1000, CameraCut.Cut);
            p.SendClientMessage("{276E2C}WASTELAND WARRIORS RPG: постапокалипсис.");
            p.SendClientMessage("{E09626}КЛАВИШИ: {BD0F0F}Y {969696}- инвентарь,{BD0F0F}N {969696}- меню, {BD0F0F}F {969696}- подобрать предмет.");
            p.SetTime(0, 0);
            p.SetWeather(20);

            // //1550.657, 1297.947, 255.852 , 1549.374, 1293.149, 255.272
            p.Position = new Vector3(1550.657, 1297.947, 255.852);
            RakcheatNatives.AC_SetPlayerPos(p, new Vector3(1550.657, 1297.947, 255.852));
            RakcheatNatives.AC_TogglePlayerSpectating(p, true);
            p.ToggleSpectating(true);
            
            //p.CameraPosition = new Vector3(1550.657, 1297.947, 255.852);
            p.VirtualWorld = 1021;
           // p.SetCameraLookAt(new Vector3(1549.374, 1293.149, 255.272), CameraCut.Cut);
            p.InterpolateCameraPosition(new SampSharp.GameMode.Vector3(1550.657, 1297.947, 255.852), new SampSharp.GameMode.Vector3(1550.657, 1299.947, 255.852), 11000, CameraCut.Cut);
            p.InterpolateCameraLookAt(new SampSharp.GameMode.Vector3(1549.374, 1293.149, 255.272), new SampSharp.GameMode.Vector3(1549.374, 1293.1411, 255.272), 1000, CameraCut.Cut);
            var authDialog = new InputDialog("{52F500}С возвращением.", $"{{76A5DE}}{p.Name},{{ABAD72}} приветствуем тебя на {{F27B0F}} Wasteland warriors RPG.\n\n\n\n{{ABAD72}}Данный сервер представляет из себя {{258F47}}выживание в условиях позднего апокалипсиса.\n\n\n{{54B85B}}Здесь ты столкнёшься с:\n\n\n-{{6DB3D6}} Опасностями выживания:{{3C7E9E}} добывай ресурсы и избегай опасных существ.\n\n{{6DB3D6}}- Персонажами:{{3C7E9E}} взаимодействуй с другими выжившими, создавай альянсы или сражайся.\n\n{{6DB3D6}}- Исследованием:{{3C7E9E}} путешествуй по заброшенным местам в поисках припасов.\n\n{{6DB3D6}}- Крафтом:{{3C7E9E}} создавай полезные предметы из найденных материалов.\n\n{{ED8A2D}}Разработка:\n\n{{ABAD72}}- Проект находится на стадии разработки и постоянно обновляется.\n\n\n{{DE3E37}}Присоединяйся к борьбе за выживание и выбери свой путь в безжалостном мире!", true,"Да");
            authDialog.Response += authDialog_Response;
            authDialog.Show(p);

            void authDialog_Response(object sender, DialogResponseEventArgs e)
            {
                if(e.DialogButton == DialogButton.Left)
                {
                    RakcheatNatives.AC_SetSpawnInfo(p.Id,0, 285, new SampSharp.GameMode.Vector3(2177.5847, 1584.5847, 1000), 270f);
                    p.SetSpawnInfo(0, 285, new SampSharp.GameMode.Vector3(2177.5847, 1584.5847, 1000), 270f);

                    p.user = new Entities.User();
                    p.PutCameraBehindPlayer();

                    p.isAuth = true;
                    RakcheatNatives.AC_SetPlayerPos(p, new SampSharp.GameMode.Vector3(2177.5847, 1584.5847, 1000));
                    RakcheatNatives.AC_TogglePlayerSpectating(p, false);
                    p.ToggleSpectating(false);
                    RakcheatNatives.AC_setInterior(p.Id, 1);
                    p.Interior = 1;
                    p.VirtualWorld = 1010;
                    p.diseases.Start();
                    p.warmCounter.Start();
                    p.humanity.Start();
                    p.timer.Count(p);

                    // p.Spawn();
                }
            }
        }
        
    }
}

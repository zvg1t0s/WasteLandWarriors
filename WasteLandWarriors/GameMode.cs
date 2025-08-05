
//using SampSharp.FCNPCs;
//using SampSharp.FCNPCs.Controllers;
//using SampSharp.FCNPCs.Definitions;
using SampSharp.GameMode;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.World;
using SampSharpGameMode1.Physics;
using System;

using System.Security.Cryptography.X509Certificates;
using System.Timers;
using WasteLandWarriors.Display;
using WasteLandWarriors.NPC;
using WasteLandWarriors.NPC.Definitions;
using WasteLandWarriors.Others;
using WasteLandWarriors.WorldObjects;
using WasteLandWarriors.NPC.Events;
using WasteLandWarriors.NPC.WorldNPCs;
using System.Collections.Generic;

namespace WasteLandWarriors
{
    public class GameMode : BaseMode
    {
        WorldPickUps PickUps;
        WorldActors Actors;

        public static List<CommonZombieNPC> zombies = new List<CommonZombieNPC>();
        
        protected override void OnInitialized(EventArgs e)
        {
            ColAndreas.Init();
            
            base.OnInitialized(e);
            
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine(" Blank game mode by your name here");
            Console.WriteLine("----------------------------------\n");

            LimitGlobalChatRadius(0);
            EnableStuntBonusForAll(false);
            DisableInteriorEnterExits();
            
            SetGameModeText("Wasteland Warriors");
            PickUps = new WorldPickUps();
            Actors = new WorldActors();
            WorldMappingObjects.Create();
            Loot.Create();
            Time.Create();
            WorldLootSpawnpoints.Create();
            CreateZombies();
            SpawnZombies();
            this.UsePlayerPedAnimations();
            
            /**
SetPlayerAttachedObject(playerid, 0, 2908, 2, 0.0649, 0.0609, 0.0099, -175.0001, 4.0999, 96.2998, 1.4110, 1.1290, 1.5080, 0, 0); // "zombiedildo" by BOMB0CLAT (Skin:0)
SetPlayerAttachedObject(playerid, 1, 19086, 1, -0.1620, 0.0120, -0.0579, -4.6999, 92.0998, 97.9001, 0.6130, 1.0000, 1.0000, 0, 0); // "zombiedildo" by BOMB0CLAT (Skin:0)
**/
            /**
            zombie.Player.SetAttachedObject(0, 2908, SampSharp.GameMode.Definitions.Bone.Head,new Vector3(0.0649, 0.0609, 0.0099), new Vector3(-175.0001, 4.0999, 96.2998), new Vector3(1.4110, 1.1290, 1.5080),0,0);
            zombie.Player.SetAttachedObject(1, 19086, SampSharp.GameMode.Definitions.Bone.Spine, new Vector3(-0.1620, 0.0120, -0.0579), new Vector3(-4.6999, 92.0998, 97.9001), new Vector3(0.6130, 1.0000, 1.0000), 0, 0);
            **/
            //Console.WriteLine(zombie.SetMoveMode);
            //zombie = FCNPC.Create("ZOMBIE_1");
            //float z = 0;
           // ColAndreas.FindZ_For2DCoord(338.84f, 1385.00f, out z);
           // zombie.Spawn(286, new SampSharp.GameMode.Vector3(253.37198, 1211.3707, 15.60604));
            
           // PedOnArea(zombie.Position, zombie.Id);

            //return Internal.RayCastLine(x, y, 700.0f, x, y, -1000.0f, out x, out y, out z);


            // TODO: Put logic to initialize your game mode here
        }
        
        public void CreateZombies()
        {
            
                zombies.Add(new CommonZombieNPC($"ZOMBIE_1", 162, new SampSharp.GameMode.Vector3(253.37198, 1211.3707, 15.60604)));
            //596,52094, 1645,4122, 6,5599513
            /**
(784,7288, 1662,6646, 5,218836) ammozm
(964,7449, 1352,0753, 10,303105) driverzm
(1004,89355, 1101,4694, 10,388075) fbizm
(1066,4968, 1010,26794, 10,563521) fbizm2
(1154,0922, 1074,6981, 10,561742) fbizm3
(1339,7965, 731,5763, 10,384528) morgzm3
(1388,4701, 792,1971, 10,393578) morgzm2
(1390,8749, 691,0026, 10,385381) morgzm1
(1632,6213, 644,72723, 10,388106) lvskladzm1
(1801,7239, 614,1105, 10,30313) trollzm
**/
            zombies.Add(new CommonZombieNPC($"ZOMBIE_2", 162, new SampSharp.GameMode.Vector3(784.7288, 1662.6646, 5.218836)));
            zombies.Add(new CommonZombieNPC($"ZOMBIE_3", 162, new SampSharp.GameMode.Vector3(964.7449, 1352.0753, 10.303105)));
            zombies.Add(new CommonZombieNPC($"ZOMBIE_4", 61, new SampSharp.GameMode.Vector3(1004.89355, 1101.4694, 10.388075)));
            zombies.Add(new CommonZombieNPC($"ZOMBIE_5", 61, new SampSharp.GameMode.Vector3(1066.4968, 1010.26794, 10.563521)));
            zombies.Add(new CommonZombieNPC($"ZOMBIE_6", 61, new SampSharp.GameMode.Vector3(596.52094, 1645.4122, 6.5599513)));
            zombies.Add(new CommonZombieNPC($"ZOMBIE_7", 61, new SampSharp.GameMode.Vector3(1390.8749, 691.0026, 10.385381)));
            zombies.Add(new CommonZombieNPC($"ZOMBIE_8", 61, new SampSharp.GameMode.Vector3(1390.8749, 691.0026, 10.385381)));
            zombies.Add(new CommonZombieNPC($"ZOMBIE_9", 61, new SampSharp.GameMode.Vector3(1390.8749, 691.0026, 10.385381)));
            zombies.Add(new CommonZombieNPC($"ZOMBIE_10", 61, new SampSharp.GameMode.Vector3(1390.8749, 691.0026, 10.385381)));
            zombies.Add(new CommonZombieNPC($"ZOMBIE_11", 61, new SampSharp.GameMode.Vector3(1390.8749, 691.0026, 10.385381)));
            zombies.Add(new CommonZombieNPC($"ZOMBIE_12", 61, new SampSharp.GameMode.Vector3(1390.8749, 691.0026, 10.385381)));
            zombies.Add(new CommonZombieNPC($"ZOMBIE_13", 61, new SampSharp.GameMode.Vector3(1390.8749, 691.0026, 10.385381)));
            zombies.Add(new CommonZombieNPC($"ZOMBIE_14", 61, new SampSharp.GameMode.Vector3(1390.8749, 691.0026, 10.385381)));
            zombies.Add(new CommonZombieNPC($"ZOMBIE_15", 61, new SampSharp.GameMode.Vector3(1390.8749, 691.0026, 10.385381)));
        }
        public void SpawnZombies()
        {
            foreach (var zombie in zombies) { 
                zombie.Spawn();
            }
            
        }
        
        protected override void OnPlayerUpdate(BasePlayer player, PlayerUpdateEventArgs e)
        {
            base.OnPlayerUpdate(player, e);
            
        }

        

        protected override void OnPlayerPickUpPickup(BasePlayer player, PickUpPickupEventArgs e)
        {
            PickUps.OnPickUp(player, e);
        }
       
        protected override void OnPlayerText(BasePlayer player, TextEventArgs e)
        {
            e.SendToPlayers = false;

            if (e.Text.Length <= 113)
            {
                foreach (Player p in Player.All)
                {
                    if (p.IsInRangeOfPoint(25, player.Position))
                    {
                        p.SendClientMessage($"{{ffffff}}{player.Name}[{player.Id}]: {e.Text}");
                    }
                }
            }


            base.OnPlayerText(player, e);
        }


    }
}
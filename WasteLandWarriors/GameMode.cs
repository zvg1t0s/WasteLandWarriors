
//using SampSharp.FCNPCs;
//using SampSharp.FCNPCs.Controllers;
//using SampSharp.FCNPCs.Definitions;
using SampSharp.GameMode;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.World;
using SampSharpGameMode1.Physics;
using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Timers;
using WasteLandWarriors.Display;
using WasteLandWarriors.Others;
using WasteLandWarriors.WorldObjects;

namespace WasteLandWarriors
{
    public class GameMode : BaseMode
    {
        WorldPickUps PickUps;
        WorldActors Actors;

        //FCNPC zombie;
        
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
            //zombie = FCNPC.Create("ZOMBIE_1");
            //float z = 0;
           // ColAndreas.FindZ_For2DCoord(338.84f, 1385.00f, out z);
           // zombie.Spawn(286, new SampSharp.GameMode.Vector3(253.37198, 1211.3707, 15.60604));
            
           // PedOnArea(zombie.Position, zombie.Id);

            //return Internal.RayCastLine(x, y, 700.0f, x, y, -1000.0f, out x, out y, out z);


            // TODO: Put logic to initialize your game mode here
        }
        public static SampSharp.GameMode.Vector3 GetPositionFrontOfPlayer(BasePlayer player, float distance = 8f)
        {
            float angle = player.InAnyVehicle ? player.Vehicle.Angle : player.Angle;
            angle = (float)(angle * Math.PI) / 180;
            return player.Position + new SampSharp.GameMode.Vector3(-distance * Math.Sin(angle), distance * Math.Cos(angle), 0);
        }
        /*
        public void PedOnArea(SampSharp.GameMode.Vector3 pos, int id)
        {
            var current = FCNPC.Find(id);
            var minutesTimer = new System.Timers.Timer(100);
            minutesTimer.Elapsed += OnTimedEvent;
            minutesTimer.Enabled = true;
            minutesTimer.AutoReset = true;
            
            void OnTimedEvent(object source, ElapsedEventArgs e)
            { 
                foreach(var p in Player.All)
                {
                    if(p.IsInRangeOfPoint(2, current.Position) && !p.IsNPC)
                    {
                        current.Stop();
                        current.MeleeAttack();
                        return;
                    }
                    if(p.IsInRangeOfPoint(50, current.Position) && !p.IsNPC)
                    {
                        current.SetAngleToPlayer(p);
                        current.StopAttack();
                        var playerPos = GetPositionFrontOfPlayer(p,1);
                       
                        
                        float zombiePosX = playerPos.X;
                        float zombiePosY = playerPos.Y;
                        float zombiePosZ = playerPos.Z;
                        
                        float z = 0;
                        var zombieposinfront = GetPositionFrontOfPlayer(current.Player, 1);
                        var zombieposinfront2 = GetPositionFrontOfPlayer(current.Player, 2);
                        var zombiepos = current.Position;
                        //ColAndreas.FindZ_For2DCoord(zombiePosX, zombiePosY, out zombiePosZ);
                        ColAndreas.FindZ_For2DCoord(zombieposinfront.X, zombieposinfront.Y, out z);
                        //p.SendClientMessage(ColAndreas.RayCastLine(current.Position, GetPositionFrontOfPlayer(current.Player, 3)));
                        
                        
                        // float z = col.RayCastLine(zombie1Pos.X, zombie1Pos.Y, 700.0f, zombiePosX, zombiePosY, -1000.0f, out zombiePosX, out zombiePosY, out zombiePosZ);
                        //current.Position
                        //current.ApplyAnimation("PED", "JOG_MALEA", 4.1f, false,false,false,false, 1);
                        current.SetAngleToPlayer(p);
                        current.GoTo(new SampSharp.GameMode.Vector3(zombieposinfront2.X, zombieposinfront2.Y, z),MoveType.Sprint);
                        
                    }
                    else
                    {
                       // current.Stop();
                    }
                }
            }
            }
        */
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
using SampSharp.GameMode;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.World;
using SampSharpGameMode1.Physics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using WasteLandWarriors.NPC.Definitions;

namespace WasteLandWarriors.NPC.WorldNPCs
{
    public class CommonZombieNPC
    {
        private FCNPC zombie;
        public delegate void ZombieEventsHandler();
        Vector3 position;
        private int skin;
        private Player target;
        public event ZombieEventsHandler OnUpdate;


        public CommonZombieNPC(string Name,int skin, Vector3 position)
        {
            
            zombie = FCNPC.Create(Name);

            this.position = position;
            this.skin = skin;
            
        }
        public async Task Spawn()
        {
            zombie.Spawn(skin,position);
            await CheckForPlayers();
        }
        public void Spawn(Vector3 newPosition)
        {
            zombie.Spawn(skin, newPosition);
            
        }




        async Task CheckForPlayers()
        {
             
            
                var npc = this.zombie;
            while (true)
            {
                await Task.Delay(100);
                foreach (var p in Player.All)
                {

                    if (!p.IsNPC && p.IsConnected && p.VirtualWorld == 0 && ((target == p) || (target == null)))
                    {
                        if (p.IsInRangeOfPoint(1, npc.Position))
                        {
                            target = (Player)p;
                            //npc.SetAngleToPlayer(p);

                            npc.MeleeAttack();

                            p.TakeDamage += TakeDamageHandler;

                            void TakeDamageHandler(object source, DamageEventArgs e)
                            {
                                if (e.OtherPlayer == npc.Player)
                                {
                                    p.Health -= 5;
                                    p.PlaySound(32402);
                                }
                            }

                        }
                        else if (p.IsInRangeOfPoint(50, npc.Position))
                        {
                            target = (Player)p;
                            npc.SetAngleToPlayer(p);

                            var playerPos = GetPositionFrontOfPlayer(p, 0.5f);


                            float playerposx = playerPos.X;
                            float playerposy = playerPos.Y;
                            float playerposz = playerPos.Z;
                            ColAndreas.FindZ_For2DCoord(playerposx, playerposy, out playerposz);
                            float NpcHeight;

                            ColAndreas.FindZ_For2DCoord(npc.Position.X, npc.Position.Y, out NpcHeight);
                            npc.GivePosition(new SampSharp.GameMode.Vector3(0, 0, NpcHeight + 1 - npc.Position.Z));

                            npc.GoTo(new SampSharp.GameMode.Vector3(playerposx, playerposy, playerposz + 1), (int)MoveType.Sprint, MoveSpeed.Sprint, (int)MoveMode.ColAndreas, (int)PathFinding.None, 0, false);


                        }
                        else
                        {
                            target = null;
                            // current.Stop();
                        }
                    }

                }
            }
        }
            
        
        
        public static SampSharp.GameMode.Vector3 GetPositionFrontOfPlayer(BasePlayer player, float distance = 8f)
        {
            float angle = player.InAnyVehicle ? player.Vehicle.Angle : player.Angle;
            angle = (float)(angle * Math.PI) / 180;
            return player.Position + new SampSharp.GameMode.Vector3(-distance * Math.Sin(angle), distance * Math.Cos(angle), 0);
        }




    }
}

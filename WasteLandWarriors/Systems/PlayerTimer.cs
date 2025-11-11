using SampSharp.GameMode.SAMP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace WasteLandWarriors.Systems
{
    public class PlayerTimer
    {
        public Timer millsecTimer = new Timer(100,true);
        static int waterCounterTick = 0;
        static int hungerCounterTick = 0;
        //private static Timer foodTimer = new Timer(20000, true);
        public void Count(Player p)
        {
            
            millsecTimer.Tick += OnWaterTimedEvent;
          

            
            millsecTimer.Tick += OnHungerTimedEvent;
            
            
            void OnWaterTimedEvent(object source, EventArgs e)
            {
                waterCounterTick++;
                if (waterCounterTick == 140)
                {
                    waterCounterTick = 0;
                    if (!p.IsNPC && p.isAuth && !p.IsDisposed)
                    {
                        if (p.waterNum >= 0)
                        {
                            p.waterNum--;
                        }

                        p.playerInterface.WaterNum.Text = p.waterNum.ToString();

                        if (p.waterNum <= 80)
                        {
                            p.playerInterface.WaterPng.ForeColor = -8781569;
                        }
                        else if (p.waterNum <= 40)
                        {
                            p.playerInterface.WaterPng.ForeColor = -1358954241;
                        }
                        else 
                        {
                            p.playerInterface.WaterPng.ForeColor = -1;
                        }
                        if (p.waterNum <= 0)
                        {
                            p.Health -= 10;
                            p.SendClientMessage("{ED0C0C}[ОПАСНОСТЬ]:{FFFFFF}Вы умираете от жажды, вам срочно нужно попить!");
                        }
                    }
                    
                }
            }

            void OnHungerTimedEvent(object source, EventArgs e)
            {
                hungerCounterTick++;
                if (hungerCounterTick == 200)
                {
                    hungerCounterTick = 0;
                    if (!p.IsNPC && p.isAuth && !p.IsDisposed)
                    {
                        if (p.hungerNum >= 0)
                        {
                            p.hungerNum--;
                        }

                        p.playerInterface.EatNum.Text = p.hungerNum.ToString();

                        if (p.hungerNum <= 80)
                        {
                            p.playerInterface.EatPNG.ForeColor = -8781569;
                        }
                        else if (p.hungerNum <= 40)
                        {
                            p.playerInterface.EatPNG.ForeColor = -1358954241;
                        }
                        else
                        {
                            p.playerInterface.EatPNG.ForeColor = -1;
                         
                        }
                        if (p.hungerNum <= 0)
                        {
                            p.Health -= 10;
                            p.SendClientMessage("{ED0C0C}[ОПАСНОСТЬ]:{FFFFFF}Вы умираете от голода, вам срочно нужно поесть!");
                        }
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasteLandWarriors.Entities;

namespace WasteLandWarriors.Systems
{
    public class HumanityCounter
    {
         int TickCounter = 0;
        public Player player;
        public HumanityCounter(Player p) {
            
            player = p;
        }
        public void Start()
        {
            player.timer.millsecTimer.Tick += OnHumanityTimedEvent;
        }
        private void OnHumanityTimedEvent(object sender, EventArgs e)
        {
            TickCounter++;
            if (TickCounter >= 10)
            {
                TickCounter = 0;
                if (player.parameters.humanityNum == 0)
                {
                    return;
                }
                if (player.VirtualWorld == 0 && WeatherSystem.weatherType == weatherType.Storm)
                {
                    if (player.parameters.respirator == 0)
                    {
                        player.parameters.humanityNum -= 10;
                        player.playerInterface.imunNum.Text = (player.parameters.humanityNum / 10).ToString();
                        HumanityPngColorSet();
                    }
                    else if (player.parameters.respirator > 0) { 
                        player.parameters.humanityNum -= 5;
                        player.playerInterface.imunNum.Text = (player.parameters.humanityNum / 10).ToString();
                        HumanityPngColorSet();
                    }
                }
            }
        }
        public void HumanityPngColorSet()
        {
            if (player.parameters.humanityNum < 700)
            {
                player.playerInterface.imunPng.ForeColor = -8781569;
            }
            else if (player.parameters.humanityNum < 300)
            {
                player.playerInterface.imunPng.ForeColor = -1358954241;
            }
            else
            {
                player.playerInterface.imunPng.ForeColor = -1;
            }
        }
    }
}

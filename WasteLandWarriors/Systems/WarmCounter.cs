using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasteLandWarriors.Display;

namespace WasteLandWarriors.Systems
{
    public class WarmCounter
    {
        int TickCounter = 0;
        Player player;
        
        public WarmCounter(Player p)
        {
            player = p;
          //  player.timer.millsecTimer.Tick += OnTimedEvent;
        }
        public void Start()
        {
            player.timer.millsecTimer.Tick += OnTimedEvent;
        }
        public void WarmMinuser()
        {
            int currentHour = Time.GetHours();
            int warmminus = 0;

            if (player.VirtualWorld == 1010 || player.parameters.nearCampFire)
            {
                if (player.parameters.bodyTemp + 10 < 1000)
                {
                    player.parameters.bodyTemp += 10;
                    player.playerInterface.OdejdaNum.Text = ((player.parameters.bodyTemp) / 10).ToString();
                }
                if (player.parameters.clothWet - 4 > 0)
                {


                    player.parameters.clothWet -= 4;
                }
            }
            if (player.VirtualWorld == 0 && !player.parameters.nearCampFire)
            {
                if (currentHour >= 22 && currentHour <= 6) warmminus += 9;
                else if ((currentHour >= 7 && currentHour <= 10) || (currentHour >= 18 && currentHour <= 21)) warmminus += 5;


                if (WeatherSystem.weatherType == weatherType.Rainy)
                {
                    warmminus += 3;
                    if (player.parameters.clothWet + 10 <= 1000)
                    {
                        player.parameters.clothWet += 10;
                    }
                    else
                    {
                        player.parameters.clothWet = 1000;
                    }

                }
                else if (WeatherSystem.weatherType != weatherType.Rainy)
                {
                    if (player.parameters.clothWet - 2 >= 0)
                    {
                        player.parameters.clothWet -= 2;
                    }
                    else
                    {
                        player.parameters.clothWet = 0;
                    }
                }
                switch (player.parameters.clothesType)
                {
                    case Entities.ClothesType.Normal:
                        warmminus /= 2;
                        break;
                    case Entities.ClothesType.Warm:
                        warmminus /= 4;
                        break;

                }
                if (player.parameters.clothWet >= 300 && player.parameters.clothWet < 700)
                {
                    warmminus += 3;
                    player.playerInterface.clothPng.ForeColor = 0x024BA8FF;
                }
                else if (player.parameters.clothWet >= 700)
                {
                    player.playerInterface.clothPng.ForeColor = 0x024BA8FF;
                    warmminus += 6;
                }
                else
                {
                    player.playerInterface.clothPng.ForeColor = 255;
                }
                if (player.parameters.bodyTemp > 0)
                {

                    player.parameters.bodyTemp -= warmminus;
                    player.playerInterface.OdejdaNum.Text = ((player.parameters.bodyTemp) / 10).ToString();
                }
                if (player.parameters.bodyTemp > 700)
                {
                    player.playerInterface.OdejdaPng.ForeColor = -1;
                }
                else if (player.parameters.bodyTemp > 300 && player.parameters.bodyTemp <= 700)
                {
                    player.playerInterface.OdejdaPng.ForeColor = 0xFFFF08FF;
                }
                else
                {
                    player.playerInterface.OdejdaPng.ForeColor = 0xFF1717FF;
                }
                return;
            }

        }
        public void OnTimedEvent(object sender, EventArgs e)
        {
            TickCounter++;
            if (TickCounter >= 25)
            {

                WarmMinuser();

                TickCounter = 0;
            }
        }
    }
}

using SampSharp.GameMode.SAMP;
using SampSharp.GameMode.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.Systems
{
    public class WeatherSystem
    {
        public static int weatherId = 0;
        public static weatherType weatherType = weatherType.Normal;
        public static void NextWeather()
        {
            
            Random r = new Random();
            int nextweatherR = r.Next(6);
            if (nextweatherR < 3)
            {
                weatherId = 20;
                weatherType = weatherType.Normal;

                Player.All?.ToList().ForEach(t => { if (!t.IsDisposed) SetWeather(t); });


            }
            else if(nextweatherR >= 3 && nextweatherR <= 4)
            {
                weatherId = 8;
                weatherType = weatherType.Rainy;
                
                Player.All?.ToList().ForEach(t => { if (!t.IsDisposed) t.SendClientMessage("{FFEAA1}[ПОГОДА]:{FFFFFF} На поверхности идет дождь, воздух насыщен влагой.");
                    t.SendClientMessage("{FFEAA1}[ПОГОДА]:{FFFFFF} Найдите укрытие или дождевик чтобы не промокнуть!");
                    SetWeather(t);});

            }
            else if (nextweatherR > 4)
            {
                weatherId = 19;
                weatherType = weatherType.Storm;
                
                Player.All?.ToList().ForEach(t => { if (!t.IsDisposed) t.SendClientMessage("{FFEAA1}[ПОГОДА]:{FFFFFF} Началась буря, небо затянуто темными облаками.");
                    t.SendClientMessage("{FFEAA1}[ПОГОДА]:{FFFFFF} Радиоактивная пыль поднимается в воздух, найдите укрытие немедленно!");
                    SetWeather(t); });

            }
        }
        public static void SetWeather(BasePlayer p)
        {
            if(weatherType == weatherType.Normal)
            {
                if (p.VirtualWorld == 0 && !p.IsDisposed) p.SetWeather(20);
                
            }
            if (weatherType == weatherType.Rainy)
            {
                if (p.VirtualWorld == 0 && !p.IsDisposed) p.SetWeather(8); 

            }
            if (weatherType == weatherType.Storm)
            {
                if (p.VirtualWorld == 0 && !p.IsDisposed) p.SetWeather(19);

            }
        }
    }
    public enum weatherType
    {
        Normal = 0,
        Rainy = 1,
        Storm = 2,
    }
}

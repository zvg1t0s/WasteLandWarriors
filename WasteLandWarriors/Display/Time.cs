using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Display;
using SampSharp.GameMode.SAMP;
using SampSharp.GameMode.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using WasteLandWarriors.Systems;

namespace WasteLandWarriors.Display
{
    public class Time
    {
        static TextDraw TimePNG = new TextDraw(new SampSharp.GameMode.Vector2(88.0f, 319.0f), "0");
         static int minutes = 0;
         static int hours = 12;
        public static int GetHours()
        {
            return hours;
        }
        public static void Create()
        {
            TimePNG.Font = TextDrawFont.Pricedown;
            TimePNG.LetterSize = new SampSharp.GameMode.Vector2(0.279166f, 1.299998f);
            TimePNG.Outline = 2;
            TimePNG.Width = 405.5f;
            TimePNG.Height = 28.0f;
            TimePNG.Shadow = 0;
            TimePNG.Alignment = TextDrawAlignment.Center;
            TimePNG.ForeColor = 1433087999;
            TimePNG.BackColor = 255;
            TimePNG.BoxColor = 50;
            TimePNG.UseBox = true;
            TimePNG.Proportional = true;
            TimePNG.Selectable = false;
            var minutesTimer = new System.Timers.Timer(3500);
            minutesTimer.Elapsed += OnTimedEvent;
            minutesTimer.Enabled = true;
            minutesTimer.AutoReset = true;
            void OnTimedEvent(object source, ElapsedEventArgs e)
            {
                minutes++;

                if (minutes == 60)
                {
                    minutes = 0;
                    hours++;
                    if (hours == 24)
                    {
                        hours = 0;
                        minutes = 0;
                    }
                }
                if (minutes < 10 && hours < 10)
                {
                    TimePNG.Text = $"0{hours}:0{minutes}";
                }
                else if (hours >= 10 && minutes < 10)
                {
                    TimePNG.Text = $"{hours}:0{minutes}";
                }
                else if (hours < 10 && minutes >= 10)
                {
                    TimePNG.Text = $"0{hours}:{minutes}";
                }
                else if (hours >= 10 && minutes >= 10)
                {
                    TimePNG.Text = $"{hours}:{minutes}";
                }

                Player.All?.ToList().ForEach(t => { if (t.VirtualWorld == 0 && t.Interior == 0 && !t.IsDisposed) t.SetTime(hours, minutes); });
                if(minutes == 15)
                {
                    WeatherSystem.NextWeather();
                }
                
            }

        }
        public static void SetTimeTo(BasePlayer p)
        {
            p.SetTime(hours,minutes);
            WeatherSystem.SetWeather(p);
        }
        public static void Show(Player p)
        {
            
            TimePNG.Show(p);
        }
        public static void Hide(Player p)
        {
            TimePNG.Hide(p);
        }

    }
}

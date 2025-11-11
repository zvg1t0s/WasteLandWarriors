using SampSharp.GameMode;
using SampSharp.GameMode.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.Display
{
    public class Speedo
    {
        public  PlayerTextDraw Speedometer;
        public  PlayerTextDraw Fuel;
        public  PlayerTextDraw Accum;
        Player player;
        public Speedo(Player player)
        {
            this.player = player;
        }
        public void Create()
        {
            Speedometer = new PlayerTextDraw(player,new Vector2(88.0f, 424.0f), "0_km/h");
            Fuel = new PlayerTextDraw(player,new Vector2(141.0f, 424.0f), "F");
            Accum = new PlayerTextDraw(player, new Vector2(44.0, 424.0), "+/-");
            Speedometer.Font = SampSharp.GameMode.Definitions.TextDrawFont.Pricedown;
            Speedometer.LetterSize = new Vector2(0.266665f, 0.999997f);
            Speedometer.Outline = 1;
            Speedometer.Shadow = 0;
            Speedometer.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Center;
            Speedometer.ForeColor = 1433087999;
            Speedometer.BackColor = 255;
            Speedometer.BoxColor = 50;
            Speedometer.UseBox = false;
            Speedometer.Proportional = true;
            Speedometer.Selectable = false;

            Fuel.Font = SampSharp.GameMode.Definitions.TextDrawFont.Pricedown;
            Fuel.LetterSize = new Vector2(0.266665, 0.999997);
            Fuel.Outline = 1;
            Fuel.Shadow = 0;
            Fuel.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Center;
            Fuel.ForeColor = -1962934017;
            Fuel.BackColor = 255;
            Fuel.BoxColor = 50;
            Fuel.UseBox = false;
            Fuel.Proportional = true;
            Fuel.Selectable = false;

            Accum.Font = SampSharp.GameMode.Definitions.TextDrawFont.Pricedown;
            Accum.LetterSize = new Vector2(0.266665, 0.999997);
            Accum.Outline = 1;
            Accum.Shadow = 0;
            Accum.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Center;
            Accum.ForeColor = 16711935;
            Accum.BackColor = 255;
            Accum.BoxColor = 50;
            Accum.UseBox = false;
            Accum.Proportional = true;
            Accum.Selectable = false;
        }
        public void Show()
        {
            Speedometer.Show();
            Fuel.Show();
            Accum.Show();

        }
        public void Hide()
        {
            Speedometer.Hide();
            Fuel.Hide();
            Accum.Hide();
        }

        
        
    }
}

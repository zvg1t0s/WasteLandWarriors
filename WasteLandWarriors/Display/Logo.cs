using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.Display
{
    internal class Logo
    {

        Player p;
        public Logo(Player p)
        {
            this.p = p;
        }
        public void Show()
        {
            PlayerTextDraw wasteland = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(547.0f, 23.0f), "wasteland");
            wasteland.Font = TextDrawFont.Pricedown;
            wasteland.LetterSize = new SampSharp.GameMode.Vector2(0.208333f, 1.349997f);
            wasteland.Width = 400;
            wasteland.Height = 17;
            wasteland.Outline = 1;
            wasteland.Shadow = 0;
            wasteland.Alignment = TextDrawAlignment.Left;
            wasteland.ForeColor = -984082177;
            wasteland.BackColor = 255;
            wasteland.BoxColor = 50;
            wasteland.UseBox = false;
            wasteland.Proportional = true;
            wasteland.Selectable = false;
            wasteland.Show();

            PlayerTextDraw warriors = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(560.0f, 4.0f), "Warriors");
            warriors.Font = TextDrawFont.Diploma;
            warriors.LetterSize = new SampSharp.GameMode.Vector2(0.420832, 2.049998);
            warriors.Width = 400;
            warriors.Height = 17;
            warriors.Outline = 1;
            warriors.Shadow = 1;
            warriors.Alignment = TextDrawAlignment.Left;
            warriors.ForeColor = 1513890047;
            warriors.BackColor = 0;
            warriors.BoxColor = 50;
            warriors.UseBox = false;
            warriors.Proportional = true;
            warriors.Selectable = false;
            warriors.Show();
        }
    }
}

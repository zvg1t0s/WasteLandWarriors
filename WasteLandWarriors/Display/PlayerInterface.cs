using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.Display
{
    internal class PlayerInterface
    {
        private Player p;
        PlayerTextDraw booms;
        PlayerTextDraw EatPNG;
        PlayerTextDraw EatNum;
        PlayerTextDraw WaterPng;
        PlayerTextDraw WaterNum;
        PlayerTextDraw RadPng;
        PlayerTextDraw RadNum;
        PlayerTextDraw DangerPlate;
        PlayerTextDraw menuPlate1;
        PlayerTextDraw boomsTurn;
        PlayerTextDraw healthMenuPNG;
        PlayerTextDraw carMenuPNG;
        PlayerTextDraw CostumeMenuPNG;
        PlayerTextDraw menuPlate2;
        PlayerTextDraw menuPlate3;
        PlayerTextDraw menuPlate4;
        PlayerTextDraw menuPlate5;
        PlayerTextDraw mMenuPNG;
        PlayerTextDraw BackPlate;
        public PlayerInterface(Player player) {
            p = player;

        }
        public void Create()
        {
            booms = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(513.0f, 9.0f), "100");
            booms.Font = TextDrawFont.Normal;
            booms.LetterSize = new SampSharp.GameMode.Vector2(0.345833f, 1.799998f);
            booms.Outline = 1;
            booms.Shadow = 0;
            booms.Alignment = TextDrawAlignment.Left;
            booms.ForeColor = -1;
            booms.BoxColor = 50;
            booms.UseBox = false;
            booms.Proportional = true;
            booms.Selectable = false;
            

            EatPNG = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(614.0f, 6.0f), "HUD:radar_datefood");

            EatPNG.Font = TextDrawFont.DrawSprite;
            EatPNG.LetterSize = new SampSharp.GameMode.Vector2(0.6, 2.0);
            EatPNG.Width = 17;
            EatPNG.Height = 17;
            EatPNG.Outline = 1;
            EatPNG.Shadow = 0;
            EatPNG.Alignment = TextDrawAlignment.Left;
            EatPNG.ForeColor = -1;
            EatPNG.BackColor = 255;
            EatPNG.BoxColor = 50;
            EatPNG.UseBox = true;
            EatPNG.Proportional = true;
            EatPNG.Selectable = false;
            
            

            EatNum = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(617.0f, 23.0f), "100");

            
            EatNum.Text = "100";
            EatNum.Font = TextDrawFont.Normal;
            EatNum.LetterSize = new SampSharp.GameMode.Vector2(0.191667f, 1.2f);
            EatNum.Width = 17;
            EatNum.Height = 17;
            EatNum.Outline = 1;
            EatNum.Shadow = 0;
            EatNum.Alignment = TextDrawAlignment.Left;
            EatNum.ForeColor = 1433087999;
            EatNum.BackColor = 255;
            EatNum.BoxColor = 50;
            EatNum.UseBox = false;
            EatNum.Proportional = true;
            EatNum.Selectable = false;
            

            WaterPng = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(614.0f, 36.0f), "HUD:radar_diner");

            WaterPng.Font = TextDrawFont.DrawSprite;
            WaterPng.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            WaterPng.Width = 17;
            WaterPng.Height = 17;
            WaterPng.Outline = 1;
            WaterPng.Shadow = 0;
            WaterPng.Alignment = TextDrawAlignment.Left;
            WaterPng.ForeColor = -1;
            WaterPng.BackColor = 255;
            WaterPng.BoxColor = 50;
            WaterPng.UseBox = true;
            WaterPng.Proportional = true;
            WaterPng.Selectable = false;
            

            WaterNum = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(617.0f, 53.0f), "100");

            WaterNum.Font = TextDrawFont.Normal;
            WaterNum.LetterSize = new SampSharp.GameMode.Vector2(0.191667f, 1.2f);
            WaterNum.Width = 17;
            WaterNum.Height = 17;
            WaterNum.Outline = 1;
            WaterNum.Shadow = 0;
            WaterNum.Alignment = TextDrawAlignment.Left;
            WaterNum.ForeColor = 1433087999;
            WaterNum.BackColor = 255;
            WaterNum.BoxColor = 50;
            WaterNum.UseBox = false;
            WaterNum.Proportional = true;
            WaterNum.Selectable = false;
            

            RadPng = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(614.0f, 66.0f), "HUD:radar_locosyndicate");

            RadPng.Font = TextDrawFont.DrawSprite;
            RadPng.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            RadPng.Width = 17;
            RadPng.Height = 17;
            RadPng.Outline = 1;
            RadPng.Shadow = 0;
            RadPng.Alignment = TextDrawAlignment.Left;
            RadPng.ForeColor = -1;
            RadPng.BackColor = 255;
            RadPng.BoxColor = 50;
            RadPng.UseBox = true;
            RadPng.Proportional = true;
            RadPng.Selectable = false;
            

            RadNum = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(617.0f, 84.0f), "0.5");

            RadNum.Font = TextDrawFont.Normal;
            RadNum.LetterSize = new SampSharp.GameMode.Vector2(0.191667f, 1.2f);
            RadNum.Width = 17;
            RadNum.Height = 17;
            RadNum.Outline = 1;
            RadNum.Shadow = 0;
            RadNum.Alignment = TextDrawAlignment.Left;
            RadNum.ForeColor = -1;
            RadNum.BackColor = 255;
            RadNum.BoxColor = 50;
            RadNum.UseBox = false;
            RadNum.Proportional = true;
            RadNum.Selectable = false;
            

            DangerPlate = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(609.0f, 95.0f), "DANGER!");

            DangerPlate.Font = TextDrawFont.Normal;
            DangerPlate.LetterSize = new SampSharp.GameMode.Vector2(0.183330, 1.799998);
            DangerPlate.Width = 400;
            DangerPlate.Height = 17;
            DangerPlate.Outline = 1;
            DangerPlate.Shadow = 0;
            DangerPlate.Alignment = TextDrawAlignment.Left;
            DangerPlate.ForeColor = -16776961;
            DangerPlate.BackColor = 255;
            DangerPlate.BoxColor = 50;
            DangerPlate.UseBox = false;
            DangerPlate.Proportional = true;
            DangerPlate.Selectable = false;
            

            menuPlate1 = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(620.0f, 318.0f), "_");

            menuPlate1.Font = TextDrawFont.Diploma;
            menuPlate1.LetterSize = new SampSharp.GameMode.Vector2(0.6, 13.399991);
            menuPlate1.Width = 251.5f;
            menuPlate1.Height = 21.5f;
            menuPlate1.Outline = 1;
            menuPlate1.Shadow = 0;
            menuPlate1.Alignment = TextDrawAlignment.Center;
            menuPlate1.ForeColor = -1;
            menuPlate1.BackColor = 255;
            menuPlate1.BoxColor = 135;
            menuPlate1.UseBox = true;
            menuPlate1.Proportional = true;
            menuPlate1.Selectable = false;
            

            //PlayerTD[playerid][11] = CreatePlayerTextDraw(playerid, 612.000000, 345.000000, "LD_SHTR:ps3");
            boomsTurn = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(612.0f, 345.0f), "LD_SHTR:ps3");

            boomsTurn.Font = TextDrawFont.DrawSprite;
            boomsTurn.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            boomsTurn.Width = 17;
            boomsTurn.Height = 17;
            boomsTurn.Outline = 1;
            boomsTurn.Shadow = 0;
            boomsTurn.Alignment = TextDrawAlignment.Left;
            boomsTurn.ForeColor = -1;
            boomsTurn.BackColor = 255;
            boomsTurn.BoxColor = 50;
            boomsTurn.UseBox = false;
            boomsTurn.Proportional = true;
            boomsTurn.Selectable = true;
            
            

            //PlayerTD[playerid][12] = CreatePlayerTextDraw(playerid, 612.000000, 370.000000, "hud:radar_girlfriend");
            healthMenuPNG = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(612.0f, 370.0f), "hud:radar_girlfriend");
            //PlayerTD[playerid][13] = CreatePlayerTextDraw(playerid, 612.000000, 395.000000, "hud:radar_impound");

            healthMenuPNG.Font = TextDrawFont.DrawSprite;
            healthMenuPNG.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            healthMenuPNG.Width = 17;
            healthMenuPNG.Height = 17;
            healthMenuPNG.Outline = 1;
            healthMenuPNG.Shadow = 0;
            healthMenuPNG.Alignment = TextDrawAlignment.Left;
            healthMenuPNG.ForeColor = -1;
            healthMenuPNG.BackColor = 255;
            healthMenuPNG.BoxColor = 50;
            healthMenuPNG.UseBox = false;
            healthMenuPNG.Proportional = true;
            healthMenuPNG.Selectable = true;
            

            

            carMenuPNG = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(612.0f, 395.0f), "hud:radar_impound");
            // PlayerTD[playerid][14] = CreatePlayerTextDraw(playerid, 612.000000, 420.000000, "hud:radar_gangP");

            carMenuPNG.Font = TextDrawFont.DrawSprite;
            carMenuPNG.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            carMenuPNG.Width = 17;
            carMenuPNG.Height = 17;
            carMenuPNG.Outline = 1;
            carMenuPNG.Shadow = 0;
            carMenuPNG.Alignment = TextDrawAlignment.Left;
            carMenuPNG.ForeColor = -1;
            carMenuPNG.BackColor = 255;
            carMenuPNG.BoxColor = 50;
            carMenuPNG.UseBox = false;
            carMenuPNG.Proportional = true;
            carMenuPNG.Selectable = true;
            

            CostumeMenuPNG = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(612.0f, 420.0f), "hud:radar_gangP");
            //PlayerTD[playerid][15] = CreatePlayerTextDraw(playerid, 620.000000, 317.000000, "_");

            CostumeMenuPNG.Font = TextDrawFont.DrawSprite;
            CostumeMenuPNG.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            CostumeMenuPNG.Width = 17;
            CostumeMenuPNG.Height = 17;
            CostumeMenuPNG.Outline = 1;
            CostumeMenuPNG.Shadow = 0;
            CostumeMenuPNG.Alignment = TextDrawAlignment.Left;
            CostumeMenuPNG.ForeColor = -1;
            CostumeMenuPNG.BackColor = 255;
            CostumeMenuPNG.BoxColor = 50;
            CostumeMenuPNG.UseBox = false;
            CostumeMenuPNG.Proportional = true;
            CostumeMenuPNG.Selectable = true;
            

            menuPlate2 = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(620.0f, 317.0f), "_");
            //PlayerTD[playerid][16] = CreatePlayerTextDraw(playerid, 620.000000, 441.000000, "_");

            menuPlate2.Font = TextDrawFont.Normal;
            menuPlate2.LetterSize = new SampSharp.GameMode.Vector2(0.6, 0.049988);
            menuPlate2.Width = 251.5f;
            menuPlate2.Height = 27.5f;
            menuPlate2.Outline = 1;
            menuPlate2.Shadow = 0;
            menuPlate2.Alignment = TextDrawAlignment.Center;
            menuPlate2.ForeColor = -1;
            menuPlate2.BackColor = 255;
            menuPlate2.BoxColor = 255;
            menuPlate2.UseBox = true;
            menuPlate2.Proportional = true;
            menuPlate2.Selectable = false;
            


            menuPlate3 = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(620.0f, 441.0f), "_");

            menuPlate3.Font = TextDrawFont.Normal;
            menuPlate3.LetterSize = new SampSharp.GameMode.Vector2(0.6, 0.049988);
            menuPlate3.Width = 251.5f;
            menuPlate3.Height = 27.5f;
            menuPlate3.Outline = 1;
            menuPlate3.Shadow = 0;
            menuPlate3.Alignment = TextDrawAlignment.Center;
            menuPlate3.ForeColor = -1;
            menuPlate3.BackColor = 255;
            menuPlate3.BoxColor = 255;
            menuPlate3.UseBox = true;
            menuPlate3.Proportional = true;
            menuPlate3.Selectable = false;
            

            //PlayerTD[playerid][17] = CreatePlayerTextDraw(playerid, 606.799987, 317.000000, "_");
            menuPlate4 = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(606.799987f, 317.0f), "_");

            menuPlate4.Font = TextDrawFont.Normal;
            menuPlate4.LetterSize = new SampSharp.GameMode.Vector2(0.6, 13.549992);
            menuPlate4.Width = 251.5f;
            menuPlate4.Height = 1.5f;
            menuPlate4.Outline = 1;
            menuPlate4.Shadow = 0;
            menuPlate4.Alignment = TextDrawAlignment.Center;
            menuPlate4.ForeColor = -1;
            menuPlate4.BackColor = 255;
            menuPlate4.BoxColor = 255;
            menuPlate4.UseBox = true;
            menuPlate4.Proportional = true;
            menuPlate4.Selectable = false;
            

            //PlayerTD[playerid][18] = CreatePlayerTextDraw(playerid, 633.200012, 317.000000, "_");

            menuPlate5 = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(633.200012f, 317.0f), "_");

            menuPlate5.Font = TextDrawFont.Normal;
            menuPlate5.LetterSize = new SampSharp.GameMode.Vector2(0.6, 13.549992);
            menuPlate5.Width = 251.5f;
            menuPlate5.Height = 1.5f;
            menuPlate5.Outline = 1;
            menuPlate5.Shadow = 0;
            menuPlate5.Alignment = TextDrawAlignment.Center;
            menuPlate5.ForeColor = -1;
            menuPlate5.BackColor = 255;
            menuPlate5.BoxColor = 255;
            menuPlate5.UseBox = true;
            menuPlate5.Proportional = true;
            menuPlate5.Selectable = false;
            


            //PlayerTD[playerid][19] = CreatePlayerTextDraw(playerid, 612.000000, 321.000000, "hud:radar_modGarage");
            mMenuPNG = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(612.0f, 321.0f), "hud:radar_modGarage");

            mMenuPNG.Font = TextDrawFont.DrawSprite;
            mMenuPNG.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            mMenuPNG.Width = 17;
            mMenuPNG.Height = 17;
            mMenuPNG.Outline = 1;
            mMenuPNG.Shadow = 0;
            mMenuPNG.Alignment = TextDrawAlignment.Left;
            mMenuPNG.ForeColor = -1;
            mMenuPNG.BackColor = 255;
            mMenuPNG.BoxColor = 50;
            mMenuPNG.UseBox = false;
            mMenuPNG.Proportional = true;
            mMenuPNG.Selectable = true;
            

            BackPlate = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(75.0f, 318.0f), "_");

            //19478
            BackPlate.Font = TextDrawFont.Normal;
            BackPlate.LetterSize = new SampSharp.GameMode.Vector2(0.808332f, 14.350014f);
            BackPlate.Outline = 1;
            BackPlate.Width = 101.5f;
            BackPlate.Height = 156.0f;
            BackPlate.Shadow = 0;
            BackPlate.Alignment = TextDrawAlignment.Center;
            BackPlate.ForeColor = -1;
            BackPlate.BackColor = 255;
            BackPlate.BoxColor = 50;
            BackPlate.UseBox = true;
            BackPlate.Proportional = true;
            BackPlate.Selectable = false;
            
        }
        public void Show()
        {
             booms.Show();
             EatPNG.Show();
             EatNum.Show();
             WaterPng.Show();
             WaterNum.Show();
             RadPng.Show();
             RadNum.Show();
             DangerPlate.Show();
             menuPlate1.Show();
             boomsTurn.Show();
             healthMenuPNG.Show();
             carMenuPNG.Show();
             CostumeMenuPNG.Show();
             menuPlate2.Show();
             menuPlate3.Show();
             menuPlate4.Show();
             menuPlate5.Show();
             mMenuPNG.Show();
             BackPlate.Show();
        }
        public void Hide()
        {
            booms.Hide();
            EatPNG.Hide();
            EatNum.Hide();
            WaterPng.Hide();
            WaterNum.Hide();
            RadPng.Hide();
            RadNum.Hide();
            DangerPlate.Hide();
            menuPlate1.Hide();
            boomsTurn.Hide();
            healthMenuPNG.Hide();
            carMenuPNG.Hide();
            CostumeMenuPNG.Hide();
            menuPlate2.Hide();
            menuPlate3.Hide();
            menuPlate4.Hide();
            menuPlate5.Hide();
            mMenuPNG.Hide();
            BackPlate.Hide();
        }
    }
}

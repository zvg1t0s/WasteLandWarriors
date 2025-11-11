using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Display;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.SAMP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasteLandWarriors.Others.Dialogs;

namespace WasteLandWarriors.Display
{
    public class PlayerInterface
    {
        private Player p;
        PlayerTextDraw booms;
        public PlayerTextDraw EatPNG;
        public PlayerTextDraw EatNum;
        public PlayerTextDraw WaterPng;
        public PlayerTextDraw WaterNum;
        public PlayerTextDraw RadPng;
        public PlayerTextDraw RadNum;
        public PlayerTextDraw DangerPlate;
        public PlayerTextDraw OdejdaPng;
        public PlayerTextDraw OdejdaNum;
        public PlayerTextDraw pissPng;
        public PlayerTextDraw pissNum;
        public PlayerTextDraw imunPng;
        public PlayerTextDraw imunNum;

        public PlayerTextDraw bonesPng;
        public PlayerTextDraw healthPng;
        public PlayerTextDraw clothPng;
        public PlayerTextDraw bleedPng;

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

        


        public static Color yellow = 0xFFFF08FF;
        public static Color red = 0xFF1717FF;
        public PlayerInterface(Player player) {
            p = player;
            p.ClickPlayerTextDraw += OnClickMenu;
            p.ClickPlayerTextDraw += OnClickCarMenu;
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
            

            EatPNG = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(614.000000, 169.000000), "HUD:radar_datefood");

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
            
            

            EatNum = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(618.000000, 186.000000), "99");

            
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
            

            WaterPng = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(614.000000, 199.000000), "HUD:radar_diner");

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
            

            WaterNum = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(618.000000, 216.000000), "99");

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


            /**
tempico[playerid] = CreatePlayerTextDraw(playerid, 614.000000, 199.000000, "hud:radar_tshirt");
PlayerTextDrawFont(playerid, tempico[playerid], 4);
PlayerTextDrawLetterSize(playerid, tempico[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, tempico[playerid], 17.000000, 17.000000);
PlayerTextDrawSetOutline(playerid, tempico[playerid], 1);
PlayerTextDrawSetShadow(playerid, tempico[playerid], 0);
PlayerTextDrawAlignment(playerid, tempico[playerid], 1);
PlayerTextDrawColor(playerid, tempico[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, tempico[playerid], 255);
PlayerTextDrawBoxColor(playerid, tempico[playerid], 50);
PlayerTextDrawUseBox(playerid, tempico[playerid], 0);
PlayerTextDrawSetProportional(playerid, tempico[playerid], 1);
PlayerTextDrawSetSelectable(playerid, tempico[playerid], 0);
**/

            OdejdaPng = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(614.000000, 228.000000), "HUD:radar_tshirt");

            OdejdaPng.Font = TextDrawFont.DrawSprite;
            OdejdaPng.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            OdejdaPng.Width = 17;
            OdejdaPng.Height = 17;
            OdejdaPng.Outline = 1;
            OdejdaPng.Shadow = 0;
            OdejdaPng.Alignment = TextDrawAlignment.Left;
            OdejdaPng.ForeColor = -1;
            OdejdaPng.BackColor = 255;
            OdejdaPng.BoxColor = 50;
            OdejdaPng.UseBox = false;
            OdejdaPng.Proportional = true;
            OdejdaPng.Selectable = false;

            /**
tempnum[playerid] = CreatePlayerTextDraw(playerid, 618.000000, 215.000000, "99");
PlayerTextDrawFont(playerid, tempnum[playerid], 1);
PlayerTextDrawLetterSize(playerid, tempnum[playerid], 0.191667, 1.200000);
PlayerTextDrawTextSize(playerid, tempnum[playerid], 17.000000, 17.000000);
PlayerTextDrawSetOutline(playerid, tempnum[playerid], 1);
PlayerTextDrawSetShadow(playerid, tempnum[playerid], 0);
PlayerTextDrawAlignment(playerid, tempnum[playerid], 1);
PlayerTextDrawColor(playerid, tempnum[playerid], 1433087999);
PlayerTextDrawBackgroundColor(playerid, tempnum[playerid], 255);
PlayerTextDrawBoxColor(playerid, tempnum[playerid], 50);
PlayerTextDrawUseBox(playerid, tempnum[playerid], 0);
PlayerTextDrawSetProportional(playerid, tempnum[playerid], 1);
PlayerTextDrawSetSelectable(playerid, tempnum[playerid], 0);
**/
            OdejdaNum = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(618.000000, 245.000000), "98");

            OdejdaNum.Font = TextDrawFont.Normal;
            OdejdaNum.LetterSize = new SampSharp.GameMode.Vector2(0.191667, 1.200000);
            OdejdaNum.Width = 17;
            OdejdaNum.Height = 17;
            OdejdaNum.Outline = 1;
            OdejdaNum.Shadow = 0;
            OdejdaNum.Alignment = TextDrawAlignment.Left;
            OdejdaNum.ForeColor = 1433087999;
            OdejdaNum.BackColor = 255;
            OdejdaNum.BoxColor = 50;
            OdejdaNum.UseBox = false;
            OdejdaNum.Proportional = true;
            OdejdaNum.Selectable = false;

            /**
pisspng[playerid] = CreatePlayerTextDraw(playerid, 614.000000, 228.000000, "HUD:radar_centre");
PlayerTextDrawFont(playerid, pisspng[playerid], 4);
PlayerTextDrawLetterSize(playerid, pisspng[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, pisspng[playerid], 17.000000, 17.000000);
PlayerTextDrawSetOutline(playerid, pisspng[playerid], 1);
PlayerTextDrawSetShadow(playerid, pisspng[playerid], 0);
PlayerTextDrawAlignment(playerid, pisspng[playerid], 1);
PlayerTextDrawColor(playerid, pisspng[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, pisspng[playerid], 255);
PlayerTextDrawBoxColor(playerid, pisspng[playerid], 50);
PlayerTextDrawUseBox(playerid, pisspng[playerid], 0);
PlayerTextDrawSetProportional(playerid, pisspng[playerid], 1);
PlayerTextDrawSetSelectable(playerid, pisspng[playerid], 0);
**/
            pissPng = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(614.000000, 257.000000f), "HUD:radar_centre");

            pissPng.Font = TextDrawFont.DrawSprite;
            pissPng.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            pissPng.Width = 17;
            pissPng.Height = 17;
            pissPng.Outline = 1;
            pissPng.Shadow = 0;
            pissPng.Alignment = TextDrawAlignment.Left;
            pissPng.ForeColor = -1;
            pissPng.BackColor = 255;
            pissPng.BoxColor = 50;
            pissPng.UseBox = false;
            pissPng.Proportional = true;
            pissPng.Selectable = false;

            /**
pissnum[playerid] = CreatePlayerTextDraw(playerid, 618.000000, 245.000000, "99");
PlayerTextDrawFont(playerid, pissnum[playerid], 1);
PlayerTextDrawLetterSize(playerid, pissnum[playerid], 0.191667, 1.200000);
PlayerTextDrawTextSize(playerid, pissnum[playerid], 17.000000, 17.000000);
PlayerTextDrawSetOutline(playerid, pissnum[playerid], 1);
PlayerTextDrawSetShadow(playerid, pissnum[playerid], 0);
PlayerTextDrawAlignment(playerid, pissnum[playerid], 1);
PlayerTextDrawColor(playerid, pissnum[playerid], 1433087999);
PlayerTextDrawBackgroundColor(playerid, pissnum[playerid], 255);
PlayerTextDrawBoxColor(playerid, pissnum[playerid], 50);
PlayerTextDrawUseBox(playerid, pissnum[playerid], 0);
PlayerTextDrawSetProportional(playerid, pissnum[playerid], 1);
PlayerTextDrawSetSelectable(playerid, pissnum[playerid], 0);
**/
            pissNum = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(618.000000, 275.000000), "97");

            pissNum.Font = TextDrawFont.Normal;
            pissNum.LetterSize = new SampSharp.GameMode.Vector2(0.191667, 1.200000);
            pissNum.Width = 17;
            pissNum.Height = 17;
            pissNum.Outline = 1;
            pissNum.Shadow = 0;
            pissNum.Alignment = TextDrawAlignment.Left;
            pissNum.ForeColor = 1433087999;
            pissNum.BackColor = 255;
            pissNum.BoxColor = 50;
            pissNum.UseBox = false;
            pissNum.Proportional = true;
            pissNum.Selectable = false;

            /**
imunpng[playerid] = CreatePlayerTextDraw(playerid, 614.000000, 257.000000, "HUD:radar_girlfriend");
PlayerTextDrawFont(playerid, imunpng[playerid], 4);
PlayerTextDrawLetterSize(playerid, imunpng[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, imunpng[playerid], 17.000000, 17.000000);
PlayerTextDrawSetOutline(playerid, imunpng[playerid], 1);
PlayerTextDrawSetShadow(playerid, imunpng[playerid], 0);
PlayerTextDrawAlignment(playerid, imunpng[playerid], 1);
PlayerTextDrawColor(playerid, imunpng[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, imunpng[playerid], 255);
PlayerTextDrawBoxColor(playerid, imunpng[playerid], 50);
PlayerTextDrawUseBox(playerid, imunpng[playerid], 0);
PlayerTextDrawSetProportional(playerid, imunpng[playerid], 1);
PlayerTextDrawSetSelectable(playerid, imunpng[playerid], 0);
**/
            imunPng = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(614.000000, 139.000000), "HUD:radar_girlfriend");

            imunPng.Font = TextDrawFont.DrawSprite;
            imunPng.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            imunPng.Width = 17;
            imunPng.Height = 17;
            imunPng.Outline = 1;
            imunPng.Shadow = 0;
            imunPng.Alignment = TextDrawAlignment.Left;
            imunPng.ForeColor = -1;
            imunPng.BackColor = 255;
            imunPng.BoxColor = 50;
            imunPng.UseBox = false;
            imunPng.Proportional = true;
            imunPng.Selectable = false;

            /**
imunnum[playerid] = CreatePlayerTextDraw(playerid, 618.000000, 275.000000, "99");
PlayerTextDrawFont(playerid, imunnum[playerid], 1);
PlayerTextDrawLetterSize(playerid, imunnum[playerid], 0.191667, 1.200000);
PlayerTextDrawTextSize(playerid, imunnum[playerid], 17.000000, 17.000000);
PlayerTextDrawSetOutline(playerid, imunnum[playerid], 1);
PlayerTextDrawSetShadow(playerid, imunnum[playerid], 0);
PlayerTextDrawAlignment(playerid, imunnum[playerid], 1);
PlayerTextDrawColor(playerid, imunnum[playerid], 1433087999);
PlayerTextDrawBackgroundColor(playerid, imunnum[playerid], 255);
PlayerTextDrawBoxColor(playerid, imunnum[playerid], 50);
PlayerTextDrawUseBox(playerid, imunnum[playerid], 0);
PlayerTextDrawSetProportional(playerid, imunnum[playerid], 1);
PlayerTextDrawSetSelectable(playerid, imunnum[playerid], 0);
**/
            //618.000000, 156.000000 618.0f, 275.0
            imunNum = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(618.000000, 156.000000), "97");

            imunNum.Font = TextDrawFont.Normal;
            imunNum.LetterSize = new SampSharp.GameMode.Vector2(0.191667, 1.200000);
            imunNum.Width = 17;
            imunNum.Height = 17;
            imunNum.Outline = 1;
            imunNum.Shadow = 0;
            imunNum.Alignment = TextDrawAlignment.Left;
            imunNum.ForeColor = 1433087999;
            imunNum.BackColor = 255;
            imunNum.BoxColor = 50;
            imunNum.UseBox = false;
            imunNum.Proportional = true;
            imunNum.Selectable = false;

            /**
bonesPng[playerid] = CreatePlayerTextDraw(playerid, 614.000000, 18.000000, "particle:handman");
PlayerTextDrawFont(playerid, bonesPng[playerid], 4);
PlayerTextDrawLetterSize(playerid, bonesPng[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, bonesPng[playerid], 17.000000, 17.000000);
PlayerTextDrawSetOutline(playerid, bonesPng[playerid], 1);
PlayerTextDrawSetShadow(playerid, bonesPng[playerid], 0);
PlayerTextDrawAlignment(playerid, bonesPng[playerid], 1);
PlayerTextDrawColor(playerid, bonesPng[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, bonesPng[playerid], 255);
PlayerTextDrawBoxColor(playerid, bonesPng[playerid], 50);
PlayerTextDrawUseBox(playerid, bonesPng[playerid], 0);
PlayerTextDrawSetProportional(playerid, bonesPng[playerid], 1);
PlayerTextDrawSetSelectable(playerid, bonesPng[playerid], 0);
**/
            bonesPng = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(614.000000, 18.000000), "particle:handman");

            bonesPng.Font = TextDrawFont.DrawSprite;
            bonesPng.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            bonesPng.Width = 17;
            bonesPng.Height = 17;
            bonesPng.Outline = 1;
            bonesPng.Shadow = 0;
            bonesPng.Alignment = TextDrawAlignment.Left;
            bonesPng.ForeColor = -1;
            bonesPng.BackColor = 255;
            bonesPng.BoxColor = 50;
            bonesPng.UseBox = false;
            bonesPng.Proportional = true;
            bonesPng.Selectable = false;

            /**
healthPng[playerid] = CreatePlayerTextDraw(playerid, 614.000000, 39.000000, "HUD:radar_hostpital");
PlayerTextDrawFont(playerid, healthPng[playerid], 4);
PlayerTextDrawLetterSize(playerid, healthPng[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, healthPng[playerid], 17.000000, 17.000000);
PlayerTextDrawSetOutline(playerid, healthPng[playerid], 1);
PlayerTextDrawSetShadow(playerid, healthPng[playerid], 0);
PlayerTextDrawAlignment(playerid, healthPng[playerid], 1);
PlayerTextDrawColor(playerid, healthPng[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, healthPng[playerid], 255);
PlayerTextDrawBoxColor(playerid, healthPng[playerid], 50);
PlayerTextDrawUseBox(playerid, healthPng[playerid], 0);
PlayerTextDrawSetProportional(playerid, healthPng[playerid], 1);
PlayerTextDrawSetSelectable(playerid, healthPng[playerid], 0);
**/


            healthPng = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(614.000000,39.000000), "HUD:radar_hostpital");

            healthPng.Font = TextDrawFont.DrawSprite;
            healthPng.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            healthPng.Width = 17;
            healthPng.Height = 17;
            healthPng.Outline = 1;
            healthPng.Shadow = 0;
            healthPng.Alignment = TextDrawAlignment.Left;
            healthPng.ForeColor = -1;
            healthPng.BackColor = 255;
            healthPng.BoxColor = 50;
            healthPng.UseBox = false;
            healthPng.Proportional = true;
            healthPng.Selectable = false;

            /**
ClothesPNG[playerid] = CreatePlayerTextDraw(playerid, 610.000000, 51.000000, "LD_OTB2:Ric5");
PlayerTextDrawFont(playerid, ClothesPNG[playerid], 4);
PlayerTextDrawLetterSize(playerid, ClothesPNG[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, ClothesPNG[playerid], 25.000000, 31.000000);
PlayerTextDrawSetOutline(playerid, ClothesPNG[playerid], 1);
PlayerTextDrawSetShadow(playerid, ClothesPNG[playerid], 0);
PlayerTextDrawAlignment(playerid, ClothesPNG[playerid], 1);
PlayerTextDrawColor(playerid, ClothesPNG[playerid], 255);
PlayerTextDrawBackgroundColor(playerid, ClothesPNG[playerid], 255);
PlayerTextDrawBoxColor(playerid, ClothesPNG[playerid], 50);
PlayerTextDrawUseBox(playerid, ClothesPNG[playerid], 0);
PlayerTextDrawSetProportional(playerid, ClothesPNG[playerid], 1);
PlayerTextDrawSetSelectable(playerid, ClothesPNG[playerid], 0);
**/
            clothPng = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(610.000000, 51.000000), "LD_OTB2:Ric5");
            clothPng.Font = TextDrawFont.DrawSprite;
            clothPng.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            clothPng.Width = 25;
            clothPng.Height = 31;
            clothPng.Outline = 1;
            clothPng.Shadow = 0;
            clothPng.Alignment = TextDrawAlignment.Left;
            clothPng.ForeColor = 255;
            clothPng.BackColor = 255;
            clothPng.BoxColor = 50;
            clothPng.UseBox = false;
            clothPng.Proportional = true;
            clothPng.Selectable = false;

            /**
BleedPng[playerid] = CreatePlayerTextDraw(playerid, 614.000000, 80.000000, "particle:bloodpool_64");
PlayerTextDrawFont(playerid, BleedPng[playerid], 4);
PlayerTextDrawLetterSize(playerid, BleedPng[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, BleedPng[playerid], 17.000000, 17.000000);
PlayerTextDrawSetOutline(playerid, BleedPng[playerid], 1);
PlayerTextDrawSetShadow(playerid, BleedPng[playerid], 0);
PlayerTextDrawAlignment(playerid, BleedPng[playerid], 1);
PlayerTextDrawColor(playerid, BleedPng[playerid], 255);
PlayerTextDrawBackgroundColor(playerid, BleedPng[playerid], 255);
PlayerTextDrawBoxColor(playerid, BleedPng[playerid], 50);
PlayerTextDrawUseBox(playerid, BleedPng[playerid], 0);
PlayerTextDrawSetProportional(playerid, BleedPng[playerid], 1);
PlayerTextDrawSetSelectable(playerid, BleedPng[playerid], 0);
**/
            bleedPng = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(614.000000, 80.000000), "particle:bloodpool_64");
            bleedPng.Font = TextDrawFont.DrawSprite;
            bleedPng.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            bleedPng.Width = 17;
            bleedPng.Height = 17;
            bleedPng.Outline = 1;
            bleedPng.Shadow = 0;
            bleedPng.Alignment = TextDrawAlignment.Left;
            bleedPng.ForeColor = 255;
            bleedPng.BackColor = 255;
            bleedPng.BoxColor = 50;
            bleedPng.UseBox = false;
            bleedPng.Proportional = true;
            bleedPng.Selectable = false;

            DangerPlate = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(607.000000, 297.000000), "DANGER!");
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
        public void OnClickMenu(object sender, ClickPlayerTextDrawEventArgs e)
        {
            if(e.PlayerTextDraw == boomsTurn)
            {
                p.skillMenu.Show();
            }
            if (e.PlayerTextDraw == healthMenuPNG)
            {
                DiseasesDialog.showDiseasesDialog(p);
            }
        }
        public void OnClickCarMenu(object sender, ClickPlayerTextDrawEventArgs e)
        {
            if(e.PlayerTextDraw == carMenuPNG) PlayerCarMenu.ShowCarMenu(p);

        }
        public void Show()
        {
            bonesPng.Show();
            healthPng.Show();
            clothPng.Show();
            bleedPng.Show();
           //  booms.Show();
             EatPNG.Show();
             EatNum.Show();
             WaterPng.Show();
             WaterNum.Show();
            //  RadPng.Show();
            //  RadNum.Show();
            OdejdaNum.Show();
            OdejdaPng.Show();
            pissPng.Show();
            pissNum.Show();
            imunNum.Show();
            imunPng.Show();
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
            bonesPng.Hide();
            healthPng.Hide();
            clothPng.Hide();
            bleedPng.Hide();
            // booms.Hide();
            EatPNG.Hide();
            EatNum.Hide();
            WaterPng.Hide();
            WaterNum.Hide();
            //  RadPng.Hide();
            //  RadNum.Hide();
            OdejdaNum.Hide();
            OdejdaPng.Hide();
            pissPng.Hide();
            pissNum.Hide();
            imunNum.Hide();
            imunPng.Hide();
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

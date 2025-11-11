using SampSharp.GameMode;
using SampSharp.GameMode.Display;
using SampSharp.GameMode.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.Display
{
    public class skillmenu
    {
        public int currentPage = 1;
        public bool isOpen
        {
            get;
            private set;
        }
        Player p = new Player();
        PlayerTextDraw backplate;
        PlayerTextDraw upperBorder;
        PlayerTextDraw lowerBorder;
        PlayerTextDraw leftBorder;
        PlayerTextDraw rightBorder;
        PlayerTextDraw centerBorder;
   
        PlayerTextDraw craft_preview;
        PlayerTextDraw craft_text;
        PlayerTextDraw cooking_preview;
        PlayerTextDraw cooking_text;
        PlayerTextDraw medicine_preview;
        PlayerTextDraw medicine_text;
        PlayerTextDraw survival_preview;
        PlayerTextDraw survival_text;
        PlayerTextDraw tactics_preview;
        PlayerTextDraw tactics_text;
        PlayerTextDraw skill6_preview;
        PlayerTextDraw skill7_preview;
        PlayerTextDraw skill8_preview;

        PlayerTextDraw skillmenuText;

        PlayerTextDraw skill1Ico;
        PlayerTextDraw skill2Ico;
        PlayerTextDraw skill3Ico;
        PlayerTextDraw skill4Ico;
        PlayerTextDraw skill5Ico;

        PlayerTextDraw skill1text;
        PlayerTextDraw skill2text;
        PlayerTextDraw skill3text;
        PlayerTextDraw skill4text;
        PlayerTextDraw skill5text;

        PlayerTextDraw closeButton;

        public skillmenu(Player player) { 
            this.p = player;
            /**
backplate = TextDrawCreate(324.000000, 165.000000, "_");
TextDrawFont(backplate, 1);
TextDrawLetterSize(backplate, 0.641664, 22.849990);
TextDrawTextSize(backplate, 304.500000, 255.500000);
TextDrawSetOutline(backplate, 1);
TextDrawSetShadow(backplate, 0);
TextDrawAlignment(backplate, 2);
TextDrawColor(backplate, -1);
TextDrawBackgroundColor(backplate, 255);
TextDrawBoxColor(backplate, 135);
TextDrawUseBox(backplate, 1);
TextDrawSetProportional(backplate, 1);
TextDrawSetSelectable(backplate, 0);
**/
            p.ClickPlayerTextDraw += OnClickSkillMenu;
            backplate = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(324,165), "_");
            backplate.Font = SampSharp.GameMode.Definitions.TextDrawFont.Normal;
            backplate.LetterSize = new SampSharp.GameMode.Vector2(0.641664, 22.849990);
            backplate.Width = 304.5f;
            backplate.Height = 255.5f;
            backplate.Outline = 1;
            backplate.Shadow = 0;
            backplate.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Center;
            backplate.ForeColor = -1;
            backplate.BackColor = 255;
            backplate.BoxColor = 135;
            backplate.UseBox = true;
            backplate.Proportional = true;
            backplate.Selectable = false;



            /**
upperborder[playerid] = CreatePlayerTextDraw(playerid, 324.000000, 165.000000, "_");
PlayerTextDrawFont(playerid, upperborder[playerid], 1);
PlayerTextDrawLetterSize(playerid, upperborder[playerid], 0.641664, 0.150000);
PlayerTextDrawTextSize(playerid, upperborder[playerid], 304.500000, 255.500000);
PlayerTextDrawSetOutline(playerid, upperborder[playerid], 1);
PlayerTextDrawSetShadow(playerid, upperborder[playerid], 0);
PlayerTextDrawAlignment(playerid, upperborder[playerid], 2);
PlayerTextDrawColor(playerid, upperborder[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, upperborder[playerid], 255);
PlayerTextDrawBoxColor(playerid, upperborder[playerid], 255);
PlayerTextDrawUseBox(playerid, upperborder[playerid], 1);
PlayerTextDrawSetProportional(playerid, upperborder[playerid], 1);
PlayerTextDrawSetSelectable(playerid, upperborder[playerid], 0);
**/
            upperBorder = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(324, 165), "_");
            upperBorder.Font = SampSharp.GameMode.Definitions.TextDrawFont.Normal;
            upperBorder.LetterSize = new SampSharp.GameMode.Vector2(0.641664, 0.150000);
            upperBorder.Width = 304.5f;
            upperBorder.Height = 255.5f;
            upperBorder.Outline = 1;
            upperBorder.Shadow = 0;
            upperBorder.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Center;
            upperBorder.ForeColor = -1;
            upperBorder.BackColor = 255;
            upperBorder.BoxColor = 255;
            upperBorder.UseBox = true;
            upperBorder.Proportional = true;
            upperBorder.Selectable = false;
            /**
lowerborder[playerid] = CreatePlayerTextDraw(playerid, 324.000000, 370.000000, "_");
PlayerTextDrawFont(playerid, lowerborder[playerid], 1);
PlayerTextDrawLetterSize(playerid, lowerborder[playerid], 0.641664, 0.150000);
PlayerTextDrawTextSize(playerid, lowerborder[playerid], 304.500000, 255.500000);
PlayerTextDrawSetOutline(playerid, lowerborder[playerid], 1);
PlayerTextDrawSetShadow(playerid, lowerborder[playerid], 0);
PlayerTextDrawAlignment(playerid, lowerborder[playerid], 2);
PlayerTextDrawColor(playerid, lowerborder[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, lowerborder[playerid], 255);
PlayerTextDrawBoxColor(playerid, lowerborder[playerid], 255);
PlayerTextDrawUseBox(playerid, lowerborder[playerid], 1);
PlayerTextDrawSetProportional(playerid, lowerborder[playerid], 1);
PlayerTextDrawSetSelectable(playerid, lowerborder[playerid], 0);
**/
            lowerBorder = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(324, 370), "_");
            lowerBorder.Font = SampSharp.GameMode.Definitions.TextDrawFont.Normal;
            lowerBorder.LetterSize = new SampSharp.GameMode.Vector2(0.641664, 0.150000);
            lowerBorder.Width = 304.5f;
            lowerBorder.Height = 255.5f;
            lowerBorder.Outline = 1;
            lowerBorder.Shadow = 0;
            lowerBorder.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Center;
            lowerBorder.ForeColor = -1;
            lowerBorder.BackColor = 255;
            lowerBorder.BoxColor = 255;
            lowerBorder.UseBox = true;
            lowerBorder.Proportional = true;
            lowerBorder.Selectable = false;

            /**
rightborder[playerid] = CreatePlayerTextDraw(playerid, 451.000000, 165.000000, "_");
PlayerTextDrawFont(playerid, rightborder[playerid], 1);
PlayerTextDrawLetterSize(playerid, rightborder[playerid], 0.641664, 22.849990);
PlayerTextDrawTextSize(playerid, rightborder[playerid], 304.500000, 0.500000);
PlayerTextDrawSetOutline(playerid, rightborder[playerid], 1);
PlayerTextDrawSetShadow(playerid, rightborder[playerid], 0);
PlayerTextDrawAlignment(playerid, rightborder[playerid], 2);
PlayerTextDrawColor(playerid, rightborder[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, rightborder[playerid], 255);
PlayerTextDrawBoxColor(playerid, rightborder[playerid], 255);
PlayerTextDrawUseBox(playerid, rightborder[playerid], 1);
PlayerTextDrawSetProportional(playerid, rightborder[playerid], 1);
PlayerTextDrawSetSelectable(playerid, rightborder[playerid], 0);
**/
            rightBorder = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(451.000000, 165.000000), "_");
            rightBorder.Font = SampSharp.GameMode.Definitions.TextDrawFont.Normal;
            rightBorder.LetterSize = new SampSharp.GameMode.Vector2(0.641664, 22.849990);
            rightBorder.Width = 304.5f;
            rightBorder.Height = 0.5f;
            rightBorder.Outline = 1;
            rightBorder.Shadow = 0;
            rightBorder.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Center;
            rightBorder.ForeColor = -1;
            rightBorder.BackColor = 255;
            rightBorder.BoxColor = 255;
            rightBorder.UseBox = true;
            rightBorder.Proportional = true;
            rightBorder.Selectable = false;
            /**
PlayerTD[playerid][0] = CreatePlayerTextDraw(playerid, 197.000000, 165.000000, "_");
PlayerTextDrawFont(playerid, PlayerTD[playerid][0], 1);
PlayerTextDrawLetterSize(playerid, PlayerTD[playerid][0], 0.641664, 22.849990);
PlayerTextDrawTextSize(playerid, PlayerTD[playerid][0], 304.500000, 0.500000);
PlayerTextDrawSetOutline(playerid, PlayerTD[playerid][0], 1);
PlayerTextDrawSetShadow(playerid, PlayerTD[playerid][0], 0);
PlayerTextDrawAlignment(playerid, PlayerTD[playerid][0], 2);
PlayerTextDrawColor(playerid, PlayerTD[playerid][0], -1);
PlayerTextDrawBackgroundColor(playerid, PlayerTD[playerid][0], 255);
PlayerTextDrawBoxColor(playerid, PlayerTD[playerid][0], 255);
PlayerTextDrawUseBox(playerid, PlayerTD[playerid][0], 1);
PlayerTextDrawSetProportional(playerid, PlayerTD[playerid][0], 1);
PlayerTextDrawSetSelectable(playerid, PlayerTD[playerid][0], 0);
**/
            leftBorder = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(197.000000, 165.000000), "_");
            leftBorder.Font = SampSharp.GameMode.Definitions.TextDrawFont.Normal;
            leftBorder.LetterSize = new SampSharp.GameMode.Vector2(0.641664, 22.849990);
            leftBorder.Width = 304.5f;
            leftBorder.Height = 0.5f;
            leftBorder.Outline = 1;
            leftBorder.Shadow = 0;
            leftBorder.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Center;
            leftBorder.ForeColor = -1;
            leftBorder.BackColor = 255;
            leftBorder.BoxColor = 255;
            leftBorder.UseBox = true;
            leftBorder.Proportional = true;
            leftBorder.Selectable = false;
            /**
PlayerTD[playerid][1] = CreatePlayerTextDraw(playerid, 303.000000, 165.000000, "_");
PlayerTextDrawFont(playerid, PlayerTD[playerid][1], 1);
PlayerTextDrawLetterSize(playerid, PlayerTD[playerid][1], 0.641664, 22.849990);
PlayerTextDrawTextSize(playerid, PlayerTD[playerid][1], 304.500000, 0.500000);
PlayerTextDrawSetOutline(playerid, PlayerTD[playerid][1], 1);
PlayerTextDrawSetShadow(playerid, PlayerTD[playerid][1], 0);
PlayerTextDrawAlignment(playerid, PlayerTD[playerid][1], 2);
PlayerTextDrawColor(playerid, PlayerTD[playerid][1], -1);
PlayerTextDrawBackgroundColor(playerid, PlayerTD[playerid][1], 255);
PlayerTextDrawBoxColor(playerid, PlayerTD[playerid][1], 255);
PlayerTextDrawUseBox(playerid, PlayerTD[playerid][1], 1);
PlayerTextDrawSetProportional(playerid, PlayerTD[playerid][1], 1);
PlayerTextDrawSetSelectable(playerid, PlayerTD[playerid][1], 0);
**/
            centerBorder = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(303.000000, 165.000000), "_");
            centerBorder.Font = SampSharp.GameMode.Definitions.TextDrawFont.Normal;
            centerBorder.LetterSize = new SampSharp.GameMode.Vector2(0.641664, 22.849990);
            centerBorder.Width = 304.5f;
            centerBorder.Height = 0.5f;
            centerBorder.Outline = 1;
            centerBorder.Shadow = 0;
            centerBorder.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Center;
            centerBorder.ForeColor = -1;
            centerBorder.BackColor = 255;
            centerBorder.BoxColor = 255;
            centerBorder.UseBox = true;
            centerBorder.Proportional = true;
            centerBorder.Selectable = false;

            /**
craft_prew[playerid] = CreatePlayerTextDraw(playerid, 202.000000, 172.000000, "Preview_Model");
PlayerTextDrawFont(playerid, craft_prew[playerid], 5);
PlayerTextDrawLetterSize(playerid, craft_prew[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, craft_prew[playerid], 44.000000, 44.500000);
PlayerTextDrawSetOutline(playerid, craft_prew[playerid], 0);
PlayerTextDrawSetShadow(playerid, craft_prew[playerid], 0);
PlayerTextDrawAlignment(playerid, craft_prew[playerid], 1);
PlayerTextDrawColor(playerid, craft_prew[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, craft_prew[playerid], -2686851);
PlayerTextDrawBoxColor(playerid, craft_prew[playerid], 67);
PlayerTextDrawUseBox(playerid, craft_prew[playerid], 0);
PlayerTextDrawSetProportional(playerid, craft_prew[playerid], 1);
PlayerTextDrawSetSelectable(playerid, craft_prew[playerid], 1);
PlayerTextDrawSetPreviewModel(playerid, craft_prew[playerid], 18635);
PlayerTextDrawSetPreviewRot(playerid, craft_prew[playerid], -16.000000, 21.000000, -10.000000, 0.949998);
PlayerTextDrawSetPreviewVehCol(playerid, craft_prew[playerid], 1, 1);
**/
            craft_preview = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(202.000000, 172.000000), "Preview_Model");
            craft_preview.Font = SampSharp.GameMode.Definitions.TextDrawFont.PreviewModel;
            craft_preview.LetterSize = new SampSharp.GameMode.Vector2(0.600000, 2.000000);
            craft_preview.Width = 44.0f;
            craft_preview.Height = 44.5f;
            craft_preview.Outline = 0;
            craft_preview.Shadow = 0;
            craft_preview.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            craft_preview.ForeColor = -1;
            craft_preview.BackColor = -2686851;
            craft_preview.BoxColor = 67;
            craft_preview.UseBox = false;
            craft_preview.Proportional = true;
            craft_preview.Selectable = true;
            craft_preview.PreviewModel = 18635;
            craft_preview.PreviewRotation = new SampSharp.GameMode.Vector3(-16.000000, 21.000000, -10.000000);
            craft_preview.PreviewZoom = 0.949998f;
            /**
PlayerTD[playerid][2] = CreatePlayerTextDraw(playerid, 210.000000, 207.000000, "craft");
PlayerTextDrawFont(playerid, PlayerTD[playerid][2], 2);
PlayerTextDrawLetterSize(playerid, PlayerTD[playerid][2], 0.216665, 0.949998);
PlayerTextDrawTextSize(playerid, PlayerTD[playerid][2], 400.000000, 17.000000);
PlayerTextDrawSetOutline(playerid, PlayerTD[playerid][2], 0);
PlayerTextDrawSetShadow(playerid, PlayerTD[playerid][2], 0);
PlayerTextDrawAlignment(playerid, PlayerTD[playerid][2], 1);
PlayerTextDrawColor(playerid, PlayerTD[playerid][2], -1);
PlayerTextDrawBackgroundColor(playerid, PlayerTD[playerid][2], 255);
PlayerTextDrawBoxColor(playerid, PlayerTD[playerid][2], 50);
PlayerTextDrawUseBox(playerid, PlayerTD[playerid][2], 0);
PlayerTextDrawSetProportional(playerid, PlayerTD[playerid][2], 1);
PlayerTextDrawSetSelectable(playerid, PlayerTD[playerid][2], 0);
**/
            craft_text = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(210.000000, 207.000000), "craft");
            craft_text.Font = SampSharp.GameMode.Definitions.TextDrawFont.Slim;
            craft_text.LetterSize = new SampSharp.GameMode.Vector2(0.216665, 0.949998);
            craft_text.Width = 400f;
            craft_text.Height = 17.0f;
            craft_text.Outline = 0;
            craft_text.Shadow = 0;
            craft_text.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            craft_text.ForeColor = -1;
            craft_text.BackColor = 255;
            craft_text.BoxColor = 50;
            craft_text.UseBox = false;
            craft_text.Proportional = true;
            craft_text.Selectable = false;
            /**
cooking_prev[playerid] = CreatePlayerTextDraw(playerid, 202.000000, 220.000000, "Preview_Model");
PlayerTextDrawFont(playerid, cooking_prev[playerid], 5);
PlayerTextDrawLetterSize(playerid, cooking_prev[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, cooking_prev[playerid], 44.000000, 44.500000);
PlayerTextDrawSetOutline(playerid, cooking_prev[playerid], 0);
PlayerTextDrawSetShadow(playerid, cooking_prev[playerid], 0);
PlayerTextDrawAlignment(playerid, cooking_prev[playerid], 1);
PlayerTextDrawColor(playerid, cooking_prev[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, cooking_prev[playerid], 1097458045);
PlayerTextDrawBoxColor(playerid, cooking_prev[playerid], 67);
PlayerTextDrawUseBox(playerid, cooking_prev[playerid], 0);
PlayerTextDrawSetProportional(playerid, cooking_prev[playerid], 1);
PlayerTextDrawSetSelectable(playerid, cooking_prev[playerid], 1);
PlayerTextDrawSetPreviewModel(playerid, cooking_prev[playerid], 19527);
PlayerTextDrawSetPreviewRot(playerid, cooking_prev[playerid], -32.000000, 0.000000, 3.000000, 1.099997);
PlayerTextDrawSetPreviewVehCol(playerid, cooking_prev[playerid], 1, 1);
**/
            cooking_preview = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(202.000000, 220.000000), "Preview_Model");
            cooking_preview.Font = SampSharp.GameMode.Definitions.TextDrawFont.PreviewModel;
            cooking_preview.LetterSize = new SampSharp.GameMode.Vector2(0.600000, 2.000000);
            cooking_preview.Width = 44;
            cooking_preview.Height = 44.5f;
            cooking_preview.Outline = 0;
            cooking_preview.Shadow = 0;
            cooking_preview.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            cooking_preview.ForeColor = -1;
            cooking_preview.BackColor = 1097458045;
            cooking_preview.BoxColor = 67;
            cooking_preview.UseBox = false;
            cooking_preview.Proportional = true;
            cooking_preview.Selectable = true;
            cooking_preview.PreviewModel = 19527;
            cooking_preview.PreviewRotation = new SampSharp.GameMode.Vector3(-32.000000, 0.000000, 3.000000);
            cooking_preview.PreviewZoom = 1.099997f;
            /**
PlayerTD[playerid][3] = CreatePlayerTextDraw(playerid, 210.000000, 256.000000, "cooking");
PlayerTextDrawFont(playerid, PlayerTD[playerid][3], 2);
PlayerTextDrawLetterSize(playerid, PlayerTD[playerid][3], 0.166666, 0.949998);
PlayerTextDrawTextSize(playerid, PlayerTD[playerid][3], 400.000000, 17.000000);
PlayerTextDrawSetOutline(playerid, PlayerTD[playerid][3], 0);
PlayerTextDrawSetShadow(playerid, PlayerTD[playerid][3], 0);
PlayerTextDrawAlignment(playerid, PlayerTD[playerid][3], 1);
PlayerTextDrawColor(playerid, PlayerTD[playerid][3], -1);
PlayerTextDrawBackgroundColor(playerid, PlayerTD[playerid][3], 255);
PlayerTextDrawBoxColor(playerid, PlayerTD[playerid][3], 50);
PlayerTextDrawUseBox(playerid, PlayerTD[playerid][3], 0);
PlayerTextDrawSetProportional(playerid, PlayerTD[playerid][3], 1);
PlayerTextDrawSetSelectable(playerid, PlayerTD[playerid][3], 0);
**/
            cooking_text = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(210.000000, 256.000000), "cooking");
            cooking_text.Font = SampSharp.GameMode.Definitions.TextDrawFont.Slim;
            cooking_text.LetterSize = new SampSharp.GameMode.Vector2(0.166666, 0.949998);
            cooking_text.Width = 400;
            cooking_text.Height = 17;
            cooking_text.Outline = 0;
            cooking_text.Shadow = 0;
            cooking_text.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            cooking_text.ForeColor = -1;
            cooking_text.BackColor = 255;
            cooking_text.BoxColor = 50;
            cooking_text.UseBox = false;
            cooking_text.Proportional = true;
            cooking_text.Selectable = false;

            /**
medicine_prev[playerid] = CreatePlayerTextDraw(playerid, 202.000000, 268.000000, "Preview_Model");
PlayerTextDrawFont(playerid, medicine_prev[playerid], 5);
PlayerTextDrawLetterSize(playerid, medicine_prev[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, medicine_prev[playerid], 44.000000, 44.500000);
PlayerTextDrawSetOutline(playerid, medicine_prev[playerid], 0);
PlayerTextDrawSetShadow(playerid, medicine_prev[playerid], 0);
PlayerTextDrawAlignment(playerid, medicine_prev[playerid], 1);
PlayerTextDrawColor(playerid, medicine_prev[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, medicine_prev[playerid], 1296911741);
PlayerTextDrawBoxColor(playerid, medicine_prev[playerid], 67);
PlayerTextDrawUseBox(playerid, medicine_prev[playerid], 0);
PlayerTextDrawSetProportional(playerid, medicine_prev[playerid], 1);
PlayerTextDrawSetSelectable(playerid, medicine_prev[playerid], 1);
PlayerTextDrawSetPreviewModel(playerid, medicine_prev[playerid], 11738);
PlayerTextDrawSetPreviewRot(playerid, medicine_prev[playerid], -5.000000, 0.000000, -3.000000, 1.099997);
PlayerTextDrawSetPreviewVehCol(playerid, medicine_prev[playerid], 1, 1);
**/
            medicine_preview = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(202.000000, 268.000000), "Preview_Model");
            medicine_preview.Font = SampSharp.GameMode.Definitions.TextDrawFont.PreviewModel;
            medicine_preview.LetterSize = new SampSharp.GameMode.Vector2(0.600000, 2.000000);
            medicine_preview.Width = 44;
            medicine_preview.Height = 44.5f;
            medicine_preview.Outline = 0;
            medicine_preview.Shadow = 0;
            medicine_preview.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            medicine_preview.ForeColor = -1;
            medicine_preview.BackColor = 1296911741;
            medicine_preview.BoxColor = 67;
            medicine_preview.UseBox = false;
            medicine_preview.Proportional = true;
            medicine_preview.Selectable = true;
            medicine_preview.PreviewModel = 11738;
            medicine_preview.PreviewRotation = new SampSharp.GameMode.Vector3(-5.000000, 0.000000, -3.000000);
            medicine_preview.PreviewZoom = 1.099997f;
            /**
PlayerTD[playerid][4] = CreatePlayerTextDraw(playerid, 210.000000, 304.000000, "medicine");
PlayerTextDrawFont(playerid, PlayerTD[playerid][4], 2);
PlayerTextDrawLetterSize(playerid, PlayerTD[playerid][4], 0.166666, 0.949998);
PlayerTextDrawTextSize(playerid, PlayerTD[playerid][4], 400.000000, 17.000000);
PlayerTextDrawSetOutline(playerid, PlayerTD[playerid][4], 0);
PlayerTextDrawSetShadow(playerid, PlayerTD[playerid][4], 0);
PlayerTextDrawAlignment(playerid, PlayerTD[playerid][4], 1);
PlayerTextDrawColor(playerid, PlayerTD[playerid][4], -1);
PlayerTextDrawBackgroundColor(playerid, PlayerTD[playerid][4], 255);
PlayerTextDrawBoxColor(playerid, PlayerTD[playerid][4], 50);
PlayerTextDrawUseBox(playerid, PlayerTD[playerid][4], 0);
PlayerTextDrawSetProportional(playerid, PlayerTD[playerid][4], 1);
PlayerTextDrawSetSelectable(playerid, PlayerTD[playerid][4], 0);
**/
            medicine_text = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(210.000000, 304.000000), "medicine");
            medicine_text.Font = SampSharp.GameMode.Definitions.TextDrawFont.Slim;
            medicine_text.LetterSize = new SampSharp.GameMode.Vector2(0.166666, 0.949998);
            medicine_text.Width = 400;
            medicine_text.Height = 17;
            medicine_text.Outline = 0;
            medicine_text.Shadow = 0;
            medicine_text.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            medicine_text.ForeColor = -1;
            medicine_text.BackColor = 255;
            medicine_text.BoxColor = 50;
            medicine_text.UseBox = false;
            medicine_text.Proportional = true;
            medicine_text.Selectable = false;

            /**
surv_prev[playerid] = CreatePlayerTextDraw(playerid, 202.000000, 317.000000, "Preview_Model");
PlayerTextDrawFont(playerid, surv_prev[playerid], 5);
PlayerTextDrawLetterSize(playerid, surv_prev[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, surv_prev[playerid], 44.000000, 44.500000);
PlayerTextDrawSetOutline(playerid, surv_prev[playerid], 0);
PlayerTextDrawSetShadow(playerid, surv_prev[playerid], 0);
PlayerTextDrawAlignment(playerid, surv_prev[playerid], 1);
PlayerTextDrawColor(playerid, surv_prev[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, surv_prev[playerid], 1433087869);
PlayerTextDrawBoxColor(playerid, surv_prev[playerid], 67);
PlayerTextDrawUseBox(playerid, surv_prev[playerid], 0);
PlayerTextDrawSetProportional(playerid, surv_prev[playerid], 1);
PlayerTextDrawSetSelectable(playerid, surv_prev[playerid], 1);
PlayerTextDrawSetPreviewModel(playerid, surv_prev[playerid], 19632);
PlayerTextDrawSetPreviewRot(playerid, surv_prev[playerid], -5.000000, 0.000000, -3.000000, 1.099997);
PlayerTextDrawSetPreviewVehCol(playerid, surv_prev[playerid], 1, 1);
**/
            survival_preview = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(202.000000, 317.000000), "Preview_Model");
            survival_preview.Font = SampSharp.GameMode.Definitions.TextDrawFont.PreviewModel;
            survival_preview.LetterSize = new SampSharp.GameMode.Vector2(0.600000, 2.000000);
            survival_preview.Width = 44;
            survival_preview.Height = 44.5f;
            survival_preview.Outline = 0;
            survival_preview.Shadow = 0;
            survival_preview.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            survival_preview.ForeColor = -1;
            survival_preview.BackColor = 1433087869;
            survival_preview.BoxColor = 67;
            survival_preview.UseBox = false;
            survival_preview.Proportional = true;
            survival_preview.Selectable = true;
            survival_preview.PreviewModel = 19632;
            survival_preview.PreviewRotation = new SampSharp.GameMode.Vector3(-5.000000, 0.000000, -3.000000);
            survival_preview.PreviewZoom = 1.099997f;
            /**
PlayerTD[playerid][5] = CreatePlayerTextDraw(playerid, 208.000000, 351.000000, "survival");
PlayerTextDrawFont(playerid, PlayerTD[playerid][5], 2);
PlayerTextDrawLetterSize(playerid, PlayerTD[playerid][5], 0.166666, 0.949998);
PlayerTextDrawTextSize(playerid, PlayerTD[playerid][5], 400.000000, 17.000000);
PlayerTextDrawSetOutline(playerid, PlayerTD[playerid][5], 0);
PlayerTextDrawSetShadow(playerid, PlayerTD[playerid][5], 0);
PlayerTextDrawAlignment(playerid, PlayerTD[playerid][5], 1);
PlayerTextDrawColor(playerid, PlayerTD[playerid][5], -1);
PlayerTextDrawBackgroundColor(playerid, PlayerTD[playerid][5], 255);
PlayerTextDrawBoxColor(playerid, PlayerTD[playerid][5], 50);
PlayerTextDrawUseBox(playerid, PlayerTD[playerid][5], 0);
PlayerTextDrawSetProportional(playerid, PlayerTD[playerid][5], 1);
PlayerTextDrawSetSelectable(playerid, PlayerTD[playerid][5], 0);
**/
            survival_text = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(208.000000, 351.000000), "survival");
            survival_text.Font = SampSharp.GameMode.Definitions.TextDrawFont.Slim;
            survival_text.LetterSize = new SampSharp.GameMode.Vector2(0.166666, 0.949998);
            survival_text.Width = 400;
            survival_text.Height = 17;
            survival_text.Outline = 0;
            survival_text.Shadow = 0;
            survival_text.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            survival_text.ForeColor = -1;
            survival_text.BackColor = 255;
            survival_text.BoxColor = 50;
            survival_text.UseBox = false;
            survival_text.Proportional = true;
            survival_text.Selectable = false;

            /**
tactics_prevc[playerid] = CreatePlayerTextDraw(playerid, 254.000000, 172.000000, "Preview_Model");
PlayerTextDrawFont(playerid, tactics_prevc[playerid], 5);
PlayerTextDrawLetterSize(playerid, tactics_prevc[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, tactics_prevc[playerid], 44.000000, 44.500000);
PlayerTextDrawSetOutline(playerid, tactics_prevc[playerid], 0);
PlayerTextDrawSetShadow(playerid, tactics_prevc[playerid], 0);
PlayerTextDrawAlignment(playerid, tactics_prevc[playerid], 1);
PlayerTextDrawColor(playerid, tactics_prevc[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, tactics_prevc[playerid], 125);
PlayerTextDrawBoxColor(playerid, tactics_prevc[playerid], 67);
PlayerTextDrawUseBox(playerid, tactics_prevc[playerid], 0);
PlayerTextDrawSetProportional(playerid, tactics_prevc[playerid], 1);
PlayerTextDrawSetSelectable(playerid, tactics_prevc[playerid], 1);
PlayerTextDrawSetPreviewModel(playerid, tactics_prevc[playerid], 355);
PlayerTextDrawSetPreviewRot(playerid, tactics_prevc[playerid], 19.000000, -29.000000, 15.000000, 2.049998);
PlayerTextDrawSetPreviewVehCol(playerid, tactics_prevc[playerid], 1, 1);
**/
            tactics_preview = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(254.000000, 172.000000), "Preview_Model");
            tactics_preview.Font = SampSharp.GameMode.Definitions.TextDrawFont.PreviewModel;
            tactics_preview.LetterSize = new SampSharp.GameMode.Vector2(0.600000, 2.000000);
            tactics_preview.Width = 44;
            tactics_preview.Height = 44.5f;
            tactics_preview.Outline = 0;
            tactics_preview.Shadow = 0;
            tactics_preview.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            tactics_preview.ForeColor = -1;
            tactics_preview.BackColor = 125;
            tactics_preview.BoxColor = 67;
            tactics_preview.UseBox = false;
            tactics_preview.Proportional = true;
            tactics_preview.Selectable = true;
            tactics_preview.PreviewModel = 355;
            tactics_preview.PreviewRotation = new SampSharp.GameMode.Vector3(19.000000, -29.000000, 15.000000);
            tactics_preview.PreviewZoom = 2.049998f;
            /**
PlayerTD[playerid][6] = CreatePlayerTextDraw(playerid, 258.000000, 207.000000, "tactics");
PlayerTextDrawFont(playerid, PlayerTD[playerid][6], 2);
PlayerTextDrawLetterSize(playerid, PlayerTD[playerid][6], 0.216665, 0.949998);
PlayerTextDrawTextSize(playerid, PlayerTD[playerid][6], 400.000000, 17.000000);
PlayerTextDrawSetOutline(playerid, PlayerTD[playerid][6], 0);
PlayerTextDrawSetShadow(playerid, PlayerTD[playerid][6], 0);
PlayerTextDrawAlignment(playerid, PlayerTD[playerid][6], 1);
PlayerTextDrawColor(playerid, PlayerTD[playerid][6], -1);
PlayerTextDrawBackgroundColor(playerid, PlayerTD[playerid][6], 255);
PlayerTextDrawBoxColor(playerid, PlayerTD[playerid][6], 50);
PlayerTextDrawUseBox(playerid, PlayerTD[playerid][6], 0);
PlayerTextDrawSetProportional(playerid, PlayerTD[playerid][6], 1);
PlayerTextDrawSetSelectable(playerid, PlayerTD[playerid][6], 0);
**/
            tactics_text = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(258.000000, 207.000000), "tactics");
            tactics_text.Font = SampSharp.GameMode.Definitions.TextDrawFont.Slim;
            tactics_text.LetterSize = new SampSharp.GameMode.Vector2(0.216665, 0.949998);
            tactics_text.Width = 400;
            tactics_text.Height = 17;
            tactics_text.Outline = 0;
            tactics_text.Shadow = 0;
            tactics_text.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            tactics_text.ForeColor = -1;
            tactics_text.BackColor = 255;
            tactics_text.BoxColor = 50;
            tactics_text.UseBox = false;
            tactics_text.Proportional = true;
            tactics_text.Selectable = false;
            /**
6thskillico[playerid] = CreatePlayerTextDraw(playerid, 254.000000, 219.000000, "Preview_Model");
PlayerTextDrawFont(playerid, 6thskillico[playerid], 5);
PlayerTextDrawLetterSize(playerid, 6thskillico[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, 6thskillico[playerid], 44.000000, 44.500000);
PlayerTextDrawSetOutline(playerid, 6thskillico[playerid], 0);
PlayerTextDrawSetShadow(playerid, 6thskillico[playerid], 0);
PlayerTextDrawAlignment(playerid, 6thskillico[playerid], 1);
PlayerTextDrawColor(playerid, 6thskillico[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, 6thskillico[playerid], 125);
PlayerTextDrawBoxColor(playerid, 6thskillico[playerid], 67);
PlayerTextDrawUseBox(playerid, 6thskillico[playerid], 0);
PlayerTextDrawSetProportional(playerid, 6thskillico[playerid], 1);
PlayerTextDrawSetSelectable(playerid, 6thskillico[playerid], 1);
PlayerTextDrawSetPreviewModel(playerid, 6thskillico[playerid], 18631);
PlayerTextDrawSetPreviewRot(playerid, 6thskillico[playerid], 19.000000, -29.000000, 15.000000, 1.009999);
PlayerTextDrawSetPreviewVehCol(playerid, 6thskillico[playerid], 1, 1);
**/
            skill6_preview = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(254.000000, 219.00000), "Preview_Model");
            skill6_preview.Font = SampSharp.GameMode.Definitions.TextDrawFont.PreviewModel;
            skill6_preview.LetterSize = new SampSharp.GameMode.Vector2(0.600000, 2.000000);
            skill6_preview.Width = 44;
            skill6_preview.Height = 44.5f;
            skill6_preview.Outline = 0;
            skill6_preview.Shadow = 0;
            skill6_preview.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            skill6_preview.ForeColor = -1;
            skill6_preview.BackColor = 125;
            skill6_preview.BoxColor = 67;
            skill6_preview.UseBox = false;
            skill6_preview.Proportional = true;
            skill6_preview.Selectable = true;
            skill6_preview.PreviewModel = 18631;
            skill6_preview.PreviewRotation = new SampSharp.GameMode.Vector3(19.000000, -29.000000, 15.000000);
            skill6_preview.PreviewZoom = 1.009999f;

            skill7_preview = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(254.000000, 268.000000), "Preview_Model");
            skill7_preview.Font = SampSharp.GameMode.Definitions.TextDrawFont.PreviewModel;
            skill7_preview.LetterSize = new SampSharp.GameMode.Vector2(0.600000, 2.000000);
            skill7_preview.Width = 44;
            skill7_preview.Height = 44.5f;
            skill7_preview.Outline = 0;
            skill7_preview.Shadow = 0;
            skill7_preview.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            skill7_preview.ForeColor = -1;
            skill7_preview.BackColor = 125;
            skill7_preview.BoxColor = 67;
            skill7_preview.UseBox = false;
            skill7_preview.Proportional = true;
            skill7_preview.Selectable = true;
            skill7_preview.PreviewModel = 18631;
            skill7_preview.PreviewRotation = new SampSharp.GameMode.Vector3(19.000000, -29.000000, 15.000000);
            skill7_preview.PreviewZoom = 1.009999f;

            skill8_preview = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(254.000000, 317.000000), "Preview_Model");
            skill8_preview.Font = SampSharp.GameMode.Definitions.TextDrawFont.PreviewModel;
            skill8_preview.LetterSize = new SampSharp.GameMode.Vector2(0.600000, 2.000000);
            skill8_preview.Width = 44;
            skill8_preview.Height = 44.5f;
            skill8_preview.Outline = 0;
            skill8_preview.Shadow = 0;
            skill8_preview.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            skill8_preview.ForeColor = -1;
            skill8_preview.BackColor = 125;
            skill8_preview.BoxColor = 67;
            skill8_preview.UseBox = false;
            skill8_preview.Proportional = true;
            skill8_preview.Selectable = true;
            skill8_preview.PreviewModel = 18631;
            skill8_preview.PreviewRotation = new SampSharp.GameMode.Vector3(19.000000, -29.000000, 15.000000);
            skill8_preview.PreviewZoom = 1.009999f;

            skillmenuText = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(306.000000, 169.000000), "CRAFT_level_49/50");
            skillmenuText.Font = SampSharp.GameMode.Definitions.TextDrawFont.Normal;
            skillmenuText.LetterSize = new SampSharp.GameMode.Vector2(0.275000, 1.149999);
            skillmenuText.Width = 448.5f;
            skillmenuText.Height = 14.0f;
            skillmenuText.Outline = 1;
            skillmenuText.Shadow = 0;
            skillmenuText.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            skillmenuText.ForeColor = -1;
            skillmenuText.BackColor = 255;
            skillmenuText.BoxColor = 1433087831;
            skillmenuText.UseBox = true;
            skillmenuText.Proportional = true;
            skillmenuText.Selectable = false;

            /**
1stskill[playerid] = CreatePlayerTextDraw(playerid, 308.000000, 186.000000, "Preview_Model");
PlayerTextDrawFont(playerid, 1stskill[playerid], 5);
PlayerTextDrawLetterSize(playerid, 1stskill[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, 1stskill[playerid], 29.000000, 28.000000);
PlayerTextDrawSetOutline(playerid, 1stskill[playerid], 0);
PlayerTextDrawSetShadow(playerid, 1stskill[playerid], 0);
PlayerTextDrawAlignment(playerid, 1stskill[playerid], 1);
PlayerTextDrawColor(playerid, 1stskill[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, 1stskill[playerid], -1094795651);
PlayerTextDrawBoxColor(playerid, 1stskill[playerid], -1094795709);
PlayerTextDrawUseBox(playerid, 1stskill[playerid], 0);
PlayerTextDrawSetProportional(playerid, 1stskill[playerid], 1);
PlayerTextDrawSetSelectable(playerid, 1stskill[playerid], 1);
PlayerTextDrawSetPreviewModel(playerid, 1stskill[playerid], 19631);
PlayerTextDrawSetPreviewRot(playerid, 1stskill[playerid], -14.000000, -3.000000, -67.000000, 0.949998);
PlayerTextDrawSetPreviewVehCol(playerid, 1stskill[playerid], 1, 1);
**/
            skill1Ico = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(308.000000, 186.000000), "Preview_Model");
            skill1Ico.Font = SampSharp.GameMode.Definitions.TextDrawFont.PreviewModel;
            skill1Ico.LetterSize = new SampSharp.GameMode.Vector2(0.600000, 2.000000);
            skill1Ico.Width = 29f;
            skill1Ico.Height = 28;

            skill1Ico.Outline = 0;
            skill1Ico.Shadow = 0;
            skill1Ico.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            skill1Ico.ForeColor = -1;
            skill1Ico.BackColor = -1094795651;
            skill1Ico.BoxColor = -1094795709;
            skill1Ico.UseBox = false;
            skill1Ico.Proportional = true;
            skill1Ico.Selectable = true;
            skill1Ico.PreviewModel = 19631;
            skill1Ico.PreviewRotation = new SampSharp.GameMode.Vector3(-14.000000, -3.000000, -67.000000);
            skill1Ico.PreviewZoom = 0.949998f;

            /**
1stskilltext[playerid] = CreatePlayerTextDraw(playerid, 342.000000, 195.000000, "crafter_(0/5)");
PlayerTextDrawFont(playerid, 1stskilltext[playerid], 3);
PlayerTextDrawLetterSize(playerid, 1stskilltext[playerid], 0.275000, 1.149999);
PlayerTextDrawTextSize(playerid, 1stskilltext[playerid], 448.500000, 14.000000);
PlayerTextDrawSetOutline(playerid, 1stskilltext[playerid], 1);
PlayerTextDrawSetShadow(playerid, 1stskilltext[playerid], 0);
PlayerTextDrawAlignment(playerid, 1stskilltext[playerid], 1);
PlayerTextDrawColor(playerid, 1stskilltext[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, 1stskilltext[playerid], 255);
PlayerTextDrawBoxColor(playerid, 1stskilltext[playerid], 1858913613);
PlayerTextDrawUseBox(playerid, 1stskilltext[playerid], 1);
PlayerTextDrawSetProportional(playerid, 1stskilltext[playerid], 1);
PlayerTextDrawSetSelectable(playerid, 1stskilltext[playerid], 0);
**/
            skill1text = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(342.000000, 195.000000), "crafter_(0/5)");
            skill1text.Font = SampSharp.GameMode.Definitions.TextDrawFont.Pricedown;
            skill1text.LetterSize = new SampSharp.GameMode.Vector2(0.275000, 1.149999);
            skill1text.Width = 448.5f;
            skill1text.Height = 14f;
            skill1text.Outline = 1;
            skill1text.Shadow = 0;
            skill1text.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            skill1text.ForeColor = -1;
            skill1text.BackColor = 255;
            skill1text.BoxColor = 1858913613;
            skill1text.UseBox = true;
            skill1text.Proportional = true;
            skill1text.Selectable = false;

            /**
2ndskill[playerid] = CreatePlayerTextDraw(playerid, 308.000000, 219.000000, "Preview_Model");
PlayerTextDrawFont(playerid, 2ndskill[playerid], 5);
PlayerTextDrawLetterSize(playerid, 2ndskill[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, 2ndskill[playerid], 29.000000, 28.000000);
PlayerTextDrawSetOutline(playerid, 2ndskill[playerid], 0);
PlayerTextDrawSetShadow(playerid, 2ndskill[playerid], 0);
PlayerTextDrawAlignment(playerid, 2ndskill[playerid], 1);
PlayerTextDrawColor(playerid, 2ndskill[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, 2ndskill[playerid], -1094795651);
PlayerTextDrawBoxColor(playerid, 2ndskill[playerid], -1094795709);
PlayerTextDrawUseBox(playerid, 2ndskill[playerid], 0);
PlayerTextDrawSetProportional(playerid, 2ndskill[playerid], 1);
PlayerTextDrawSetSelectable(playerid, 2ndskill[playerid], 1);
PlayerTextDrawSetPreviewModel(playerid, 2ndskill[playerid], 1463);
PlayerTextDrawSetPreviewRot(playerid, 2ndskill[playerid], -14.000000, -3.000000, -67.000000, 0.949998);
PlayerTextDrawSetPreviewVehCol(playerid, 2ndskill[playerid], 1, 1);
**/
            skill2Ico = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(308.000000, 219.000000), "Preview_Model");
            skill2Ico.Font = SampSharp.GameMode.Definitions.TextDrawFont.PreviewModel;
            skill2Ico.LetterSize = new SampSharp.GameMode.Vector2(0.600000, 2.000000);
            skill2Ico.Width = 29;
            skill2Ico.Height = 28;
            skill2Ico.Outline = 0;
            skill2Ico.Shadow = 0;
            skill2Ico.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            skill2Ico.ForeColor = -1;
            skill2Ico.BackColor = -1094795651;
            skill2Ico.BoxColor = -1094795709;
            skill2Ico.UseBox = false;
            skill2Ico.Proportional = true;
            skill2Ico.Selectable = true;
            skill2Ico.PreviewModel = 1463;
            skill2Ico.PreviewRotation = new SampSharp.GameMode.Vector3(-14.000000, -3.000000, -67.000000);
            skill2Ico.PreviewZoom = 0.949998f;
            /**
2ndskilltext[playerid] = CreatePlayerTextDraw(playerid, 342.000000, 227.000000, "processing_(0/5)");
PlayerTextDrawFont(playerid, 2ndskilltext[playerid], 3);
PlayerTextDrawLetterSize(playerid, 2ndskilltext[playerid], 0.275000, 1.149999);
PlayerTextDrawTextSize(playerid, 2ndskilltext[playerid], 448.500000, 14.000000);
PlayerTextDrawSetOutline(playerid, 2ndskilltext[playerid], 1);
PlayerTextDrawSetShadow(playerid, 2ndskilltext[playerid], 0);
PlayerTextDrawAlignment(playerid, 2ndskilltext[playerid], 1);
PlayerTextDrawColor(playerid, 2ndskilltext[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, 2ndskilltext[playerid], 255);
PlayerTextDrawBoxColor(playerid, 2ndskilltext[playerid], 1858913613);
PlayerTextDrawUseBox(playerid, 2ndskilltext[playerid], 1);
PlayerTextDrawSetProportional(playerid, 2ndskilltext[playerid], 1);
PlayerTextDrawSetSelectable(playerid, 2ndskilltext[playerid], 0);
**/
            skill2text = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(342.000000, 227.000000), "processing_(0/5)");
            skill2text.Font = SampSharp.GameMode.Definitions.TextDrawFont.Pricedown;
            skill2text.LetterSize = new SampSharp.GameMode.Vector2(0.275000, 1.149999);
            skill2text.Width = 448.5f;
            skill2text.Height = 14f;
            skill2text.Outline = 1;
            skill2text.Shadow = 0;
            skill2text.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            skill2text.ForeColor = -1;
            skill2text.BackColor = 255;
            skill2text.BoxColor = 1858913613;
            skill2text.UseBox = true;
            skill2text.Proportional = true;
            skill2text.Selectable = false;
            /**
3rdskill[playerid] = CreatePlayerTextDraw(playerid, 308.000000, 252.000000, "Preview_Model");
PlayerTextDrawFont(playerid, 3rdskill[playerid], 5);
PlayerTextDrawLetterSize(playerid, 3rdskill[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, 3rdskill[playerid], 29.000000, 28.000000);
PlayerTextDrawSetOutline(playerid, 3rdskill[playerid], 0);
PlayerTextDrawSetShadow(playerid, 3rdskill[playerid], 0);
PlayerTextDrawAlignment(playerid, 3rdskill[playerid], 1);
PlayerTextDrawColor(playerid, 3rdskill[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, 3rdskill[playerid], -1094795651);
PlayerTextDrawBoxColor(playerid, 3rdskill[playerid], -1094795709);
PlayerTextDrawUseBox(playerid, 3rdskill[playerid], 0);
PlayerTextDrawSetProportional(playerid, 3rdskill[playerid], 1);
PlayerTextDrawSetSelectable(playerid, 3rdskill[playerid], 1);
PlayerTextDrawSetPreviewModel(playerid, 3rdskill[playerid], 18875);
PlayerTextDrawSetPreviewRot(playerid, 3rdskill[playerid], -93.000000, 7.000000, -179.000000, 0.949998);
PlayerTextDrawSetPreviewVehCol(playerid, 3rdskill[playerid], 1, 1);
**/
            skill3Ico = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(308.000000, 252.000000), "Preview_Model");
            skill3Ico.Font = SampSharp.GameMode.Definitions.TextDrawFont.PreviewModel;
            skill3Ico.LetterSize = new SampSharp.GameMode.Vector2(0.600000, 2.000000);
            skill3Ico.Width = 29f;
            skill3Ico.Height = 28;
            skill3Ico.Outline = 0;
            skill3Ico.Shadow = 0;
            skill3Ico.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            skill3Ico.ForeColor = -1;
            skill3Ico.BackColor = -1094795651;
            skill3Ico.BoxColor = -1094795709;
            skill3Ico.UseBox = false;
            skill3Ico.Proportional = true;
            skill3Ico.Selectable = true;
            skill3Ico.PreviewModel = 18875;
            skill3Ico.PreviewRotation = new SampSharp.GameMode.Vector3(-93.000000, 7.000000, -179.000000);
            skill3Ico.PreviewZoom = 0.949998f;
            /**
3rdskilltext[playerid] = CreatePlayerTextDraw(playerid, 342.000000, 261.000000, "radiotechnics_(0/5)");
PlayerTextDrawFont(playerid, 3rdskilltext[playerid], 3);
PlayerTextDrawLetterSize(playerid, 3rdskilltext[playerid], 0.275000, 1.149999);
PlayerTextDrawTextSize(playerid, 3rdskilltext[playerid], 448.500000, 14.000000);
PlayerTextDrawSetOutline(playerid, 3rdskilltext[playerid], 1);
PlayerTextDrawSetShadow(playerid, 3rdskilltext[playerid], 0);
PlayerTextDrawAlignment(playerid, 3rdskilltext[playerid], 1);
PlayerTextDrawColor(playerid, 3rdskilltext[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, 3rdskilltext[playerid], 255);
PlayerTextDrawBoxColor(playerid, 3rdskilltext[playerid], 1858913613);
PlayerTextDrawUseBox(playerid, 3rdskilltext[playerid], 1);
PlayerTextDrawSetProportional(playerid, 3rdskilltext[playerid], 1);
PlayerTextDrawSetSelectable(playerid, 3rdskilltext[playerid], 0);
**/
            skill3text = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(342.000000, 261.000000), "radiotechnics_(0/5)");
            skill3text.Font = SampSharp.GameMode.Definitions.TextDrawFont.Pricedown;
            skill3text.LetterSize = new SampSharp.GameMode.Vector2(0.275000, 1.149999);
            skill3text.Width = 448.5f;
            skill3text.Height = 14f;
            skill3text.Outline = 1;
            skill3text.Shadow = 0;
            skill3text.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            skill3text.ForeColor = -1;
            skill3text.BackColor = 255;
            skill3text.BoxColor = 1858913613;
            skill3text.UseBox = true;
            skill3text.Proportional = true;
            skill3text.Selectable = false;
            /**
4thskill[playerid] = CreatePlayerTextDraw(playerid, 308.000000, 286.000000, "Preview_Model");
PlayerTextDrawFont(playerid, 4thskill[playerid], 5);
PlayerTextDrawLetterSize(playerid, 4thskill[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, 4thskill[playerid], 29.000000, 28.000000);
PlayerTextDrawSetOutline(playerid, 4thskill[playerid], 0);
PlayerTextDrawSetShadow(playerid, 4thskill[playerid], 0);
PlayerTextDrawAlignment(playerid, 4thskill[playerid], 1);
PlayerTextDrawColor(playerid, 4thskill[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, 4thskill[playerid], -1094795651);
PlayerTextDrawBoxColor(playerid, 4thskill[playerid], -1094795709);
PlayerTextDrawUseBox(playerid, 4thskill[playerid], 0);
PlayerTextDrawSetProportional(playerid, 4thskill[playerid], 1);
PlayerTextDrawSetSelectable(playerid, 4thskill[playerid], 1);
PlayerTextDrawSetPreviewModel(playerid, 4thskill[playerid], 1275);
PlayerTextDrawSetPreviewRot(playerid, 4thskill[playerid], -12.000000, 2.000000, -182.000000, 0.949998);
PlayerTextDrawSetPreviewVehCol(playerid, 4thskill[playerid], 1, 1);
**/
            skill4Ico = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(308.000000, 286.000000), "Preview_Model");
            skill4Ico.Font = SampSharp.GameMode.Definitions.TextDrawFont.PreviewModel;
            skill4Ico.LetterSize = new SampSharp.GameMode.Vector2(0.600000, 2.000000);
            skill4Ico.Width = 29f;
            skill4Ico.Height = 28f;
            skill4Ico.Outline = 0;
            skill4Ico.Shadow = 0;
            skill4Ico.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            skill4Ico.ForeColor = -1;
            skill4Ico.BackColor = -1094795651;
            skill4Ico.BoxColor = -1094795709;
            skill4Ico.UseBox = false;
            skill4Ico.Proportional = true;
            skill4Ico.Selectable = true;
            skill4Ico.PreviewModel = 1275;
            skill4Ico.PreviewRotation = new SampSharp.GameMode.Vector3(-12.000000, 2.000000, -182.000000);
            skill4Ico.PreviewZoom = 0.949998f;
            /**
4thskilltext[playerid] = CreatePlayerTextDraw(playerid, 342.000000, 294.000000, "sewing (0/5)");
PlayerTextDrawFont(playerid, 4thskilltext[playerid], 3);
PlayerTextDrawLetterSize(playerid, 4thskilltext[playerid], 0.275000, 1.149999);
PlayerTextDrawTextSize(playerid, 4thskilltext[playerid], 448.500000, 14.000000);
PlayerTextDrawSetOutline(playerid, 4thskilltext[playerid], 1);
PlayerTextDrawSetShadow(playerid, 4thskilltext[playerid], 0);
PlayerTextDrawAlignment(playerid, 4thskilltext[playerid], 1);
PlayerTextDrawColor(playerid, 4thskilltext[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, 4thskilltext[playerid], 255);
PlayerTextDrawBoxColor(playerid, 4thskilltext[playerid], 1858913613);
PlayerTextDrawUseBox(playerid, 4thskilltext[playerid], 1);
PlayerTextDrawSetProportional(playerid, 4thskilltext[playerid], 1);
PlayerTextDrawSetSelectable(playerid, 4thskilltext[playerid], 0);
**/
            skill4text = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(342.000000, 294.000000), "sewing (0/5)");
            skill4text.Font = SampSharp.GameMode.Definitions.TextDrawFont.Pricedown;
            skill4text.LetterSize = new SampSharp.GameMode.Vector2(0.275000, 1.149999);
            skill4text.Width = 448.5f;
            skill4text.Height = 14f;
            skill4text.Outline = 1;
            skill4text.Shadow = 0;
            skill4text.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            skill4text.ForeColor = -1;
            skill4text.BackColor = 255;
            skill4text.BoxColor = 1858913613;
            skill4text.UseBox = true;
            skill4text.Proportional = true;
            skill4text.Selectable = false;
            /**
5thskill[playerid] = CreatePlayerTextDraw(playerid, 308.000000, 321.000000, "Preview_Model");
PlayerTextDrawFont(playerid, 5thskill[playerid], 5);
PlayerTextDrawLetterSize(playerid, 5thskill[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, 5thskill[playerid], 29.000000, 28.000000);
PlayerTextDrawSetOutline(playerid, 5thskill[playerid], 0);
PlayerTextDrawSetShadow(playerid, 5thskill[playerid], 0);
PlayerTextDrawAlignment(playerid, 5thskill[playerid], 1);
PlayerTextDrawColor(playerid, 5thskill[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, 5thskill[playerid], -1094795651);
PlayerTextDrawBoxColor(playerid, 5thskill[playerid], -1094795709);
PlayerTextDrawUseBox(playerid, 5thskill[playerid], 0);
PlayerTextDrawSetProportional(playerid, 5thskill[playerid], 1);
PlayerTextDrawSetSelectable(playerid, 5thskill[playerid], 1);
PlayerTextDrawSetPreviewModel(playerid, 5thskill[playerid], 19941);
PlayerTextDrawSetPreviewRot(playerid, 5thskill[playerid], -12.000000, 2.000000, -182.000000, 0.949998);
PlayerTextDrawSetPreviewVehCol(playerid, 5thskill[playerid], 1, 1);
**/
            skill5Ico = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(308.000000, 321.000000), "Preview_Model");
            skill5Ico.Font = SampSharp.GameMode.Definitions.TextDrawFont.PreviewModel;
            skill5Ico.LetterSize = new SampSharp.GameMode.Vector2(0.600000, 2.000000);
            skill5Ico.Width = 29f;
            skill5Ico.Height = 28;
            skill5Ico.Outline = 0;
            skill5Ico.Shadow = 0;
            skill5Ico.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            skill5Ico.ForeColor = -1;
            skill5Ico.BackColor = -1094795651;
            skill5Ico.BoxColor = -1094795709;
            skill5Ico.UseBox = false;
            skill5Ico.Proportional = true;
            skill5Ico.Selectable = true;
            skill5Ico.PreviewModel = 19941;
            skill5Ico.PreviewRotation = new SampSharp.GameMode.Vector3(-12.000000, 2.000000, -182.000000);
            skill5Ico.PreviewZoom = 0.949998f;
            /**
5thskilltext[playerid] = CreatePlayerTextDraw(playerid, 342.000000, 329.000000, "blacksmith_(1/5)");
PlayerTextDrawFont(playerid, 5thskilltext[playerid], 3);
PlayerTextDrawLetterSize(playerid, 5thskilltext[playerid], 0.275000, 1.149999);
PlayerTextDrawTextSize(playerid, 5thskilltext[playerid], 448.500000, 14.000000);
PlayerTextDrawSetOutline(playerid, 5thskilltext[playerid], 1);
PlayerTextDrawSetShadow(playerid, 5thskilltext[playerid], 0);
PlayerTextDrawAlignment(playerid, 5thskilltext[playerid], 1);
PlayerTextDrawColor(playerid, 5thskilltext[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, 5thskilltext[playerid], 255);
PlayerTextDrawBoxColor(playerid, 5thskilltext[playerid], 1858913613);
PlayerTextDrawUseBox(playerid, 5thskilltext[playerid], 1);
PlayerTextDrawSetProportional(playerid, 5thskilltext[playerid], 1);
PlayerTextDrawSetSelectable(playerid, 5thskilltext[playerid], 0);
**/
            skill5text = new PlayerTextDraw(player, new SampSharp.GameMode.Vector2(342.000000, 329.000000), "blacksmith_(0/5)");
            skill5text.Font = SampSharp.GameMode.Definitions.TextDrawFont.Pricedown;
            skill5text.LetterSize = new SampSharp.GameMode.Vector2(0.275000, 1.149999);
            skill5text.Width = 448.5f;
            skill5text.Height = 14f;
            skill5text.Outline = 1;
            skill5text.Shadow = 0;
            skill5text.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            skill5text.ForeColor = -1;
            skill5text.BackColor = 255;
            skill5text.BoxColor = 1858913613;
            skill5text.UseBox = true;
            skill5text.Proportional = true;
            skill5text.Selectable = false;
            /**
closebutton[playerid] = CreatePlayerTextDraw(playerid, 437.000000, 168.000000, "LD_BEAT:CROSS");
PlayerTextDrawFont(playerid, closebutton[playerid], 4);
PlayerTextDrawLetterSize(playerid, closebutton[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, closebutton[playerid], 12.500000, 12.500000);
PlayerTextDrawSetOutline(playerid, closebutton[playerid], 1);
PlayerTextDrawSetShadow(playerid, closebutton[playerid], 0);
PlayerTextDrawAlignment(playerid, closebutton[playerid], 1);
PlayerTextDrawColor(playerid, closebutton[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, closebutton[playerid], 255);
PlayerTextDrawBoxColor(playerid, closebutton[playerid], 50);
PlayerTextDrawUseBox(playerid, closebutton[playerid], 1);
PlayerTextDrawSetProportional(playerid, closebutton[playerid], 1);
PlayerTextDrawSetSelectable(playerid, closebutton[playerid], 1);
**/
            closeButton = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(437, 168), "LD_BEAT:CROSS");
            closeButton.Font = SampSharp.GameMode.Definitions.TextDrawFont.DrawSprite;
            closeButton.LetterSize = new SampSharp.GameMode.Vector2(0.6, 2.0);
            closeButton.Width = 12.5f;
            closeButton.Height = 12.5f;
            closeButton.Outline = 1;
            closeButton.Shadow = 0;
            closeButton.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            closeButton.ForeColor = -1;
            closeButton.BackColor = 255;
            closeButton.BoxColor = 50;
            closeButton.UseBox = true;
            closeButton.Proportional = true;
            closeButton.Selectable = true;

        }
        public void Show()
        {
             isOpen = true;
             backplate.Show();
             upperBorder.Show();
             lowerBorder.Show();
             leftBorder.Show();
             rightBorder.Show();
             centerBorder.Show();

             craft_preview.Show();
             craft_text.Show();
             cooking_preview.Show();
             cooking_text.Show();
             medicine_preview.Show();
             medicine_text.Show();
             survival_preview.Show();
             survival_text.Show();
             tactics_preview.Show();
             tactics_text.Show();
             skill6_preview.Show();
             skill7_preview.Show();
             skill8_preview.Show();

             skillmenuText.Show();

             skill1Ico.Show();
             skill2Ico.Show();
             skill3Ico.Show();
             skill4Ico.Show();
             skill5Ico.Show();

             skill1text.Show();
             skill2text.Show();
             skill3text.Show();
             skill4text.Show();
             skill5text.Show();

             closeButton.Show();
        }
        public void Close()
        {
            isOpen = false;
           // p.CancelSelectTextDraw();
            backplate.Hide();
            upperBorder.Hide();
            lowerBorder.Hide();
            leftBorder.Hide();
            rightBorder.Hide();
            centerBorder.Hide();

            craft_preview.Hide();
            craft_text.Hide();
            cooking_preview.Hide();
            cooking_text.Hide();
            medicine_preview.Hide();
            medicine_text.Hide();
            survival_preview.Hide();
            survival_text.Hide();
            tactics_preview.Hide();
            tactics_text.Hide();
            skill6_preview.Hide();
            skill7_preview.Hide();
            skill8_preview.Hide();

            skillmenuText.Hide();

            skill1Ico.Hide();
            skill2Ico.Hide();
            skill3Ico.Hide();
            skill4Ico.Hide();
            skill5Ico.Hide();

            skill1text.Hide();
            skill2text.Hide();
            skill3text.Hide();
            skill4text.Hide();
            skill5text.Hide();

            closeButton.Hide();
        }
        public void OnClickSkillMenu(object sender, ClickPlayerTextDrawEventArgs e)
        {
            if(e.PlayerTextDraw == closeButton)
            {
                Close();
            }
            if(e.PlayerTextDraw == craft_preview)
            {
                skillmenuText.Text = "Craft level 0/50";
                skill1Ico.PreviewModel = CraftMenu.skills[0].skillModelIco;
                skill1Ico.PreviewRotation = CraftMenu.skills[0].rotation;
                skill1Ico.PreviewZoom = CraftMenu.skills[0].zoom;
                skill1text.Text = $"{CraftMenu.skills[0].skillName}_0/{CraftMenu.skills[0].maximum}";

                skill2Ico.PreviewModel = CraftMenu.skills[1].skillModelIco;
                skill2Ico.PreviewRotation = CraftMenu.skills[1].rotation;
                skill2Ico.PreviewZoom = CraftMenu.skills[1].zoom;
                skill2text.Text = $"{CraftMenu.skills[1].skillName}_0/{CraftMenu.skills[1].maximum}";

                skill3Ico.PreviewModel = CraftMenu.skills[2].skillModelIco;
                skill3Ico.PreviewRotation = CraftMenu.skills[2].rotation;
                skill3Ico.PreviewZoom = CraftMenu.skills[2].zoom;
                skill3text.Text = $"{CraftMenu.skills[2].skillName}_0/{CraftMenu.skills[2].maximum}";

                skill4Ico.PreviewModel = CraftMenu.skills[3].skillModelIco;
                skill4Ico.PreviewRotation = CraftMenu.skills[3].rotation;
                skill4Ico.PreviewZoom = CraftMenu.skills[3].zoom;
                skill4text.Text = $"{CraftMenu.skills[3].skillName}_0/{CraftMenu.skills[3].maximum}";

                skill5Ico.PreviewModel = CraftMenu.skills[4].skillModelIco;
                skill5Ico.PreviewRotation = CraftMenu.skills[4].rotation;
                skill5Ico.PreviewZoom = CraftMenu.skills[4].zoom;
                skill5text.Text = $"{CraftMenu.skills[4].skillName}_0/{CraftMenu.skills[4].maximum}";

                currentPage = 1;
            }
            if (e.PlayerTextDraw == cooking_preview)
            {
                skillmenuText.Text = "Cooking level 0/50";
                skill1Ico.PreviewModel = CookMenu.skills[0].skillModelIco;
                skill1Ico.PreviewRotation = CookMenu.skills[0].rotation;
                skill1Ico.PreviewZoom = CookMenu.skills[0].zoom;
                skill1text.Text = $"{CookMenu.skills[0].skillName}_0/{CookMenu.skills[0].maximum}";

                skill2Ico.PreviewModel = CookMenu.skills[1].skillModelIco;
                skill2Ico.PreviewRotation = CookMenu.skills[1].rotation;
                skill2Ico.PreviewZoom = CookMenu.skills[1].zoom;
                skill2text.Text = $"{CookMenu.skills[1].skillName}_0/{CookMenu.skills[1].maximum}";

                skill3Ico.PreviewModel = CookMenu.skills[2].skillModelIco;
                skill3Ico.PreviewRotation = CookMenu.skills[2].rotation;
                skill3Ico.PreviewZoom = CookMenu.skills[2].zoom;
                skill3text.Text = $"{CookMenu.skills[2].skillName}_0/{CookMenu.skills[2].maximum}";

                skill4Ico.PreviewModel = CookMenu.skills[3].skillModelIco;
                skill4Ico.PreviewRotation = CookMenu.skills[3].rotation;
                skill4Ico.PreviewZoom = CookMenu.skills[3].zoom;
                skill4text.Text = $"{CookMenu.skills[3].skillName}_0/{CookMenu.skills[3].maximum}";

                skill5Ico.PreviewModel = CookMenu.skills[4].skillModelIco;
                skill5Ico.PreviewRotation = CookMenu.skills[4].rotation;
                skill5Ico.PreviewZoom = CookMenu.skills[4].zoom;
                skill5text.Text = $"{CookMenu.skills[4].skillName}_0/{CookMenu.skills[4].maximum}";
                currentPage = 2;
            }
            if (e.PlayerTextDraw == medicine_preview)
            {
                skillmenuText.Text = "Medicine level 0/50";
                skill1Ico.PreviewModel = MedicineMenu.skills[0].skillModelIco;
                skill1Ico.PreviewRotation = MedicineMenu.skills[0].rotation;
                skill1Ico.PreviewZoom = MedicineMenu.skills[0].zoom;
                skill1text.Text = $"{MedicineMenu.skills[0].skillName}_0/{MedicineMenu.skills[0].maximum}";

                skill2Ico.PreviewModel = MedicineMenu.skills[1].skillModelIco;
                skill2Ico.PreviewRotation = MedicineMenu.skills[1].rotation;
                skill2Ico.PreviewZoom = MedicineMenu.skills[1].zoom;
                skill2text.Text = $"{MedicineMenu.skills[1].skillName}_0/{MedicineMenu.skills[1].maximum}";

                skill3Ico.PreviewModel = MedicineMenu.skills[2].skillModelIco;
                skill3Ico.PreviewRotation = MedicineMenu.skills[2].rotation;
                skill3Ico.PreviewZoom = MedicineMenu.skills[2].zoom;
                skill3text.Text = $"{MedicineMenu.skills[2].skillName}_0/{MedicineMenu.skills[2].maximum}";

                skill4Ico.PreviewModel = MedicineMenu.skills[3].skillModelIco;
                skill4Ico.PreviewRotation = MedicineMenu.skills[3].rotation;
                skill4Ico.PreviewZoom = MedicineMenu.skills[3].zoom;
                skill4text.Text = $"{MedicineMenu.skills[3].skillName}_0/{MedicineMenu.skills[3].maximum}";

                skill5Ico.PreviewModel = MedicineMenu.skills[4].skillModelIco;
                skill5Ico.PreviewRotation = MedicineMenu.skills[4].rotation;
                skill5Ico.PreviewZoom = MedicineMenu.skills[4].zoom;
                skill5text.Text = $"{MedicineMenu.skills[4].skillName}_0/{MedicineMenu.skills[4].maximum}";
                currentPage = 3;
            }
            if (e.PlayerTextDraw == survival_preview)
            {
                skillmenuText.Text = "Survival level 0/50";
                skill1Ico.PreviewModel = SurvivalMenu.skills[0].skillModelIco;
                skill1Ico.PreviewRotation = SurvivalMenu.skills[0].rotation;
                skill1Ico.PreviewZoom = SurvivalMenu.skills[0].zoom;
                skill1text.Text = $"{SurvivalMenu.skills[0].skillName}_0/{SurvivalMenu.skills[0].maximum}";

                skill2Ico.PreviewModel = SurvivalMenu.skills[1].skillModelIco;
                skill2Ico.PreviewRotation = SurvivalMenu.skills[1].rotation;
                skill2Ico.PreviewZoom = SurvivalMenu.skills[1].zoom;
                skill2text.Text = $"{SurvivalMenu.skills[1].skillName}_0/{SurvivalMenu.skills[1].maximum}";

                skill3Ico.PreviewModel = SurvivalMenu.skills[2].skillModelIco;
                skill3Ico.PreviewRotation = SurvivalMenu.skills[2].rotation;
                skill3Ico.PreviewZoom = SurvivalMenu.skills[2].zoom;
                skill3text.Text = $"{SurvivalMenu.skills[2].skillName}_0/{SurvivalMenu.skills[2].maximum}";

                skill4Ico.PreviewModel = SurvivalMenu.skills[3].skillModelIco;
                skill4Ico.PreviewRotation = SurvivalMenu.skills[3].rotation;
                skill4Ico.PreviewZoom = SurvivalMenu.skills[3].zoom;
                skill4text.Text = $"{SurvivalMenu.skills[3].skillName}_0/{SurvivalMenu.skills[3].maximum}";

                skill5Ico.PreviewModel = SurvivalMenu.skills[4].skillModelIco;
                skill5Ico.PreviewRotation = SurvivalMenu.skills[4].rotation;
                skill5Ico.PreviewZoom = SurvivalMenu.skills[4].zoom;
                skill5text.Text = $"{SurvivalMenu.skills[4].skillName}_0/{SurvivalMenu.skills[4].maximum}";
                currentPage = 4;
            }
            if (e.PlayerTextDraw == tactics_preview)
            {
                skillmenuText.Text = "Tactics level 0/50";
                skill1Ico.PreviewModel = TacticsMenu.skills[0].skillModelIco;
                skill1Ico.PreviewRotation = TacticsMenu.skills[0].rotation;
                skill1Ico.PreviewZoom = TacticsMenu.skills[0].zoom;
                skill1text.Text = $"{TacticsMenu.skills[0].skillName}_0/{TacticsMenu.skills[0].maximum}";

                skill2Ico.PreviewModel = TacticsMenu.skills[1].skillModelIco;
                skill2Ico.PreviewRotation = TacticsMenu.skills[1].rotation;
                skill2Ico.PreviewZoom = TacticsMenu.skills[1].zoom;
                skill2text.Text = $"{TacticsMenu.skills[1].skillName}_0/{TacticsMenu.skills[1].maximum}";

                skill3Ico.PreviewModel = TacticsMenu.skills[2].skillModelIco;
                skill3Ico.PreviewRotation = TacticsMenu.skills[2].rotation;
                skill3Ico.PreviewZoom = TacticsMenu.skills[2].zoom;
                skill3text.Text = $"{TacticsMenu.skills[2].skillName}_0/{TacticsMenu.skills[2].maximum}";

                skill4Ico.PreviewModel = TacticsMenu.skills[3].skillModelIco;
                skill4Ico.PreviewRotation = TacticsMenu.skills[3].rotation;
                skill4Ico.PreviewZoom = TacticsMenu.skills[3].zoom;
                skill4text.Text = $"{TacticsMenu.skills[3].skillName}_0/{TacticsMenu.skills[3].maximum}";

                skill5Ico.PreviewModel = TacticsMenu.skills[4].skillModelIco;
                skill5Ico.PreviewRotation = TacticsMenu.skills[4].rotation;
                skill5Ico.PreviewZoom = TacticsMenu.skills[4].zoom;
                skill5text.Text = $"{TacticsMenu.skills[4].skillName}_0/{TacticsMenu.skills[4].maximum}";
                currentPage = 5;
            }

        }
         
    }
    class Skills
    {
        public string skillName = string.Empty;
        public int skillModelIco = 0;
        public Vector3 rotation;
        public int maximum = 0;
        public float zoom;
        public Skills(string name, int modelIco, Vector3 rotation, float zoom, int maximum) { 
            skillName = name;
            skillModelIco = modelIco;
            this.rotation = rotation;
            this.zoom = zoom;
            this.maximum = maximum;
        }
    }
    static class CraftMenu
    {
        public static Skills[] skills = new Skills[]{
            new Skills("crafter", 19631, new Vector3(-14.000000, -3.000000, -67.000000), 0.949998f, 5),
            new Skills("carpenter", 1463, new Vector3(-14.000000, -3.000000, -67.000000), 0.949998f, 5),
            new Skills("radiotechnics", 18875, new Vector3(-93.000000, 7.000000, -179.000000), 0.949998f, 5),
            new Skills("sewing", 1275, new Vector3(-12.000000, 2.000000, -182.000000), 0.949998f, 5),
            new Skills("blacksmith", 19941, new Vector3(-12.000000, 2.000000, -182.000000), 0.949998f, 5),


        };
    }
    static class CookMenu
    {
        public static Skills[] skills = new Skills[]{
            new Skills("Cook", 19584, new Vector3(-33.000000, -3.000000, -192.000000), 1.139997f, 5),
            new Skills("quality", 19882, new Vector3(-75.000000, -3.000000, -67.000000), 0.949998f, 5),
            new Skills("stability", 1667, new Vector3(-10.000000, 1.000000, -159.000000), 0.949998f, 5),
            new Skills("canning", 2663, new Vector3(-12.000000, 2.000000, -182.000000), 0.949998f, 5),
            new Skills("processing", 19630, new Vector3(-12.000000, 2.000000, -182.000000), 0.949998f, 5),

        };
    }
    static class MedicineMenu
    {
       public static Skills[] skills = new Skills[]{
            new Skills("medicine", 19222, new Vector3(-89.000000, -3.000000, -180.000000), 0.259998f, 5),
            new Skills("bandaging", 11736, new Vector3(-90.000000, 0.000000, -180.000000), 0.949998f, 5),
            new Skills("health", 19194, new Vector3(-90.000000, 0.000000, -180.000000), 0.349998f, 5),
            new Skills("chemist", 19823, new Vector3(-12.000000, 2.000000, -182.000000), 0.949998f, 5),
            new Skills("reanimation", 1313, new Vector3(-12.000000, 2.000000, -182.000000), 0.949998f, 1),

        };
    }
    static class SurvivalMenu
    {
       public static Skills[] skills = new Skills[]{
            new Skills("breaking", 19804, new Vector3(-11.000000, 0.000000, -180.000000), 1.059999f, 5),
            new Skills("lighting_fire", 19632, new Vector3(-10.000000, 0.000000, -180.000000), 1.189997f, 5),
            new Skills("strength", 3071, new Vector3(-93.000000, 93.000000, -185.000000), 1.649998f, 5),
            new Skills("stomach", 2769, new Vector3(-12.000000, 2.000000, -182.000000), 0.949998f, 5),
            new Skills("fishing", 19630, new Vector3(-12.000000, 2.000000, -182.000000), 0.949998f, 5),

        };
    }
    static class TacticsMenu
    {
        public static Skills[] skills = new Skills[]{
            new Skills("tactics", 19785, new Vector3(-90.000000, 0.000000, 0.000000), 1.059999f, 5),
            new Skills("pistols", 348, new Vector3(-10.000000, 0.000000, -180.000000), 1.189997f, 5),
            new Skills("shotguns", 350, new Vector3(0.000000, 0.000000, -180.000000), 1.819997f, 5),
            new Skills("auto", 356, new Vector3(-12.000000, 2.000000, -182.000000), 2.299996f, 5),
            new Skills("semi", 372, new Vector3(-12.000000, 2.000000, -182.000000), 1.329997f, 5),

        };
    }

}

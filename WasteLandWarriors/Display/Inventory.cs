using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampSharp.GameMode.Tools;
using SampSharp.GameMode.SAMP;

namespace WasteLandWarriors.Display
{
    public class Inventory
    {
        private Player p;
        private PlayerTextDraw inventoryBackPlate;
        private PlayerTextDraw playerButton;
        private PlayerTextDraw helmetbutton;
        private PlayerTextDraw backpackButton;
        private PlayerTextDraw armourButton;
        private PlayerTextDraw pagerButton;
        private PlayerTextDraw achievementsButton;
        private PlayerTextDraw woodLine;
        private PlayerTextDraw woodInvTxd;
        private PlayerTextDraw rockLine;
        private PlayerTextDraw rockInvTxd;
        private PlayerTextDraw ironLine;
        private PlayerTextDraw ironInvTxd;
        private PlayerTextDraw tcanLine;
        private PlayerTextDraw tkanInvTxd;

        private PlayerTextDraw useButton;
        private PlayerTextDraw dropButton;
        private PlayerTextDraw sellButton;
        private PlayerTextDraw infoButton;
        private PlayerTextDraw closeinv;
        private PlayerTextDraw[] weaponslots = new PlayerTextDraw[6];
        /**
        private PlayerTextDraw[] slots = new PlayerTextDraw[42];
        **/
        private PlayerTextDraw[] weaponslotsAmmo = new PlayerTextDraw[6];
        public Slot[] slots { get; set; } = new Slot[42];


        private int[] weaponslotsAmmoNum = new int[6];
        private PlayerTextDraw woodnum;
        private PlayerTextDraw rocknum;
        private PlayerTextDraw ironnum;
        private PlayerTextDraw tkannum;
        private int[] weaponSlotsInfo = new int[6];
        private bool[] isSlotSelected = new bool[42];

        public int[] slotsinfo = new int[42];

        private int helmetSlot = 0;
        private int ArmorSlot = 0;
        private int backpackSlot = 0;
        
        public Inventory(Player player)
        {
            //________________________INVENTORY_________________________________________________________________________
            this.p = player;

            for(int i = 0; i < 42; i++)
            {
                slots[i] = new Slot();
            }

            inventoryBackPlate = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(476.0f, 110.0f), "_");
            inventoryBackPlate.Font = TextDrawFont.Normal;
            inventoryBackPlate.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 36.599918f);
            inventoryBackPlate.Width = 298.5f;
            inventoryBackPlate.Height = 208.5f;
            inventoryBackPlate.Outline = 1;
            inventoryBackPlate.Shadow = 0;
            inventoryBackPlate.Alignment = TextDrawAlignment.Center;
            inventoryBackPlate.ForeColor = -1;
            inventoryBackPlate.BackColor = 255;
            inventoryBackPlate.BoxColor = 181;
            inventoryBackPlate.UseBox = true;
            inventoryBackPlate.Proportional = true;
            inventoryBackPlate.Selectable = false;

            playerButton = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(404.0f, 114.0f), "Preview_Model");
            playerButton.Font = TextDrawFont.PreviewModel;
            playerButton.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            playerButton.Width = 62.5f;
            playerButton.Height = 93.5f;
            playerButton.Outline = 0;
            playerButton.Shadow = 0;
            playerButton.Alignment = TextDrawAlignment.Left;
            playerButton.ForeColor = -1;
            playerButton.BackColor = -1094795651;
            playerButton.BoxColor = -16777103;
            playerButton.UseBox = false;
            playerButton.Proportional = true;
            playerButton.Selectable = true;
            playerButton.PreviewModel = 285;
            playerButton.PreviewRotation = new SampSharp.GameMode.Vector3(-9.0, 0.0, -2.0);
            playerButton.PreviewZoom = 1;

            helmetbutton = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(375.0f, 114.0f), "Preview_Model");
            helmetbutton.Font = TextDrawFont.PreviewModel;
            helmetbutton.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            helmetbutton.Width = 25.5f;
            helmetbutton.Height = 27.5f;
            helmetbutton.Outline = 0;
            helmetbutton.Shadow = 0;
            helmetbutton.Alignment = TextDrawAlignment.Left;
            helmetbutton.ForeColor = -1;
            helmetbutton.BackColor = -1094795651;
            helmetbutton.BoxColor = -16777103;
            helmetbutton.UseBox = false;
            helmetbutton.Proportional = true;
            helmetbutton.Selectable = true;
            helmetbutton.PreviewModel = 19141;
            helmetbutton.PreviewRotation = new SampSharp.GameMode.Vector3(-3.0, -90.0, 15.0);
            helmetbutton.PreviewZoom = 1;

            backpackButton = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(375.0f, 180.0f), "Preview_Model");
            backpackButton.Font = TextDrawFont.PreviewModel;
            backpackButton.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            backpackButton.Width = 25.5f;
            backpackButton.Height = 27.5f;
            backpackButton.Outline = 0;
            backpackButton.Shadow = 0;
            backpackButton.Alignment = TextDrawAlignment.Left;
            backpackButton.ForeColor = -1;
            backpackButton.BackColor = -1094795651;
            backpackButton.BoxColor = -16777103;
            backpackButton.UseBox = false;
            backpackButton.Proportional = true;
            backpackButton.Selectable = true;
            backpackButton.PreviewModel = 371;
            backpackButton.PreviewRotation = new SampSharp.GameMode.Vector3(-9.0, 0.0, -2.0);
            backpackButton.PreviewZoom = 1;

            armourButton = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(375.0f, 147.0f), "Preview_Model");
            armourButton.Font = TextDrawFont.PreviewModel;
            armourButton.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            armourButton.Width = 25.5f;
            armourButton.Height = 27.5f;
            armourButton.Outline = 0;
            armourButton.Shadow = 0;
            armourButton.Alignment = TextDrawAlignment.Left;
            armourButton.ForeColor = -1;
            armourButton.BackColor = -1094795651;
            armourButton.BoxColor = -16777103;
            armourButton.UseBox = false;
            armourButton.Proportional = true;
            armourButton.Selectable = true;
            armourButton.PreviewModel = 1242;
            armourButton.PreviewRotation = new SampSharp.GameMode.Vector3(-9.0, 0.0, -2.0);
            armourButton.PreviewZoom = 1;

            pagerButton = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(407.0f, 186.0f), "Preview_Model");
            pagerButton.Font = TextDrawFont.PreviewModel;
            pagerButton.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            pagerButton.Width = 17.0f;
            pagerButton.Height = 17.5f;
            pagerButton.Outline = 0;
            pagerButton.Shadow = 0;
            pagerButton.Alignment = TextDrawAlignment.Left;
            pagerButton.ForeColor = -1;
            pagerButton.BackColor = 125;
            pagerButton.BoxColor = -16777103;
            pagerButton.UseBox = false;
            pagerButton.Proportional = true;
            pagerButton.Selectable = true;
            pagerButton.PreviewModel = 18875;
            pagerButton.PreviewRotation = new SampSharp.GameMode.Vector3(-81.0, 0.0, -179.0);
            pagerButton.PreviewZoom = 1;

            achievementsButton = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(447.0f, 186.0f), "Preview_Model");
            achievementsButton.Font = TextDrawFont.PreviewModel;
            achievementsButton.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            achievementsButton.Width = 17.0f;
            achievementsButton.Height = 17.5f;
            achievementsButton.Outline = 0;
            achievementsButton.Shadow = 0;
            achievementsButton.Alignment = TextDrawAlignment.Left;
            achievementsButton.ForeColor = -1;
            achievementsButton.BackColor = 125;
            achievementsButton.BoxColor = -16777103;
            achievementsButton.UseBox = false;
            achievementsButton.Proportional = true;
            achievementsButton.Selectable = true;
            achievementsButton.PreviewModel = 19941;
            achievementsButton.PreviewRotation = new SampSharp.GameMode.Vector3(-81.0, 0.0, -179.0);
            achievementsButton.PreviewZoom = 1;

            woodLine = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(533.0f, 127.0f), "_");
            woodLine.Font = TextDrawFont.Normal;
            woodLine.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 0.550001f);
            woodLine.Width = 298.5f;
            woodLine.Height = 75.0f;
            woodLine.Outline = 1;
            woodLine.Shadow = 0;
            woodLine.Alignment = TextDrawAlignment.Center;
            woodLine.ForeColor = -1;
            woodLine.BackColor = 255;
            woodLine.BoxColor = 1783367679;
            woodLine.UseBox = true;
            woodLine.Proportional = true;
            woodLine.Selectable = false;



            woodInvTxd = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(476.0f, 111.0f), "Preview_Model");
            woodInvTxd.Font = TextDrawFont.PreviewModel;
            woodInvTxd.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            woodInvTxd.Width = 30.0f;
            woodInvTxd.Height = 35.0f;
            woodInvTxd.Outline = 0;
            woodInvTxd.Shadow = 0;
            woodInvTxd.Alignment = TextDrawAlignment.Left;
            woodInvTxd.ForeColor = -1;
            woodInvTxd.BackColor = 0;
            woodInvTxd.BoxColor = -16777103;
            woodInvTxd.UseBox = false;
            woodInvTxd.Proportional = true;
            woodInvTxd.Selectable = false;
            woodInvTxd.PreviewModel = 1463;
            woodInvTxd.PreviewRotation = new SampSharp.GameMode.Vector3(-12.0, 2.0, 44.0);
            woodInvTxd.PreviewZoom = 1;




            /**
RockInvTXD[playerid] = CreatePlayerTextDraw(playerid, 478.000000, 139.000000, "Preview_Model");
PlayerTextDrawFont(playerid, RockInvTXD[playerid], 5);
PlayerTextDrawLetterSize(playerid, RockInvTXD[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, RockInvTXD[playerid], 23.500000, 21.500000);
PlayerTextDrawSetOutline(playerid, RockInvTXD[playerid], 0);
PlayerTextDrawSetShadow(playerid, RockInvTXD[playerid], 0);
PlayerTextDrawAlignment(playerid, RockInvTXD[playerid], 1);
PlayerTextDrawColor(playerid, RockInvTXD[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, RockInvTXD[playerid], 0);
PlayerTextDrawBoxColor(playerid, RockInvTXD[playerid], -16777103);
PlayerTextDrawUseBox(playerid, RockInvTXD[playerid], 0);
PlayerTextDrawSetProportional(playerid, RockInvTXD[playerid], 1);
PlayerTextDrawSetSelectable(playerid, RockInvTXD[playerid], 0);
PlayerTextDrawSetPreviewModel(playerid, RockInvTXD[playerid], 3929);
PlayerTextDrawSetPreviewRot(playerid, RockInvTXD[playerid], -12.000000, 2.000000, 44.000000, 1.000000);
PlayerTextDrawSetPreviewVehCol(playerid, RockInvTXD[playerid], 1, 1);
**/
            /**
rockline[playerid] = CreatePlayerTextDraw(playerid, 533.000000, 147.000000, "_");
PlayerTextDrawFont(playerid, rockline[playerid], 1);
PlayerTextDrawLetterSize(playerid, rockline[playerid], 0.600000, 0.550001);
PlayerTextDrawTextSize(playerid, rockline[playerid], 298.500000, 75.000000);
PlayerTextDrawSetOutline(playerid, rockline[playerid], 1);
PlayerTextDrawSetShadow(playerid, rockline[playerid], 0);
PlayerTextDrawAlignment(playerid, rockline[playerid], 2);
PlayerTextDrawColor(playerid, rockline[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, rockline[playerid], 255);
PlayerTextDrawBoxColor(playerid, rockline[playerid], -741092353);
PlayerTextDrawUseBox(playerid, rockline[playerid], 1);
PlayerTextDrawSetProportional(playerid, rockline[playerid], 1);
PlayerTextDrawSetSelectable(playerid, rockline[playerid], 0);
**/
            rockLine = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(533.0f, 147.0f), "_");
            rockLine.Font = TextDrawFont.Normal;
            rockLine.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 0.550001f);
            rockLine.Width = 298.5f;
            rockLine.Height = 75.0f;
            rockLine.Outline = 1;
            rockLine.Shadow = 0;
            rockLine.Alignment = TextDrawAlignment.Center;
            rockLine.ForeColor = -1;
            rockLine.BackColor = 255;
            rockLine.BoxColor = -741092353;
            rockLine.UseBox = true;
            rockLine.Proportional = true;
            rockLine.Selectable = false;

            rockInvTxd = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(478.0f, 139.0f), "Preview_Model");
            rockInvTxd.Font = TextDrawFont.PreviewModel;
            rockInvTxd.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            rockInvTxd.Width = 23.5f;
            rockInvTxd.Height = 21.5f;
            rockInvTxd.Outline = 0;
            rockInvTxd.Shadow = 0;
            rockInvTxd.Alignment = TextDrawAlignment.Left;
            rockInvTxd.ForeColor = -1;
            rockInvTxd.BackColor = 0;
            rockInvTxd.BoxColor = -16777103;
            rockInvTxd.UseBox = false;
            rockInvTxd.Proportional = true;
            rockInvTxd.Selectable = false;
            rockInvTxd.PreviewModel = 3929;
            rockInvTxd.PreviewRotation = new SampSharp.GameMode.Vector3(-12.0, 2.0, 44.0);
            rockInvTxd.PreviewZoom = 1;

            /**
IronInvTXD[playerid] = CreatePlayerTextDraw(playerid, 475.000000, 153.000000, "Preview_Model");
PlayerTextDrawFont(playerid, IronInvTXD[playerid], 5);
PlayerTextDrawLetterSize(playerid, IronInvTXD[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, IronInvTXD[playerid], 31.500000, 32.500000);
PlayerTextDrawSetOutline(playerid, IronInvTXD[playerid], 0);
PlayerTextDrawSetShadow(playerid, IronInvTXD[playerid], 0);
PlayerTextDrawAlignment(playerid, IronInvTXD[playerid], 1);
PlayerTextDrawColor(playerid, IronInvTXD[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, IronInvTXD[playerid], 0);
PlayerTextDrawBoxColor(playerid, IronInvTXD[playerid], -16777103);
PlayerTextDrawUseBox(playerid, IronInvTXD[playerid], 0);
PlayerTextDrawSetProportional(playerid, IronInvTXD[playerid], 1);
PlayerTextDrawSetSelectable(playerid, IronInvTXD[playerid], 0);
PlayerTextDrawSetPreviewModel(playerid, IronInvTXD[playerid], 2936);
PlayerTextDrawSetPreviewRot(playerid, IronInvTXD[playerid], -12.000000, 2.000000, 44.000000, 1.000000);
PlayerTextDrawSetPreviewVehCol(playerid, IronInvTXD[playerid], 1, 1);
**/
            /**
ironline[playerid] = CreatePlayerTextDraw(playerid, 533.000000, 168.000000, "_");
PlayerTextDrawFont(playerid, ironline[playerid], 1);
PlayerTextDrawLetterSize(playerid, ironline[playerid], 0.600000, 0.550001);
PlayerTextDrawTextSize(playerid, ironline[playerid], 298.500000, 75.000000);
PlayerTextDrawSetOutline(playerid, ironline[playerid], 1);
PlayerTextDrawSetShadow(playerid, ironline[playerid], 0);
PlayerTextDrawAlignment(playerid, ironline[playerid], 2);
PlayerTextDrawColor(playerid, ironline[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, ironline[playerid], 255);
PlayerTextDrawBoxColor(playerid, ironline[playerid], -764862721);
PlayerTextDrawUseBox(playerid, ironline[playerid], 1);
PlayerTextDrawSetProportional(playerid, ironline[playerid], 1);
PlayerTextDrawSetSelectable(playerid, ironline[playerid], 0);
**/
            ironLine = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(533.0f, 168.0f), "_");
            ironLine.Font = TextDrawFont.Normal;
            ironLine.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 0.550001f);
            ironLine.Width = 298.5f;
            ironLine.Height = 75.0f;
            ironLine.Outline = 1;
            ironLine.Shadow = 0;
            ironLine.Alignment = TextDrawAlignment.Center;
            ironLine.ForeColor = -1;
            ironLine.BackColor = 255;
            ironLine.BoxColor = -764862721;
            ironLine.UseBox = true;
            ironLine.Proportional = true;
            ironLine.Selectable = false;
            ironInvTxd = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(475.0f, 153.0f), "Preview_Model");
            ironInvTxd.Font = TextDrawFont.PreviewModel;
            ironInvTxd.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            ironInvTxd.Width = 31.5f;
            ironInvTxd.Height = 32.5f;
            ironInvTxd.Outline = 0;
            ironInvTxd.Shadow = 0;
            ironInvTxd.Alignment = TextDrawAlignment.Left;
            ironInvTxd.ForeColor = -1;
            ironInvTxd.BackColor = 0;
            ironInvTxd.BoxColor = -16777103;
            ironInvTxd.UseBox = false;
            ironInvTxd.Proportional = true;
            ironInvTxd.Selectable = false;
            ironInvTxd.PreviewModel = 2936;
            ironInvTxd.PreviewRotation = new SampSharp.GameMode.Vector3(-12.0, 2.0, 44.0);
            ironInvTxd.PreviewZoom = 1;

            /**
tcanline[playerid] = CreatePlayerTextDraw(playerid, 533.000000, 188.000000, "_");
PlayerTextDrawFont(playerid, tcanline[playerid], 1);
PlayerTextDrawLetterSize(playerid, tcanline[playerid], 0.600000, 0.550001);
PlayerTextDrawTextSize(playerid, tcanline[playerid], 298.500000, 75.000000);
PlayerTextDrawSetOutline(playerid, tcanline[playerid], 1);
PlayerTextDrawSetShadow(playerid, tcanline[playerid], 0);
PlayerTextDrawAlignment(playerid, tcanline[playerid], 2);
PlayerTextDrawColor(playerid, tcanline[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, tcanline[playerid], -2016478465);
PlayerTextDrawBoxColor(playerid, tcanline[playerid], 1687547391);
PlayerTextDrawUseBox(playerid, tcanline[playerid], 1);
PlayerTextDrawSetProportional(playerid, tcanline[playerid], 1);
PlayerTextDrawSetSelectable(playerid, tcanline[playerid], 0);
**/
            tcanLine = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(533.0f, 188.0f), "_");
            tcanLine.Font = TextDrawFont.Normal;
            tcanLine.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 0.550001f);
            tcanLine.Width = 298.5f;
            tcanLine.Height = 75.0f;
            tcanLine.Outline = 1;
            tcanLine.Shadow = 0;
            tcanLine.Alignment = TextDrawAlignment.Center;
            tcanLine.ForeColor = -1;
            tcanLine.BackColor = -2016478465;
            tcanLine.BoxColor = 1687547391;
            tcanLine.UseBox = true;
            tcanLine.Proportional = true;
            tcanLine.Selectable = false;

            /**
tkaninvtxd[playerid] = CreatePlayerTextDraw(playerid, 473.000000, 173.000000, "Preview_Model");
PlayerTextDrawFont(playerid, tkaninvtxd[playerid], 5);
PlayerTextDrawLetterSize(playerid, tkaninvtxd[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, tkaninvtxd[playerid], 36.500000, 31.500000);
PlayerTextDrawSetOutline(playerid, tkaninvtxd[playerid], 0);
PlayerTextDrawSetShadow(playerid, tkaninvtxd[playerid], 0);
PlayerTextDrawAlignment(playerid, tkaninvtxd[playerid], 1);
PlayerTextDrawColor(playerid, tkaninvtxd[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, tkaninvtxd[playerid], 0);
PlayerTextDrawBoxColor(playerid, tkaninvtxd[playerid], -16777103);
PlayerTextDrawUseBox(playerid, tkaninvtxd[playerid], 0);
PlayerTextDrawSetProportional(playerid, tkaninvtxd[playerid], 1);
PlayerTextDrawSetSelectable(playerid, tkaninvtxd[playerid], 0);
PlayerTextDrawSetPreviewModel(playerid, tkaninvtxd[playerid], 19518);
PlayerTextDrawSetPreviewRot(playerid, tkaninvtxd[playerid], 79.000000, 2.000000, 17.000000, 1.000000);
PlayerTextDrawSetPreviewVehCol(playerid, tkaninvtxd[playerid], 1, 1);
**/
            tkanInvTxd = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(473.0f, 173.0f), "Preview_Model");
            tkanInvTxd.Font = TextDrawFont.PreviewModel;
            tkanInvTxd.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            tkanInvTxd.Width = 36.5f;
            tkanInvTxd.Height = 31.5f;
            tkanInvTxd.Outline = 0;
            tkanInvTxd.Shadow = 0;
            tkanInvTxd.Alignment = TextDrawAlignment.Left;
            tkanInvTxd.ForeColor = -1;
            tkanInvTxd.BackColor = 0;
            tkanInvTxd.BoxColor = -16777103;
            tkanInvTxd.UseBox = false;
            tkanInvTxd.Proportional = true;
            tkanInvTxd.Selectable = false;
            tkanInvTxd.PreviewModel = 19518;
            tkanInvTxd.PreviewRotation = new SampSharp.GameMode.Vector3(79.0, 2.0, 17.0);
            tkanInvTxd.PreviewZoom = 1;

            /**
weapon1[playerid] = CreatePlayerTextDraw(playerid, 375.000000, 210.000000, "Preview_Model");
PlayerTextDrawFont(playerid, weapon1[playerid], 5);
PlayerTextDrawLetterSize(playerid, weapon1[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, weapon1[playerid], 27.500000, 18.500000);
PlayerTextDrawSetOutline(playerid, weapon1[playerid], 0);
PlayerTextDrawSetShadow(playerid, weapon1[playerid], 0);
PlayerTextDrawAlignment(playerid, weapon1[playerid], 1);
PlayerTextDrawColor(playerid, weapon1[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, weapon1[playerid], -1094795651);
PlayerTextDrawBoxColor(playerid, weapon1[playerid], -16777103);
PlayerTextDrawUseBox(playerid, weapon1[playerid], 0);
PlayerTextDrawSetProportional(playerid, weapon1[playerid], 1);
PlayerTextDrawSetSelectable(playerid, weapon1[playerid], 1);
PlayerTextDrawSetPreviewModel(playerid, weapon1[playerid], 348);
PlayerTextDrawSetPreviewRot(playerid, weapon1[playerid], 3.000000, 0.000000, -131.000000, 1.000000);
PlayerTextDrawSetPreviewVehCol(playerid, weapon1[playerid], 1, 1);
**/
            weaponslots[0] = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(375.0f, 210.0f), "Preview_Model");
            weaponslots[0].Font = TextDrawFont.PreviewModel;
            weaponslots[0].LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            weaponslots[0].Width = 27.5f;
            weaponslots[0].Height = 18.5f;
            weaponslots[0].Outline = 0;
            weaponslots[0].Shadow = 0;
            weaponslots[0].Alignment = TextDrawAlignment.Left;
            weaponslots[0].ForeColor = -1;
            weaponslots[0].BackColor = -1094795651;
            weaponslots[0].BoxColor = -16777103;
            weaponslots[0].UseBox = false;
            weaponslots[0].Proportional = true;
            weaponslots[0].Selectable = true;
            weaponslots[0].PreviewModel = 348;
            weaponslots[0].PreviewRotation = new SampSharp.GameMode.Vector3(3.0, 0.0, -131.0);
            weaponslots[0].PreviewZoom = 1;

            /**
weapon2[playerid] = CreatePlayerTextDraw(playerid, 407.000000, 210.000000, "Preview_Model");
PlayerTextDrawFont(playerid, weapon2[playerid], 5);
PlayerTextDrawLetterSize(playerid, weapon2[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, weapon2[playerid], 27.500000, 18.500000);
PlayerTextDrawSetOutline(playerid, weapon2[playerid], 0);
PlayerTextDrawSetShadow(playerid, weapon2[playerid], 0);
PlayerTextDrawAlignment(playerid, weapon2[playerid], 1);
PlayerTextDrawColor(playerid, weapon2[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, weapon2[playerid], -1094795651);
PlayerTextDrawBoxColor(playerid, weapon2[playerid], -16777103);
PlayerTextDrawUseBox(playerid, weapon2[playerid], 0);
PlayerTextDrawSetProportional(playerid, weapon2[playerid], 1);
PlayerTextDrawSetSelectable(playerid, weapon2[playerid], 1);
PlayerTextDrawSetPreviewModel(playerid, weapon2[playerid], 351);
PlayerTextDrawSetPreviewRot(playerid, weapon2[playerid], 3.000000, 0.000000, -131.000000, 1.000000);
PlayerTextDrawSetPreviewVehCol(playerid, weapon2[playerid], 1, 1);
**/
            weaponslots[1] = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(407.0f, 210.0f), "Preview_Model");
            weaponslots[1].Font = TextDrawFont.PreviewModel;
            weaponslots[1].LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            weaponslots[1].Width = 27.5f;
            weaponslots[1].Height = 18.5f;
            weaponslots[1].Outline = 0;
            weaponslots[1].Shadow = 0;
            weaponslots[1].Alignment = TextDrawAlignment.Left;
            weaponslots[1].ForeColor = -1;
            weaponslots[1].BackColor = -1094795651;
            weaponslots[1].BoxColor = -16777103;
            weaponslots[1].UseBox = false;
            weaponslots[1].Proportional = true;
            weaponslots[1].Selectable = true;
            weaponslots[1].PreviewModel = 351;
            weaponslots[1].PreviewRotation = new SampSharp.GameMode.Vector3(3.0, 0.0, -131.0);
            weaponslots[1].PreviewZoom = 1;

            /**
weapon3[playerid] = CreatePlayerTextDraw(playerid, 439.000000, 210.000000, "Preview_Model");
PlayerTextDrawFont(playerid, weapon3[playerid], 5);
PlayerTextDrawLetterSize(playerid, weapon3[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, weapon3[playerid], 27.500000, 18.500000);
PlayerTextDrawSetOutline(playerid, weapon3[playerid], 0);
PlayerTextDrawSetShadow(playerid, weapon3[playerid], 0);
PlayerTextDrawAlignment(playerid, weapon3[playerid], 1);
PlayerTextDrawColor(playerid, weapon3[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, weapon3[playerid], -1094795651);
PlayerTextDrawBoxColor(playerid, weapon3[playerid], -16777103);
PlayerTextDrawUseBox(playerid, weapon3[playerid], 0);
PlayerTextDrawSetProportional(playerid, weapon3[playerid], 1);
PlayerTextDrawSetSelectable(playerid, weapon3[playerid], 1);
PlayerTextDrawSetPreviewModel(playerid, weapon3[playerid], 353);
PlayerTextDrawSetPreviewRot(playerid, weapon3[playerid], 3.000000, 0.000000, -131.000000, 1.000000);
PlayerTextDrawSetPreviewVehCol(playerid, weapon3[playerid], 1, 1);

**/
            weaponslots[2] = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(439.0f, 210.0f), "Preview_Model");
            weaponslots[2].Font = TextDrawFont.PreviewModel;
            weaponslots[2].LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            weaponslots[2].Width = 27.5f;
            weaponslots[2].Height = 18.5f;
            weaponslots[2].Outline = 0;
            weaponslots[2].Shadow = 0;
            weaponslots[2].Alignment = TextDrawAlignment.Left;
            weaponslots[2].ForeColor = -1;
            weaponslots[2].BackColor = -1094795651;
            weaponslots[2].BoxColor = -16777103;
            weaponslots[2].UseBox = false;
            weaponslots[2].Proportional = true;
            weaponslots[2].Selectable = true;
            weaponslots[2].PreviewModel = 353;
            weaponslots[2].PreviewRotation = new SampSharp.GameMode.Vector3(3.0, 0.0, -131.0);
            weaponslots[2].PreviewZoom = 1;

            /**
weapon4[playerid] = CreatePlayerTextDraw(playerid, 375.000000, 232.000000, "Preview_Model");
PlayerTextDrawFont(playerid, weapon4[playerid], 5);
PlayerTextDrawLetterSize(playerid, weapon4[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, weapon4[playerid], 27.500000, 18.500000);
PlayerTextDrawSetOutline(playerid, weapon4[playerid], 0);
PlayerTextDrawSetShadow(playerid, weapon4[playerid], 0);
PlayerTextDrawAlignment(playerid, weapon4[playerid], 1);
PlayerTextDrawColor(playerid, weapon4[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, weapon4[playerid], -1094795651);
PlayerTextDrawBoxColor(playerid, weapon4[playerid], -16777103);
PlayerTextDrawUseBox(playerid, weapon4[playerid], 0);
PlayerTextDrawSetProportional(playerid, weapon4[playerid], 1);
PlayerTextDrawSetSelectable(playerid, weapon4[playerid], 1);
PlayerTextDrawSetPreviewModel(playerid, weapon4[playerid], 366);
PlayerTextDrawSetPreviewRot(playerid, weapon4[playerid], 3.000000, 0.000000, -131.000000, 1.000000);
PlayerTextDrawSetPreviewVehCol(playerid, weapon4[playerid], 1, 1);
**/
            weaponslots[3] = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(375.0f, 232.0f), "Preview_Model");
            weaponslots[3].Font = TextDrawFont.PreviewModel;
            weaponslots[3].LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            weaponslots[3].Width = 27.5f;
            weaponslots[3].Height = 18.5f;
            weaponslots[3].Outline = 0;
            weaponslots[3].Shadow = 0;
            weaponslots[3].Alignment = TextDrawAlignment.Left;
            weaponslots[3].ForeColor = -1;
            weaponslots[3].BackColor = -1094795651;
            weaponslots[3].BoxColor = -16777103;
            weaponslots[3].UseBox = false;
            weaponslots[3].Proportional = true;
            weaponslots[3].Selectable = true;
            weaponslots[3].PreviewModel = 366;
            weaponslots[3].PreviewRotation = new SampSharp.GameMode.Vector3(3.0, 0.0, -131.0);
            weaponslots[3].PreviewZoom = 1;

            /**
weapon5[playerid] = CreatePlayerTextDraw(playerid, 407.000000, 232.000000, "Preview_Model");
PlayerTextDrawFont(playerid, weapon5[playerid], 5);
PlayerTextDrawLetterSize(playerid, weapon5[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, weapon5[playerid], 27.500000, 18.500000);
PlayerTextDrawSetOutline(playerid, weapon5[playerid], 0);
PlayerTextDrawSetShadow(playerid, weapon5[playerid], 0);
PlayerTextDrawAlignment(playerid, weapon5[playerid], 1);
PlayerTextDrawColor(playerid, weapon5[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, weapon5[playerid], -1094795651);
PlayerTextDrawBoxColor(playerid, weapon5[playerid], -16777103);
PlayerTextDrawUseBox(playerid, weapon5[playerid], 0);
PlayerTextDrawSetProportional(playerid, weapon5[playerid], 1);
PlayerTextDrawSetSelectable(playerid, weapon5[playerid], 1);
PlayerTextDrawSetPreviewModel(playerid, weapon5[playerid], 356);
PlayerTextDrawSetPreviewRot(playerid, weapon5[playerid], 3.000000, 0.000000, -131.000000, 1.000000);
PlayerTextDrawSetPreviewVehCol(playerid, weapon5[playerid], 1, 1);
**/
            weaponslots[4] = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(407.0f, 232.0f), "Preview_Model");
            weaponslots[4].Font = TextDrawFont.PreviewModel;
            weaponslots[4].LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            weaponslots[4].Width = 27.5f;
            weaponslots[4].Height = 18.5f;
            weaponslots[4].Outline = 0;
            weaponslots[4].Shadow = 0;
            weaponslots[4].Alignment = TextDrawAlignment.Left;
            weaponslots[4].ForeColor = -1;
            weaponslots[4].BackColor = -1094795651;
            weaponslots[4].BoxColor = -16777103;
            weaponslots[4].UseBox = false;
            weaponslots[4].Proportional = true;
            weaponslots[4].Selectable = true;
            weaponslots[4].PreviewModel = 356;
            weaponslots[4].PreviewRotation = new SampSharp.GameMode.Vector3(3.0, 0.0, -131.0);
            weaponslots[4].PreviewZoom = 1;


            /**
weapon6[playerid] = CreatePlayerTextDraw(playerid, 439.000000, 232.000000, "Preview_Model");
PlayerTextDrawFont(playerid, weapon6[playerid], 5);
PlayerTextDrawLetterSize(playerid, weapon6[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, weapon6[playerid], 27.500000, 18.500000);
PlayerTextDrawSetOutline(playerid, weapon6[playerid], 0);
PlayerTextDrawSetShadow(playerid, weapon6[playerid], 0);
PlayerTextDrawAlignment(playerid, weapon6[playerid], 1);
PlayerTextDrawColor(playerid, weapon6[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, weapon6[playerid], -1094795651);
PlayerTextDrawBoxColor(playerid, weapon6[playerid], -16777103);
PlayerTextDrawUseBox(playerid, weapon6[playerid], 0);
PlayerTextDrawSetProportional(playerid, weapon6[playerid], 1);
PlayerTextDrawSetSelectable(playerid, weapon6[playerid], 1);
PlayerTextDrawSetPreviewModel(playerid, weapon6[playerid], 349);
PlayerTextDrawSetPreviewRot(playerid, weapon6[playerid], 3.000000, 0.000000, -131.000000, 1.000000);
PlayerTextDrawSetPreviewVehCol(playerid, weapon6[playerid], 1, 1);
**/
            weaponslots[5] = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(439.0f, 232.0f), "Preview_Model");
            weaponslots[5].Font = TextDrawFont.PreviewModel;
            weaponslots[5].LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            weaponslots[5].Width = 27.5f;
            weaponslots[5].Height = 18.5f;
            weaponslots[5].Outline = 0;
            weaponslots[5].Shadow = 0;
            weaponslots[5].Alignment = TextDrawAlignment.Left;
            weaponslots[5].ForeColor = -1;
            weaponslots[5].BackColor = -1094795651;
            weaponslots[5].BoxColor = -16777103;
            weaponslots[5].UseBox = false;
            weaponslots[5].Proportional = true;
            weaponslots[5].Selectable = true;
            weaponslots[5].PreviewModel = 349;
            weaponslots[5].PreviewRotation = new SampSharp.GameMode.Vector3(3.0, 0.0, -131.0);
            weaponslots[5].PreviewZoom = 1;

            /**
use = TextDrawCreate(505.000000, 233.500000, "Use");
TextDrawFont(use, 2);
TextDrawLetterSize(use, 0.358332, 1.700000);
TextDrawTextSize(use, 11.500000, 38.000000);
TextDrawSetOutline(use, 1);
TextDrawSetShadow(use, 0);
TextDrawAlignment(use, 2);
TextDrawColor(use, -1);
TextDrawBackgroundColor(use, 255);
TextDrawBoxColor(use, -764862776);
TextDrawUseBox(use, 1);
TextDrawSetProportional(use, 1);
TextDrawSetSelectable(use, 1);
**/
            useButton = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(505.0f, 233.5f), "Use");
            useButton.Font = TextDrawFont.Slim;
            useButton.LetterSize = new SampSharp.GameMode.Vector2(0.358332f, 1.7f);
            useButton.Width = 11.5f;
            useButton.Height = 38.0f;
            useButton.Outline = 1;
            useButton.Shadow = 0;
            useButton.Alignment = TextDrawAlignment.Center;
            useButton.ForeColor = -1;
            useButton.BackColor = 255;
            useButton.BoxColor = -764862776;
            useButton.UseBox = true;
            useButton.Proportional = true;
            useButton.Selectable = true;

            dropButton = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(552.0f, 233.5f), "drop");
            dropButton.Font = TextDrawFont.Slim;
            dropButton.LetterSize = new SampSharp.GameMode.Vector2(0.358332f, 1.7f);
            dropButton.Width = 11.5f;
            dropButton.Height = 38.0f;
            dropButton.Outline = 1;
            dropButton.Shadow = 0;
            dropButton.Alignment = TextDrawAlignment.Center;
            dropButton.ForeColor = -1;
            dropButton.BackColor = 255;
            dropButton.BoxColor = -764862776;
            dropButton.UseBox = true;
            dropButton.Proportional = true;
            dropButton.Selectable = true;

            sellButton = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(552.0f, 209.5f), "give");
            sellButton.Font = TextDrawFont.Slim;
            sellButton.LetterSize = new SampSharp.GameMode.Vector2(0.358332f, 1.7f);
            sellButton.Width = 11.5f;
            sellButton.Height = 38.0f;
            sellButton.Outline = 1;
            sellButton.Shadow = 0;
            sellButton.Alignment = TextDrawAlignment.Center;
            sellButton.ForeColor = -1;
            sellButton.BackColor = 255;
            sellButton.BoxColor = -764862776;
            sellButton.UseBox = true;
            sellButton.Proportional = true;
            sellButton.Selectable = true;

            infoButton = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(505.0f, 209.5f), "info");
            infoButton.Font = TextDrawFont.Slim;
            infoButton.LetterSize = new SampSharp.GameMode.Vector2(0.358332f, 1.7f);
            infoButton.Width = 11.5f;
            infoButton.Height = 38.0f;
            infoButton.Outline = 1;
            infoButton.Shadow = 0;
            infoButton.Alignment = TextDrawAlignment.Center;
            infoButton.ForeColor = -1;
            infoButton.BackColor = 255;
            infoButton.BoxColor = -764862776;
            infoButton.UseBox = true;
            infoButton.Proportional = true;
            infoButton.Selectable = true;
            /**
        exitbutton[playerid] = CreatePlayerTextDraw(playerid, 568.000000, 110.000000, "ld_beat:cross");
        PlayerTextDrawFont(playerid, exitbutton[playerid], 4);
        PlayerTextDrawLetterSize(playerid, exitbutton[playerid], 0.600000, 2.000000);
        PlayerTextDrawTextSize(playerid, exitbutton[playerid], 12.500000, 12.500000);
        PlayerTextDrawSetOutline(playerid, exitbutton[playerid], 1);
        PlayerTextDrawSetShadow(playerid, exitbutton[playerid], 0);
        PlayerTextDrawAlignment(playerid, exitbutton[playerid], 1);
        PlayerTextDrawColor(playerid, exitbutton[playerid], -1);
        PlayerTextDrawBackgroundColor(playerid, exitbutton[playerid], 255);
        PlayerTextDrawBoxColor(playerid, exitbutton[playerid], 50);
        PlayerTextDrawUseBox(playerid, exitbutton[playerid], 1);
        PlayerTextDrawSetProportional(playerid, exitbutton[playerid], 1);
        PlayerTextDrawSetSelectable(playerid, exitbutton[playerid], 1);
        **/
            closeinv = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(568.0f, 110.0f), "ld_beat:cross");
            closeinv.Font = TextDrawFont.DrawSprite;
            closeinv.LetterSize = new SampSharp.GameMode.Vector2(0.6, 2.0);
            closeinv.Width = 12.5f;
            closeinv.Height = 12.5f;
            closeinv.Outline = 1;
            closeinv.Shadow = 0;
            closeinv.Alignment = TextDrawAlignment.Left;
            closeinv.ForeColor = -1;
            closeinv.BackColor = 255;
            closeinv.BoxColor = 50;
            closeinv.UseBox = true;
            closeinv.Proportional = true;
            closeinv.Selectable = true;

            slots[0].Create(p,375.0f,257.0f);

            slots[1].Create(p,404.0f, 257.0f);
            slots[2].Create(p,433.0f,257.0f);

            slots[3].Create(p,462.0f, 257.0f);

            slots[4].Create(p,491.0f,257.0f);


            slots[5].Create(p,520.0f,257.0f);
            

            slots[6].Create(p,548.0f,257.0f);


            slots[7].Create(p,375.0f, 287.0f);
            
            slots[8].Create(p,404.0f, 287.0f);
            

            slots[9].Create(p,433.0f, 287.0f);
            
            slots[10].Create(p,462.0f, 287.0f);
            
            slots[11].Create(p,491.0f, 287.0f);
            
            slots[12].Create(p,520.0f, 287.0f);
            
            slots[13].Create(p,548.0f, 287.0f);
            
            slots[14].Create(p,375.0f, 317.0f);
            
            slots[15].Create(p,404.0f, 317.0f);
            
            slots[16].Create(p,433.0f, 317.0f);
            
            slots[17].Create(p,462.0f, 317.0f);
            
            slots[18].Create(p,491.0f, 317.0f);
            
            slots[19].Create(p,520.0f, 317.0f);
            

            slots[20].Create(p,548.0f, 317.0f);
            
            slots[21].Create(p,375.0f, 348.0f);
            

            slots[22].Create(p,404.0f, 348.0f);
            
            slots[23].Create(p,433.0f, 348.0f);
            
            slots[24].Create(p,462.0f, 348.0f);
            
            slots[25].Create(p,491.0f, 348.0f);
            
            slots[26].Create(p,520.0f, 348.0f);
            
            slots[27].Create(p,548.0f, 348.0f);
            
            slots[28].Create(p,375.0f, 379.0f);
            
            slots[29].Create(p,404.0f, 379.0f);
            
            slots[30].Create(p,433.0f, 379.0f);

            slots[31].Create(p,462.0f, 379.0f);
            slots[32].Create(p,491.0f, 379.0f);
            
            slots[33].Create(p,520.0f, 379.0f);
            
            slots[34].Create(p,548.0f, 379.0f);
            
            slots[35].Create(p,375.0f, 410.0f);
           
            slots[36].Create(p,404.0f, 410.0f);
            
            slots[37].Create(p,433.0f, 410.0f);
            
            slots[38].Create(p,462.0f, 410.0f);
          
            slots[39].Create(p,491.0f, 410.0f);
          
            slots[40].Create(p,520.0f, 410.0f);
           
            slots[41].Create(p,548.0f, 410.0f);
           
              
             
            ironnum = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(530.0f, 164.0f), "3");
            ironnum.Font = TextDrawFont.Slim;
            ironnum.LetterSize = new SampSharp.GameMode.Vector2(0.287499, 1.149999);
            ironnum.Width = 400.0f;
            ironnum.Height = 17.0f;
            ironnum.Outline = 1;
            ironnum.Shadow = 0;
            ironnum.Alignment = TextDrawAlignment.Left;
            ironnum.ForeColor = -1;
            ironnum.BackColor = 255;
            ironnum.BoxColor = 50;
            ironnum.UseBox = false;
            ironnum.Proportional = true;
            ironnum.Selectable = false;

            /**
             * woodnum[playerid] = CreatePlayerTextDraw(playerid, 530.000000, 123.000000, "35000");
PlayerTextDrawFont(playerid, woodnum[playerid], 2);
PlayerTextDrawLetterSize(playerid, woodnum[playerid], 0.287499, 1.149999);
PlayerTextDrawTextSize(playerid, woodnum[playerid], 400.000000, 17.000000);
PlayerTextDrawSetOutline(playerid, woodnum[playerid], 1);
PlayerTextDrawSetShadow(playerid, woodnum[playerid], 0);
PlayerTextDrawAlignment(playerid, woodnum[playerid], 1);
PlayerTextDrawColor(playerid, woodnum[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, woodnum[playerid], 255);
PlayerTextDrawBoxColor(playerid, woodnum[playerid], 50);
PlayerTextDrawUseBox(playerid, woodnum[playerid], 0);
PlayerTextDrawSetProportional(playerid, woodnum[playerid], 1);
PlayerTextDrawSetSelectable(playerid, woodnum[playerid], 1);
             **/

            woodnum = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(530.0f, 123.0f), "1");
            woodnum.Font = TextDrawFont.Slim;
            woodnum.LetterSize = new SampSharp.GameMode.Vector2(0.287499, 1.149999);
            woodnum.Width = 400.0f;
            woodnum.Height = 17.0f;
            woodnum.Outline = 1;
            woodnum.Shadow = 0;
            woodnum.Alignment = TextDrawAlignment.Left;
            woodnum.ForeColor = -1;
            woodnum.BackColor = 255;
            woodnum.BoxColor = 50;
            woodnum.UseBox = false;
            woodnum.Proportional = true;
            woodnum.Selectable = false;



            tkannum = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(530.0f, 184.0f), "4");
            tkannum.Font = TextDrawFont.Slim;
            tkannum.LetterSize = new SampSharp.GameMode.Vector2(0.287499, 1.149999);
            tkannum.Width = 400.0f;
            tkannum.Height = 17.0f;
            tkannum.Outline = 1;
            tkannum.Shadow = 0;
            tkannum.Alignment = TextDrawAlignment.Left;
            tkannum.ForeColor = -1;
            tkannum.BackColor = 255;
            tkannum.BoxColor = 50;
            tkannum.UseBox = false;
            tkannum.Proportional = true;
            tkannum.Selectable = false;

            rocknum = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(530.0f, 143.0f), "2");
            rocknum.Font = TextDrawFont.Slim;
            rocknum.LetterSize = new SampSharp.GameMode.Vector2(0.287499, 1.149999);
            rocknum.Width = 400.0f;
            rocknum.Height = 17.0f;
            rocknum.Outline = 1;
            rocknum.Shadow = 0;
            rocknum.Alignment = TextDrawAlignment.Left;
            rocknum.ForeColor = -1;
            rocknum.BackColor = 255;
            rocknum.BoxColor = 50;
            rocknum.UseBox = false;
            rocknum.Proportional = true;
            rocknum.Selectable = false;

            weaponslotsAmmo[0] = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(376.0f, 220.0f), "0");
            weaponslotsAmmo[0].Font = TextDrawFont.Slim;
            weaponslotsAmmo[0].LetterSize = new SampSharp.GameMode.Vector2(0.212500, 0.899999);
            weaponslotsAmmo[0].Width = 400.0f;
            weaponslotsAmmo[0].Height = 17.0f;
            weaponslotsAmmo[0].Outline = 1;
            weaponslotsAmmo[0].Shadow = 0;
            weaponslotsAmmo[0].Alignment = TextDrawAlignment.Left;
            weaponslotsAmmo[0].ForeColor = -1;
            weaponslotsAmmo[0].BackColor = 255;
            weaponslotsAmmo[0].BoxColor = 50;
            weaponslotsAmmo[0].UseBox = false;
            weaponslotsAmmo[0].Proportional = true;
            weaponslotsAmmo[0].Selectable = false;

            weaponslotsAmmo[1] = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(408.0f, 220.0f), "0");
            weaponslotsAmmo[1].Font = TextDrawFont.Slim;
            weaponslotsAmmo[1].LetterSize = new SampSharp.GameMode.Vector2(0.212500, 0.899999);
            weaponslotsAmmo[1].Width = 400.0f;
            weaponslotsAmmo[1].Height = 17.0f;
            weaponslotsAmmo[1].Outline = 1;
            weaponslotsAmmo[1].Shadow = 0;
            weaponslotsAmmo[1].Alignment = TextDrawAlignment.Left;
            weaponslotsAmmo[1].ForeColor = -1;
            weaponslotsAmmo[1].BackColor = 255;
            weaponslotsAmmo[1].BoxColor = 50;
            weaponslotsAmmo[1].UseBox = false;
            weaponslotsAmmo[1].Proportional = true;
            weaponslotsAmmo[1].Selectable = false;

            weaponslotsAmmo[2] = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(440.0f, 220.0f), "0");
            weaponslotsAmmo[2].Font = TextDrawFont.Slim;
            weaponslotsAmmo[2].LetterSize = new SampSharp.GameMode.Vector2(0.212500, 0.899999);
            weaponslotsAmmo[2].Width = 400.0f;
            weaponslotsAmmo[2].Height = 17.0f;
            weaponslotsAmmo[2].Outline = 1;
            weaponslotsAmmo[2].Shadow = 0;
            weaponslotsAmmo[2].Alignment = TextDrawAlignment.Left;
            weaponslotsAmmo[2].ForeColor = -1;
            weaponslotsAmmo[2].BackColor = 255;
            weaponslotsAmmo[2].BoxColor = 50;
            weaponslotsAmmo[2].UseBox = false;
            weaponslotsAmmo[2].Proportional = true;
            weaponslotsAmmo[2].Selectable = false;

            weaponslotsAmmo[3] = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(376.0f, 242.0f), "0");
            weaponslotsAmmo[3].Font = TextDrawFont.Slim;
            weaponslotsAmmo[3].LetterSize = new SampSharp.GameMode.Vector2(0.212500, 0.899999);
            weaponslotsAmmo[3].Width = 400.0f;
            weaponslotsAmmo[3].Height = 17.0f;
            weaponslotsAmmo[3].Outline = 1;
            weaponslotsAmmo[3].Shadow = 0;
            weaponslotsAmmo[3].Alignment = TextDrawAlignment.Left;
            weaponslotsAmmo[3].ForeColor = -1;
            weaponslotsAmmo[3].BackColor = 255;
            weaponslotsAmmo[3].BoxColor = 50;
            weaponslotsAmmo[3].UseBox = false;
            weaponslotsAmmo[3].Proportional = true;
            weaponslotsAmmo[3].Selectable = false;

            weaponslotsAmmo[4] = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(408.0f, 242.0f), "0");
            weaponslotsAmmo[4].Font = TextDrawFont.Slim;
            weaponslotsAmmo[4].LetterSize = new SampSharp.GameMode.Vector2(0.212500, 0.899999);
            weaponslotsAmmo[4].Width = 400.0f;
            weaponslotsAmmo[4].Height = 17.0f;
            weaponslotsAmmo[4].Outline = 1;
            weaponslotsAmmo[4].Shadow = 0;
            weaponslotsAmmo[4].Alignment = TextDrawAlignment.Left;
            weaponslotsAmmo[4].ForeColor = -1;
            weaponslotsAmmo[4].BackColor = 255;
            weaponslotsAmmo[4].BoxColor = 50;
            weaponslotsAmmo[4].UseBox = false;
            weaponslotsAmmo[4].Proportional = true;
            weaponslotsAmmo[4].Selectable = false;

            weaponslotsAmmo[5] = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(440.0f, 242.0f), "0");
            weaponslotsAmmo[5].Font = TextDrawFont.Slim;
            weaponslotsAmmo[5].LetterSize = new SampSharp.GameMode.Vector2(0.212500, 0.899999);
            weaponslotsAmmo[5].Width = 400.0f;
            weaponslotsAmmo[5].Height = 17.0f;
            weaponslotsAmmo[5].Outline = 1;
            weaponslotsAmmo[5].Shadow = 0;
            weaponslotsAmmo[5].Alignment = TextDrawAlignment.Left;
            weaponslotsAmmo[5].ForeColor = -1;
            weaponslotsAmmo[5].BackColor = 255;
            weaponslotsAmmo[5].BoxColor = 50;
            weaponslotsAmmo[5].UseBox = false;
            weaponslotsAmmo[5].Proportional = true;
            weaponslotsAmmo[5].Selectable = false;
        }
        public void Show()
        {
            p.SelectTextDraw(SampSharp.GameMode.SAMP.Color.Yellow);
            Update();
            inventoryBackPlate.Show();
            playerButton.PreviewModel = p.Skin;
            playerButton.Show();
            helmetbutton.Show();
            backpackButton.Show();

            armourButton.Show();
            pagerButton.Show();
            achievementsButton.Show();
            woodLine.Show();
            woodInvTxd.Show();
            rockLine.Show();
            rockInvTxd.Show();
            ironLine.Show();
            ironInvTxd.Show();
            tcanLine.Show();
            tkanInvTxd.Show();
            weaponslots[0].Show();
            weaponslots[1].Show();
            weaponslots[2].Show();
            weaponslots[3].Show();
            weaponslots[4].Show();
            weaponslots[5].Show();
            useButton.Show();
            dropButton.Show();
            sellButton.Show();
            infoButton.Show();
            closeinv.Show();
            
            woodnum.Show();
            rocknum.Show();
            ironnum.Show();
            tkannum.Show();
            foreach(Slot s in slots)
            {
                s.Show();
            }
        }
        public void Close()
        {
            inventoryBackPlate.Hide();
            
            playerButton.Hide();
            helmetbutton.Hide();
            backpackButton.Hide();

            armourButton.Hide();
            pagerButton.Hide();
            achievementsButton.Hide();
            woodLine.Hide();
            woodInvTxd.Hide();
            rockLine.Hide();
            rockInvTxd.Hide();
            ironLine.Hide();
            ironInvTxd.Hide();
            tcanLine.Hide();
            tkanInvTxd.Hide();
            weaponslots[0].Hide();
            weaponslots[1].Hide();
            weaponslots[2].Hide();
            weaponslots[3].Hide();
            weaponslots[4].Hide();
            weaponslots[5].Hide();
            useButton.Hide();
            dropButton.Hide();
            sellButton.Hide();
            infoButton.Hide();
            closeinv.Hide();

            woodnum.Hide();
            rocknum.Hide();
            ironnum.Hide();
            tkannum.Hide();
            foreach (Slot s in slots)
            {
                s.Hide();
            }
        }
        public void Update()
        {

        }
        

    }
    public class Slot {
        public PlayerTextDraw Td;
        public int ItemId = 0;
        public bool IsPressed = false;
        
        public Slot()
        {
            
        }
        
        public void Create(Player p,float posx, float posy)
        {
            Td = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(posx, posy), "Preview_Model");
            Td.Font = TextDrawFont.PreviewModel;
            Td.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            Td.Width = 24.0f;
            Td.Height = 26.5f;
            Td.Outline = 0;
            Td.Shadow = 0;
            Td.Alignment = TextDrawAlignment.Left;
            Td.ForeColor = -1;
            Td.BackColor = -1094795651;
            Td.BoxColor = -16777103;
            Td.UseBox = false;
            Td.Proportional = true;
            Td.Selectable = true;
            Td.PreviewModel = 19478;
            Td.PreviewRotation = new SampSharp.GameMode.Vector3(3.0, 0.0, -131.0);
            Td.PreviewZoom = 1;
        }
        public void Show()
        {
            Td.Show();
        }
        public void Hide()
        {
            Td.Hide();
        }

    }
    
}

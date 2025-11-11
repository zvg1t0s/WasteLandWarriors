using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampSharp.GameMode.Tools;
using SampSharp.GameMode.SAMP;
using SampSharp.GameMode.Events;
using WasteLandWarriors.Others;
using WasteLandWarriors.WorldObjects;
using WasteLandWarriors.Systems;

namespace WasteLandWarriors.Display
{
    public class Inventory
    {
        private Player p;
        public PlayerTextDraw inventoryBackPlate;
        public PlayerTextDraw playerButton;
        public PlayerTextDraw helmetbutton;
        public PlayerTextDraw backpackButton;
        public PlayerTextDraw armourButton;
        private PlayerTextDraw pagerButton;
        private PlayerTextDraw achievementsButton;
        private PlayerTextDraw capacityNum;
        private PlayerTextDraw capacityPng;
        private PlayerTextDraw capacityBar;
        private PlayerTextDraw clothNum;
        private PlayerTextDraw clothPng;
        private PlayerTextDraw clothBar;
        private PlayerTextDraw batteryNum;
        private PlayerTextDraw batteryPng;
        private PlayerTextDraw batteryBar;

        public int currentPage = 1;

        private PlayerTextDraw useButton;
        private PlayerTextDraw dropButton;
        private PlayerTextDraw sellButton;
        private PlayerTextDraw infoButton;
        public PlayerTextDraw closeinv;
        public PlayerTextDraw pageNum;
        public PlayerTextDraw backPage;
        public PlayerTextDraw forwardPage;
        public PlayerTextDraw[] weaponslots = new PlayerTextDraw[6];

        public PlayerTextDraw craftbackPlate;

        public PlayerTextDraw[,] craftsSlots = new PlayerTextDraw[3,3];
        
        public PlayerTextDraw craftSign;
        public PlayerTextDraw craftButton;
        public PlayerTextDraw craftingItemSlot;
        public PlayerTextDraw craftingItemName;
        /**
        private PlayerTextDraw[] slots = new PlayerTextDraw[42];
        **/
        public PlayerTextDraw[] weaponslotsAmmo = new PlayerTextDraw[6];
        public Slot[] slots { get; set; } = new Slot[28];


        public int[] weaponslotsAmmoNum = new int[6];

        public int[] weaponSlotsInfo = new int[6];

        private bool[] isSlotSelected = new bool[28];

        public InventoryLoot[] slotsItem = new InventoryLoot[84];

        public int helmetSlot = 0;
        public int ArmorSlot = 0;
        public int backpackSlot = 0;

        public Loot[,] craftSlotsInfo = new Loot[3,3];
        

        private int selectedSlot = -1;
        public int currentWeight = 0;
        public int maxWeight = 20000;
        public bool isOpen
        {
            get; private set;
        }
        public bool isCraftMenu
        {
            get; private set;
        }
        public bool isCookingMenu
        {
            get; private set;
        }
        public Inventory(Player player)
        {
            //________________________INVENTORY_________________________________________________________________________
            this.p = player;
            this.p.GetWeaponData(1, out _,out weaponslotsAmmoNum[0]);
            this.p.GetWeaponData(2, out _, out weaponslotsAmmoNum[1]);
            this.p.GetWeaponData(3, out _, out weaponslotsAmmoNum[2]);
            this.p.GetWeaponData(4, out _, out weaponslotsAmmoNum[3]);
            this.p.GetWeaponData(5, out _, out weaponslotsAmmoNum[4]);
            this.p.GetWeaponData(6, out _, out weaponslotsAmmoNum[5]);
            for (int i = 0; i < 28; i++)
            {
                slots[i] = new Slot(p);
            }
            for(int i = 0; i < 84; i++)
            {
                slotsItem[i] = new InventoryLoot();
            }

            inventoryBackPlate = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(476.0f, 110.0f), "_");
            inventoryBackPlate.Font = TextDrawFont.Normal;
            inventoryBackPlate.LetterSize = new SampSharp.GameMode.Vector2(0.587499, 31.199970);
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
            weaponslots[0].PreviewModel = 19478;
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
            weaponslots[1].PreviewModel = 19478;
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
            weaponslots[2].PreviewModel = 19478;
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
            weaponslots[3].PreviewModel = 19478;
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
            weaponslots[4].PreviewModel = 19478;
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
            weaponslots[5].PreviewModel = 19478;
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

            /*
             * capacitynum = TextDrawCreate(502.000000, 127.000000, "0/50");
TextDrawFont(capacitynum, 1);
TextDrawLetterSize(capacitynum, 0.233333, 0.800000);
TextDrawTextSize(capacitynum, 400.000000, 17.000000);
TextDrawSetOutline(capacitynum, 1);
TextDrawSetShadow(capacitynum, 0);
TextDrawAlignment(capacitynum, 1);
TextDrawColor(capacitynum, -1);
TextDrawBackgroundColor(capacitynum, 255);
TextDrawBoxColor(capacitynum, 50);
TextDrawUseBox(capacitynum, 0);
TextDrawSetProportional(capacitynum, 1);
TextDrawSetSelectable(capacitynum, 0);
             */
            capacityNum = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(502.000000, 127.000000), "0/50");
            capacityNum.Font = TextDrawFont.Normal;
            capacityNum.LetterSize = new SampSharp.GameMode.Vector2(0.233333, 0.800000);
            capacityNum.Width = 400.0f;
            capacityNum.Height = 17.0f;
            capacityNum.Outline = 1;
            capacityNum.Shadow = 0;
            capacityNum.Alignment = TextDrawAlignment.Left;
            capacityNum.ForeColor = -1;
            capacityNum.BackColor = 255;
            capacityNum.BoxColor = 50;
            capacityNum.UseBox = false;
            capacityNum.Proportional = true;
            capacityNum.Selectable = false;
            /*
rukzakline = TextDrawCreate(531.000000, 128.000000, "_");
TextDrawFont(rukzakline, 1);
TextDrawLetterSize(rukzakline, 0.570833, 0.600000);
TextDrawTextSize(rukzakline, 298.500000, 57.000000);
TextDrawSetOutline(rukzakline, 1);
TextDrawSetShadow(rukzakline, 0);
TextDrawAlignment(rukzakline, 2);
TextDrawColor(rukzakline, -1);
TextDrawBackgroundColor(rukzakline, 255);
TextDrawBoxColor(rukzakline, -1962934137);
TextDrawUseBox(rukzakline, 1);
TextDrawSetProportional(rukzakline, 1);
TextDrawSetSelectable(rukzakline, 0);
*/
            capacityBar = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(531.000000, 128.000000), "_");
            capacityBar.Font = TextDrawFont.Normal;
            capacityBar.LetterSize = new SampSharp.GameMode.Vector2(0.570833, 0.600000);
            capacityBar.Width = 298.5f;
            capacityBar.Height = 57.0f;
            capacityBar.Outline = 1;
            capacityBar.Shadow = 0;
            capacityBar.Alignment = TextDrawAlignment.Center;
            capacityBar.ForeColor = -1;
            capacityBar.BackColor = 255;
            capacityBar.BoxColor = -1962934137;
            capacityBar.UseBox = true;
            capacityBar.Proportional = true;
            capacityBar.Selectable = false;
            /*
capacitybanner[playerid] = CreatePlayerTextDraw(playerid, 478.000000, 113.000000, "Preview_Model");
PlayerTextDrawFont(playerid, capacitybanner[playerid], 5);
PlayerTextDrawLetterSize(playerid, capacitybanner[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, capacitybanner[playerid], 25.500000, 27.500000);
PlayerTextDrawSetOutline(playerid, capacitybanner[playerid], 0);
PlayerTextDrawSetShadow(playerid, capacitybanner[playerid], 0);
PlayerTextDrawAlignment(playerid, capacitybanner[playerid], 1);
PlayerTextDrawColor(playerid, capacitybanner[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, capacitybanner[playerid], -1378294272);
PlayerTextDrawBoxColor(playerid, capacitybanner[playerid], -16777216);
PlayerTextDrawUseBox(playerid, capacitybanner[playerid], 0);
PlayerTextDrawSetProportional(playerid, capacitybanner[playerid], 1);
PlayerTextDrawSetSelectable(playerid, capacitybanner[playerid], 0);
PlayerTextDrawSetPreviewModel(playerid, capacitybanner[playerid], 371);
PlayerTextDrawSetPreviewRot(playerid, capacitybanner[playerid], -6.000000, -1.000000, 7.000000, 1.000000);
PlayerTextDrawSetPreviewVehCol(playerid, capacitybanner[playerid], 1, 1);
*/
            capacityPng = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(478.000000, 113.000000), "Preview_Model");
            capacityPng.Font = TextDrawFont.PreviewModel;
            capacityPng.LetterSize = new SampSharp.GameMode.Vector2(0.600000, 2.000000);
            capacityPng.Width = 25.5f;
            capacityPng.Height = 27.5f;
            capacityPng.Outline = 0;
            capacityPng.Shadow = 0;
            capacityPng.Alignment = TextDrawAlignment.Left;
            capacityPng.ForeColor = -1;
            capacityPng.BackColor = -1378294272;
            capacityPng.BoxColor = -16777216;
            capacityPng.UseBox = false;
            capacityPng.Proportional = true;
            capacityPng.Selectable = false;
            capacityPng.PreviewModel = 371;
            capacityPng.PreviewRotation = new SampSharp.GameMode.Vector3(-6.0f, -1.0f, 7.0f);
            capacityPng.PreviewZoom = 1.0f;


            /*
odejdanum = TextDrawCreate(502.000000, 144.000000, "80/100");
TextDrawFont(odejdanum, 1);
TextDrawLetterSize(odejdanum, 0.233333, 0.800000);
TextDrawTextSize(odejdanum, 400.000000, 17.000000);
TextDrawSetOutline(odejdanum, 1);
TextDrawSetShadow(odejdanum, 0);
TextDrawAlignment(odejdanum, 1);
TextDrawColor(odejdanum, -1);
TextDrawBackgroundColor(odejdanum, 255);
TextDrawBoxColor(odejdanum, 50);
TextDrawUseBox(odejdanum, 0);
TextDrawSetProportional(odejdanum, 1);
TextDrawSetSelectable(odejdanum, 0);
*/
            clothNum = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(502.000000, 144.000000), "80/100");
            clothNum.Font = TextDrawFont.Normal;
            clothNum.LetterSize = new SampSharp.GameMode.Vector2(0.233333, 0.800000);
            clothNum.Width = 400.0f;
            clothNum.Height = 17.0f;
            clothNum.Outline = 1;
            clothNum.Shadow = 0;
            clothNum.Alignment = TextDrawAlignment.Left;
            clothNum.ForeColor = -1;
            clothNum.BackColor = 255;
            clothNum.BoxColor = 50;
            clothNum.UseBox = false;
            clothNum.Proportional = true;
            clothNum.Selectable = false;
            /*
clothline = TextDrawCreate(531.000000, 145.000000, "_");
TextDrawFont(clothline, 1);
TextDrawLetterSize(clothline, 0.570833, 0.600000);
TextDrawTextSize(clothline, 298.500000, 57.000000);
TextDrawSetOutline(clothline, 1);
TextDrawSetShadow(clothline, 0);
TextDrawAlignment(clothline, 2);
TextDrawColor(clothline, -1);
TextDrawBackgroundColor(clothline, 255);
TextDrawBoxColor(clothline, 1687547271);
TextDrawUseBox(clothline, 1);
TextDrawSetProportional(clothline, 1);
TextDrawSetSelectable(clothline, 0);
*/
            clothBar = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(531.000000, 145.000000), "_");
            clothBar.Font = TextDrawFont.Normal;
            clothBar.LetterSize = new SampSharp.GameMode.Vector2(0.570833, 0.600000);
            clothBar.Width = 298.5f;
            clothBar.Height = 57.0f;
            clothBar.Outline = 1;
            clothBar.Shadow = 0;
            clothBar.Alignment = TextDrawAlignment.Center;
            clothBar.ForeColor = -1;
            clothBar.BackColor = 255;
            clothBar.BoxColor = 1687547271;
            clothBar.UseBox = true;
            clothBar.Proportional = true;
            clothBar.Selectable = false;
            /*
odejdapng[playerid] = CreatePlayerTextDraw(playerid, 478.000000, 132.000000, "Preview_Model");
PlayerTextDrawFont(playerid, odejdapng[playerid], 5);
PlayerTextDrawLetterSize(playerid, odejdapng[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, odejdapng[playerid], 25.500000, 27.500000);
PlayerTextDrawSetOutline(playerid, odejdapng[playerid], 0);
PlayerTextDrawSetShadow(playerid, odejdapng[playerid], 0);
PlayerTextDrawAlignment(playerid, odejdapng[playerid], 1);
PlayerTextDrawColor(playerid, odejdapng[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, odejdapng[playerid], -1378294272);
PlayerTextDrawBoxColor(playerid, odejdapng[playerid], -16777216);
PlayerTextDrawUseBox(playerid, odejdapng[playerid], 0);
PlayerTextDrawSetProportional(playerid, odejdapng[playerid], 1);
PlayerTextDrawSetSelectable(playerid, odejdapng[playerid], 0);
PlayerTextDrawSetPreviewModel(playerid, odejdapng[playerid], 1275);
PlayerTextDrawSetPreviewRot(playerid, odejdapng[playerid], -6.000000, -1.000000, 7.000000, 1.000000);
PlayerTextDrawSetPreviewVehCol(playerid, odejdapng[playerid], 1, 1);
*/
            clothPng = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(478.000000, 132.000000), "Preview_Model");
            clothPng.Font = TextDrawFont.PreviewModel;
            clothPng.LetterSize = new SampSharp.GameMode.Vector2(0.600000, 2.000000);
            clothPng.Width = 25.5f;
            clothPng.Height = 27.5f;
            clothPng.Outline = 0;
            clothPng.Shadow = 0;
            clothPng.Alignment = TextDrawAlignment.Left;
            clothPng.ForeColor = -1;
            clothPng.BackColor = -1378294272;
            clothPng.BoxColor = -16777216;
            clothPng.UseBox = false;
            clothPng.Proportional = true;
            clothPng.Selectable = false;
            clothPng.PreviewModel = 1275;
            clothPng.PreviewRotation = new SampSharp.GameMode.Vector3(-6.0f, -1.0f, 7.0f);
            clothPng.PreviewZoom = 1.0f;
            /*
PublicTD[2] = TextDrawCreate(502.000000, 161.000000, "100/100%");
TextDrawFont(PublicTD[2], 1);
TextDrawLetterSize(PublicTD[2], 0.233333, 0.800000);
TextDrawTextSize(PublicTD[2], 400.000000, 17.000000);
TextDrawSetOutline(PublicTD[2], 1);
TextDrawSetShadow(PublicTD[2], 0);
TextDrawAlignment(PublicTD[2], 1);
TextDrawColor(PublicTD[2], -1);
TextDrawBackgroundColor(PublicTD[2], 255);
TextDrawBoxColor(PublicTD[2], 50);
TextDrawUseBox(PublicTD[2], 0);
TextDrawSetProportional(PublicTD[2], 1);
TextDrawSetSelectable(PublicTD[2], 0);
*/
            batteryNum = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(502.000000, 161.000000), "100/100%");
            batteryNum.Font = TextDrawFont.Normal;
            batteryNum.LetterSize = new SampSharp.GameMode.Vector2(0.233333, 0.800000);
            batteryNum.Width = 400.0f;
            batteryNum.Height = 17.0f;
            batteryNum.Outline = 1;
            batteryNum.Shadow = 0;
            batteryNum.Alignment = TextDrawAlignment.Left;
            batteryNum.ForeColor = -1;
            batteryNum.BackColor = 255;
            batteryNum.BoxColor = 50;
            batteryNum.UseBox = false;
            batteryNum.Proportional = true;
            batteryNum.Selectable = false;
            /*
batteryline = TextDrawCreate(531.000000, 162.000000, "_");
TextDrawFont(batteryline, 1);
TextDrawLetterSize(batteryline, 0.570833, 0.600000);
TextDrawTextSize(batteryline, 298.500000, 57.000000);
TextDrawSetOutline(batteryline, 1);
TextDrawSetShadow(batteryline, 0);
TextDrawAlignment(batteryline, 2);
TextDrawColor(batteryline, -1);
TextDrawBackgroundColor(batteryline, 255);
TextDrawBoxColor(batteryline, 16711815);
TextDrawUseBox(batteryline, 1);
TextDrawSetProportional(batteryline, 1);
TextDrawSetSelectable(batteryline, 0);
*/
            batteryBar = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(531.000000, 162.000000), "_");
            batteryBar.Font = TextDrawFont.Normal;
            batteryBar.LetterSize = new SampSharp.GameMode.Vector2(0.570833, 0.600000);
            batteryBar.Width = 298.5f;
            batteryBar.Height = 57.0f;
            batteryBar.Outline = 1;
            batteryBar.Shadow = 0;
            batteryBar.Alignment = TextDrawAlignment.Center;
            batteryBar.ForeColor = -1;
            batteryBar.BackColor = 255;
            batteryBar.BoxColor = 16711815;
            batteryBar.UseBox = true;
            batteryBar.Proportional = true;
            batteryBar.Selectable = false;
            /*
batterypng[playerid] = CreatePlayerTextDraw(playerid, 478.000000, 152.000000, "Preview_Model");
PlayerTextDrawFont(playerid, batterypng[playerid], 5);
PlayerTextDrawLetterSize(playerid, batterypng[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, batterypng[playerid], 25.500000, 27.500000);
PlayerTextDrawSetOutline(playerid, batterypng[playerid], 0);
PlayerTextDrawSetShadow(playerid, batterypng[playerid], 0);
PlayerTextDrawAlignment(playerid, batterypng[playerid], 1);
PlayerTextDrawColor(playerid, batterypng[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, batterypng[playerid], -1378294272);
PlayerTextDrawBoxColor(playerid, batterypng[playerid], -16777216);
PlayerTextDrawUseBox(playerid, batterypng[playerid], 0);
PlayerTextDrawSetProportional(playerid, batterypng[playerid], 1);
PlayerTextDrawSetSelectable(playerid, batterypng[playerid], 0);
PlayerTextDrawSetPreviewModel(playerid, batterypng[playerid], 18876);
PlayerTextDrawSetPreviewRot(playerid, batterypng[playerid], -6.000000, 0.000000, -43.000000, 1.189998);
PlayerTextDrawSetPreviewVehCol(playerid, batterypng[playerid], 1, 1);
*/
            batteryPng = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(478.000000, 152.000000), "Preview_Model");
            batteryPng.Font = TextDrawFont.PreviewModel;
            batteryPng.LetterSize = new SampSharp.GameMode.Vector2(0.600000, 2.000000);
            batteryPng.Width = 25.5f;
            batteryPng.Height = 27.5f;
            batteryPng.Outline = 0;
            batteryPng.Shadow = 0;
            batteryPng.Alignment = TextDrawAlignment.Left;
            batteryPng.ForeColor = -1;
            batteryPng.BackColor = -1378294272;
            batteryPng.BoxColor = -16777216;
            batteryPng.UseBox = false;
            batteryPng.Proportional = true;
            batteryPng.Selectable = false;
            batteryPng.PreviewModel = 18876;
            batteryPng.PreviewRotation = new SampSharp.GameMode.Vector3(-6.0f, 0.0f, -43.0f);
            batteryPng.PreviewZoom = 1.189998f;

            /**
pageNum[playerid] = CreatePlayerTextDraw(playerid, 472.000000, 378.000000, "1");
PlayerTextDrawFont(playerid, pageNum[playerid], 1);
PlayerTextDrawLetterSize(playerid, pageNum[playerid], 0.320832, 1.049998);
PlayerTextDrawTextSize(playerid, pageNum[playerid], 400.000000, 17.000000);
PlayerTextDrawSetOutline(playerid, pageNum[playerid], 1);
PlayerTextDrawSetShadow(playerid, pageNum[playerid], 0);
PlayerTextDrawAlignment(playerid, pageNum[playerid], 1);
PlayerTextDrawColor(playerid, pageNum[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, pageNum[playerid], 255);
PlayerTextDrawBoxColor(playerid, pageNum[playerid], 50);
PlayerTextDrawUseBox(playerid, pageNum[playerid], 0);
PlayerTextDrawSetProportional(playerid, pageNum[playerid], 1);
PlayerTextDrawSetSelectable(playerid, pageNum[playerid], 0);
**/
            pageNum = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(472,378), "1");
            pageNum.Font = TextDrawFont.Normal;
            pageNum.LetterSize = new SampSharp.GameMode.Vector2(0.320832, 1.049998);
            pageNum.Width = 400;
            pageNum.Height = 17;
            pageNum.Outline = 1;
            pageNum.Shadow = 0;
            pageNum.Alignment = TextDrawAlignment.Left;
            pageNum.ForeColor = -1;
            pageNum.BackColor = 255;
            pageNum.BoxColor = 50;
            pageNum.UseBox = false;
            pageNum.Proportional = true;
            pageNum.Selectable = false;

            /**
backPage[playerid] = CreatePlayerTextDraw(playerid, 433.000000, 378.000000, "<");
PlayerTextDrawFont(playerid, backPage[playerid], 1);
PlayerTextDrawLetterSize(playerid, backPage[playerid], 0.320832, 1.049998);
PlayerTextDrawTextSize(playerid, backPage[playerid], 443.000000, 17.000000);
PlayerTextDrawSetOutline(playerid, backPage[playerid], 1);
PlayerTextDrawSetShadow(playerid, backPage[playerid], 0);
PlayerTextDrawAlignment(playerid, backPage[playerid], 1);
PlayerTextDrawColor(playerid, backPage[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, backPage[playerid], 255);
PlayerTextDrawBoxColor(playerid, backPage[playerid], 50);
PlayerTextDrawUseBox(playerid, backPage[playerid], 1);
PlayerTextDrawSetProportional(playerid, backPage[playerid], 1);
PlayerTextDrawSetSelectable(playerid, backPage[playerid], 1);
**/
            backPage = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(433, 378), "<");
            backPage.Font = TextDrawFont.Normal;
            backPage.LetterSize = new SampSharp.GameMode.Vector2(0.320832, 1.049998);
            backPage.Width = 443.0f;
            backPage.Height = 17;
            backPage.Outline = 1;
            backPage.Shadow = 0;
            backPage.Alignment = TextDrawAlignment.Left;
            backPage.ForeColor = -1;
            backPage.BackColor = 255;
            backPage.BoxColor = 50;
            backPage.UseBox = true;
            backPage.Proportional = true;
            backPage.Selectable = true;


            /**
ForwardPager[playerid] = CreatePlayerTextDraw(playerid, 508.000000, 378.000000, ">");
PlayerTextDrawFont(playerid, ForwardPager[playerid], 1);
PlayerTextDrawLetterSize(playerid, ForwardPager[playerid], 0.320832, 1.049998);
PlayerTextDrawTextSize(playerid, ForwardPager[playerid], 518.500000, 17.000000);
PlayerTextDrawSetOutline(playerid, ForwardPager[playerid], 1);
PlayerTextDrawSetShadow(playerid, ForwardPager[playerid], 0);
PlayerTextDrawAlignment(playerid, ForwardPager[playerid], 1);
PlayerTextDrawColor(playerid, ForwardPager[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, ForwardPager[playerid], 255);
PlayerTextDrawBoxColor(playerid, ForwardPager[playerid], 50);
PlayerTextDrawUseBox(playerid, ForwardPager[playerid], 1);
PlayerTextDrawSetProportional(playerid, ForwardPager[playerid], 1);
PlayerTextDrawSetSelectable(playerid, ForwardPager[playerid], 1);
**/
            forwardPage = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(508, 378), ">");
            forwardPage.Font = TextDrawFont.Normal;
            forwardPage.LetterSize = new SampSharp.GameMode.Vector2(0.320832, 1.049998);
            forwardPage.Width = 518.5f;
            forwardPage.Height = 17;
            forwardPage.Outline = 1;
            forwardPage.Shadow = 0;
            forwardPage.Alignment = TextDrawAlignment.Left;
            forwardPage.ForeColor = -1;
            forwardPage.BackColor = 255;
            forwardPage.BoxColor = 50;
            forwardPage.UseBox = true;
            forwardPage.Proportional = true;
            forwardPage.Selectable = true;

            slots[0].Create(p, 375.0f, 257.0f);

            slots[1].Create(p, 404.0f, 257.0f);
            slots[2].Create(p, 433.0f, 257.0f);

            slots[3].Create(p, 462.0f, 257.0f);

            slots[4].Create(p, 491.0f, 257.0f);


            slots[5].Create(p, 520.0f, 257.0f);


            slots[6].Create(p, 548.0f, 257.0f);


            slots[7].Create(p, 375.0f, 287.0f);

            slots[8].Create(p, 404.0f, 287.0f);


            slots[9].Create(p, 433.0f, 287.0f);

            slots[10].Create(p, 462.0f, 287.0f);

            slots[11].Create(p, 491.0f, 287.0f);

            slots[12].Create(p, 520.0f, 287.0f);

            slots[13].Create(p, 548.0f, 287.0f);

            slots[14].Create(p, 375.0f, 317.0f);

            slots[15].Create(p, 404.0f, 317.0f);

            slots[16].Create(p, 433.0f, 317.0f);

            slots[17].Create(p, 462.0f, 317.0f);

            slots[18].Create(p, 491.0f, 317.0f);

            slots[19].Create(p, 520.0f, 317.0f);


            slots[20].Create(p, 548.0f, 317.0f);

            slots[21].Create(p, 375.0f, 348.0f);


            slots[22].Create(p, 404.0f, 348.0f);

            slots[23].Create(p, 433.0f, 348.0f);

            slots[24].Create(p, 462.0f, 348.0f);

            slots[25].Create(p, 491.0f, 348.0f);

            slots[26].Create(p, 520.0f, 348.0f);

            slots[27].Create(p, 548.0f, 348.0f);
            /**
            slots[28].Create(p, 375.0f, 379.0f);

            slots[29].Create(p, 404.0f, 379.0f);

            slots[30].Create(p, 433.0f, 379.0f);

            slots[31].Create(p, 462.0f, 379.0f);
            slots[32].Create(p, 491.0f, 379.0f);

            slots[33].Create(p, 520.0f, 379.0f);

            slots[34].Create(p, 548.0f, 379.0f);

            slots[35].Create(p, 375.0f, 410.0f);

            slots[36].Create(p, 404.0f, 410.0f);

            slots[37].Create(p, 433.0f, 410.0f);

            slots[38].Create(p, 462.0f, 410.0f);

            slots[39].Create(p, 491.0f, 410.0f);

            slots[40].Create(p, 520.0f, 410.0f);

            slots[41].Create(p, 548.0f, 410.0f);

            **/



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

            /**
craftslotsBackPlate[playerid] = CreatePlayerTextDraw(playerid, 435.000000, 127.000000, "_");
PlayerTextDrawFont(playerid, craftslotsBackPlate[playerid], 1);
PlayerTextDrawLetterSize(playerid, craftslotsBackPlate[playerid], 0.587499, 10.749962);
PlayerTextDrawTextSize(playerid, craftslotsBackPlate[playerid], 298.500000, 90.500000);
PlayerTextDrawSetOutline(playerid, craftslotsBackPlate[playerid], 1);
PlayerTextDrawSetShadow(playerid, craftslotsBackPlate[playerid], 0);
PlayerTextDrawAlignment(playerid, craftslotsBackPlate[playerid], 2);
PlayerTextDrawColor(playerid, craftslotsBackPlate[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, craftslotsBackPlate[playerid], 255);
PlayerTextDrawBoxColor(playerid, craftslotsBackPlate[playerid], -1094795595);
PlayerTextDrawUseBox(playerid, craftslotsBackPlate[playerid], 1);
PlayerTextDrawSetProportional(playerid, craftslotsBackPlate[playerid], 1);
PlayerTextDrawSetSelectable(playerid, craftslotsBackPlate[playerid], 0);
**/

            /**
craftbackplate[playerid] = CreatePlayerTextDraw(playerid, 388.000000, 126.000000, "Preview_Model");
PlayerTextDrawFont(playerid, craftbackplate[playerid], 5);
PlayerTextDrawLetterSize(playerid, craftbackplate[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, craftbackplate[playerid], 93.500000, 99.500000);
PlayerTextDrawSetOutline(playerid, craftbackplate[playerid], 0);
PlayerTextDrawSetShadow(playerid, craftbackplate[playerid], 0);
PlayerTextDrawAlignment(playerid, craftbackplate[playerid], 1);
PlayerTextDrawColor(playerid, craftbackplate[playerid], -764862721);
PlayerTextDrawBackgroundColor(playerid, craftbackplate[playerid], 1097458045);
PlayerTextDrawBoxColor(playerid, craftbackplate[playerid], 1097458033);
PlayerTextDrawUseBox(playerid, craftbackplate[playerid], 0);
PlayerTextDrawSetProportional(playerid, craftbackplate[playerid], 1);
PlayerTextDrawSetSelectable(playerid, craftbackplate[playerid], 0);
PlayerTextDrawSetPreviewModel(playerid, craftbackplate[playerid], 3096);
PlayerTextDrawSetPreviewRot(playerid, craftbackplate[playerid], 0.000000, 0.000000, 0.000000, 1.000000);
PlayerTextDrawSetPreviewVehCol(playerid, craftbackplate[playerid], 1, 1);
**/
            craftbackPlate = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(388.000000, 126.000000), "Preview_Model");

            //19478
            craftbackPlate.Font = TextDrawFont.PreviewModel;
            craftbackPlate.LetterSize = new SampSharp.GameMode.Vector2(0.600000, 2.000000);
            craftbackPlate.Outline = 0;
            craftbackPlate.Width = 93.5f;
            craftbackPlate.Height = 99.5f;
            craftbackPlate.Shadow = 0;
            craftbackPlate.Alignment = TextDrawAlignment.Left;
            craftbackPlate.ForeColor = -764862721;
            craftbackPlate.BackColor = 1097458045;
            craftbackPlate.BoxColor = 1094795595;
            craftbackPlate.UseBox = false;
            craftbackPlate.Proportional = true;
            craftbackPlate.Selectable = false;
            craftbackPlate.PreviewModel = 3096;
            craftbackPlate.PreviewRotation = new SampSharp.GameMode.Vector3(0,0,0);
            craftbackPlate.PreviewZoom = 1;

            /**
craftslot1[playerid] = CreatePlayerTextDraw(playerid, 393.000000, 131.000000, "Preview_Model");
PlayerTextDrawFont(playerid, craftslot1[playerid], 5);
PlayerTextDrawLetterSize(playerid, craftslot1[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, craftslot1[playerid], 24.000000, 26.500000);
PlayerTextDrawSetOutline(playerid, craftslot1[playerid], 0);
PlayerTextDrawSetShadow(playerid, craftslot1[playerid], 0);
PlayerTextDrawAlignment(playerid, craftslot1[playerid], 1);
PlayerTextDrawColor(playerid, craftslot1[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, craftslot1[playerid], -1094795651);
PlayerTextDrawBoxColor(playerid, craftslot1[playerid], -16777103);
PlayerTextDrawUseBox(playerid, craftslot1[playerid], 0);
PlayerTextDrawSetProportional(playerid, craftslot1[playerid], 1);
PlayerTextDrawSetSelectable(playerid, craftslot1[playerid], 1);
PlayerTextDrawSetPreviewModel(playerid, craftslot1[playerid], 19843);
PlayerTextDrawSetPreviewRot(playerid, craftslot1[playerid], -90.000000, 0.000000, 0.000000, 1.000000);
PlayerTextDrawSetPreviewVehCol(playerid, craftslot1[playerid], 1, 1);
**/

            craftsSlots[0,0] = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(393, 131), "Preview_Model");
            craftsSlots[0,0].Font = TextDrawFont.PreviewModel;
            craftsSlots[0,0].LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            craftsSlots[0,0].Width = 24.0f;
            craftsSlots[0,0].Height = 26.5f;
            craftsSlots[0,0].Outline = 0;
            craftsSlots[0,0].Shadow = 0;
            craftsSlots[0,0].Alignment = TextDrawAlignment.Left;
            craftsSlots[0,0].ForeColor = -1;
            craftsSlots[0,0].BackColor = -1094795651;
            craftsSlots[0,0].BoxColor = -16777103;
            craftsSlots[0,0].UseBox = false;
            craftsSlots[0,0].Proportional = true;
            craftsSlots[0,0].Selectable = true;
            craftsSlots[0,0].PreviewModel = 19478;
            craftsSlots[0,0].PreviewRotation = new SampSharp.GameMode.Vector3(90, 0, 0);
            craftsSlots[0,0].PreviewZoom = 1;

            craftsSlots[0,1] = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(423.000000, 131.000000), "Preview_Model");
            craftsSlots[0,1].Font = TextDrawFont.PreviewModel;
            craftsSlots[0,1].LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            craftsSlots[0,1].Width = 24.0f;
            craftsSlots[0,1].Height = 26.5f;
            craftsSlots[0,1].Outline = 0;
            craftsSlots[0,1].Shadow = 0;
            craftsSlots[0,1].Alignment = TextDrawAlignment.Left;
            craftsSlots[0,1].ForeColor = -1;
            craftsSlots[0,1].BackColor = -1094795651;
            craftsSlots[0,1].BoxColor = -16777103;
            craftsSlots[0,1].UseBox = false;
            craftsSlots[0,1].Proportional = true;
            craftsSlots[0,1].Selectable = true;
            craftsSlots[0,1].PreviewModel = 19478;
            craftsSlots[0,1].PreviewRotation = new SampSharp.GameMode.Vector3(90, 0, 0);
            craftsSlots[0,1].PreviewZoom = 1;

            craftsSlots[0,2] = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(453.000000, 131.000000), "Preview_Model");
            craftsSlots[0,2].Font = TextDrawFont.PreviewModel;
            craftsSlots[0, 2].LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            craftsSlots[0, 2].Width = 24.0f;
            craftsSlots[0, 2].Height = 26.5f;
            craftsSlots[0, 2].Outline = 0;
            craftsSlots[0, 2].Shadow = 0;
            craftsSlots[0, 2].Alignment = TextDrawAlignment.Left;
            craftsSlots[0, 2].ForeColor = -1;
            craftsSlots[0, 2].BackColor = -1094795651;
            craftsSlots[0, 2].BoxColor = -16777103;
            craftsSlots[0, 2].UseBox = false;
            craftsSlots[0, 2].Proportional = true;
            craftsSlots[0, 2].Selectable = true;
            craftsSlots[0, 2].PreviewModel = 19478;
            craftsSlots[0, 2].PreviewRotation = new SampSharp.GameMode.Vector3(90, 0, 0);
            craftsSlots[0, 2].PreviewZoom = 1;

            craftsSlots[1, 0] = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(393.000000, 163.000000), "Preview_Model");
            craftsSlots[1, 0].Font = TextDrawFont.PreviewModel;
            craftsSlots[1, 0].LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            craftsSlots[1, 0].Width = 24.0f;
            craftsSlots[1, 0].Height = 26.5f;
            craftsSlots[1, 0].Outline = 0;
            craftsSlots[1, 0].Shadow = 0;
            craftsSlots[1, 0].Alignment = TextDrawAlignment.Left;
            craftsSlots[1, 0].ForeColor = -1;
            craftsSlots[1, 0].BackColor = -1094795651;
            craftsSlots[1, 0].BoxColor = -16777103;
            craftsSlots[1, 0].UseBox = false;
            craftsSlots[1, 0].Proportional = true;
            craftsSlots[1, 0].Selectable = true;
            craftsSlots[1, 0].PreviewModel = 19478;
            craftsSlots[1, 0].PreviewRotation = new SampSharp.GameMode.Vector3(90, 0, 0);
            craftsSlots[1, 0].PreviewZoom = 1;

            craftsSlots[1,1] = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(423.000000, 163.000000), "Preview_Model");
            craftsSlots[1,1].Font = TextDrawFont.PreviewModel;
            craftsSlots[1,1].LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            craftsSlots[1,1].Width = 24.0f;
            craftsSlots[1,1].Height = 26.5f;
            craftsSlots[1,1].Outline = 0;
            craftsSlots[1,1].Shadow = 0;
            craftsSlots[1,1].Alignment = TextDrawAlignment.Left;
            craftsSlots[1,1].ForeColor = -1;
            craftsSlots[1,1].BackColor = -1094795651;
            craftsSlots[1,1].BoxColor = -16777103;
            craftsSlots[1,1].UseBox = false;
            craftsSlots[1,1].Proportional = true;
            craftsSlots[1,1].Selectable = true;
            craftsSlots[1,1].PreviewModel = 19478;
            craftsSlots[1,1].PreviewRotation = new SampSharp.GameMode.Vector3(90, 0, 0);
            craftsSlots[1,1].PreviewZoom = 1;

            craftsSlots[1,2] = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(453.000000, 163.000000), "Preview_Model");
            craftsSlots[1,2].Font = TextDrawFont.PreviewModel;
            craftsSlots[1,2].LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            craftsSlots[1,2].Width = 24.0f;
            craftsSlots[1,2].Height = 26.5f;
            craftsSlots[1,2].Outline = 0;
            craftsSlots[1,2].Shadow = 0;
            craftsSlots[1,2].Alignment = TextDrawAlignment.Left;
            craftsSlots[1,2].ForeColor = -1;
            craftsSlots[1,2].BackColor = -1094795651;
            craftsSlots[1,2].BoxColor = -16777103;
            craftsSlots[1,2].UseBox = false;
            craftsSlots[1,2].Proportional = true;
            craftsSlots[1,2].Selectable = true;
            craftsSlots[1,2].PreviewModel = 19478;
            craftsSlots[1,2].PreviewRotation = new SampSharp.GameMode.Vector3(90, 0, 0);
            craftsSlots[1,2].PreviewZoom = 1;

            craftsSlots[2,0] = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(393.000000, 195.000000), "Preview_Model");
            craftsSlots[2,0].Font = TextDrawFont.PreviewModel;
            craftsSlots[2,0].LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            craftsSlots[2,0].Width = 24.0f;
            craftsSlots[2,0].Height = 26.5f;
            craftsSlots[2,0].Outline = 0;
            craftsSlots[2,0].Shadow = 0;
            craftsSlots[2,0].Alignment = TextDrawAlignment.Left;
            craftsSlots[2,0].ForeColor = -1;
            craftsSlots[2,0].BackColor = -1094795651;
            craftsSlots[2,0].BoxColor = -16777103;
            craftsSlots[2,0].UseBox = false;
            craftsSlots[2,0].Proportional = true;
            craftsSlots[2,0].Selectable = true;
            craftsSlots[2,0].PreviewModel = 19478;
            craftsSlots[2,0].PreviewRotation = new SampSharp.GameMode.Vector3(90, 0, 0);
            craftsSlots[2,0].PreviewZoom = 1;

            craftsSlots[2,1] = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(423.000000, 195.000000), "Preview_Model");
            craftsSlots[2,1].Font = TextDrawFont.PreviewModel;
            craftsSlots[2,1].LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            craftsSlots[2,1].Width = 24.0f;
            craftsSlots[2,1].Height = 26.5f;
            craftsSlots[2,1].Outline = 0;
            craftsSlots[2,1].Shadow = 0;
            craftsSlots[2,1].Alignment = TextDrawAlignment.Left;
            craftsSlots[2,1].ForeColor = -1;
            craftsSlots[2,1].BackColor = -1094795651;
            craftsSlots[2,1].BoxColor = -16777103;
            craftsSlots[2,1].UseBox = false;
            craftsSlots[2,1].Proportional = true;
            craftsSlots[2,1].Selectable = true;
            craftsSlots[2,1].PreviewModel = 19478;
            craftsSlots[2,1].PreviewRotation = new SampSharp.GameMode.Vector3(90, 0, 0);
            craftsSlots[2,1].PreviewZoom = 1;

            craftsSlots[2,2] = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(453.000000, 195.000000), "Preview_Model");
            craftsSlots[2,2].Font = TextDrawFont.PreviewModel;
            craftsSlots[2,2].LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            craftsSlots[2,2].Width = 24.0f;
            craftsSlots[2,2].Height = 26.5f;
            craftsSlots[2,2].Outline = 0;
            craftsSlots[2,2].Shadow = 0;
            craftsSlots[2,2].Alignment = TextDrawAlignment.Left;
            craftsSlots[2,2].ForeColor = -1;
            craftsSlots[2,2].BackColor = -1094795651;
            craftsSlots[2,2].BoxColor = -16777103;
            craftsSlots[2,2].UseBox = false;
            craftsSlots[2,2].Proportional = true;
            craftsSlots[2,2].Selectable = true;
            craftsSlots[2,2].PreviewModel = 19478;
            craftsSlots[2,2].PreviewRotation = new SampSharp.GameMode.Vector3(90, 0, 0);
            craftsSlots[2,2].PreviewZoom = 1;

            p.ClickPlayerTextDraw += OnClickForwardTd;
            p.ClickPlayerTextDraw += OnClickCraftButtons;

            /**
craftslotmain[playerid] = CreatePlayerTextDraw(playerid, 523.000000, 154.000000, "Preview_Model");
PlayerTextDrawFont(playerid, craftslotmain[playerid], 5);
PlayerTextDrawLetterSize(playerid, craftslotmain[playerid], 0.600000, 2.000000);
PlayerTextDrawTextSize(playerid, craftslotmain[playerid], 39.000000, 41.500000);
PlayerTextDrawSetOutline(playerid, craftslotmain[playerid], 0);
PlayerTextDrawSetShadow(playerid, craftslotmain[playerid], 0);
PlayerTextDrawAlignment(playerid, craftslotmain[playerid], 1);
PlayerTextDrawColor(playerid, craftslotmain[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, craftslotmain[playerid], 1097458045);
PlayerTextDrawBoxColor(playerid, craftslotmain[playerid], 1097458033);
PlayerTextDrawUseBox(playerid, craftslotmain[playerid], 0);
PlayerTextDrawSetProportional(playerid, craftslotmain[playerid], 1);
PlayerTextDrawSetSelectable(playerid, craftslotmain[playerid], 1);
PlayerTextDrawSetPreviewModel(playerid, craftslotmain[playerid], 11716);
PlayerTextDrawSetPreviewRot(playerid, craftslotmain[playerid], 54.000000, 0.000000, 57.000000, 1.000000);
PlayerTextDrawSetPreviewVehCol(playerid, craftslotmain[playerid], 1, 1);
**/
            craftingItemSlot = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(523.000000, 154.000000), "Preview_Model");
            craftingItemSlot.Font = TextDrawFont.PreviewModel;
            craftingItemSlot.LetterSize = new SampSharp.GameMode.Vector2(0.6f, 2.0f);
            craftingItemSlot.Width = 39.0f;
            craftingItemSlot.Height = 41.5f;
            craftingItemSlot.Outline = 0;
            craftingItemSlot.Shadow = 0;
            craftingItemSlot.Alignment = TextDrawAlignment.Left;
            craftingItemSlot.ForeColor = -1;
            craftingItemSlot.BackColor = -1094795651;
            craftingItemSlot.BoxColor = -16777103;
            craftingItemSlot.UseBox = false;
            craftingItemSlot.Proportional = true;
            craftingItemSlot.Selectable = true;
            craftingItemSlot.PreviewModel = 19478;
            craftingItemSlot.PreviewRotation = new SampSharp.GameMode.Vector3(90, 0, 0);
            craftingItemSlot.PreviewZoom = 1;

            /**
CRAFTSIGN[playerid] = CreatePlayerTextDraw(playerid, 476.000000, 109.000000, "CRAFT");
PlayerTextDrawFont(playerid, CRAFTSIGN[playerid], 1);
PlayerTextDrawLetterSize(playerid, CRAFTSIGN[playerid], 0.366665, 1.399997);
PlayerTextDrawTextSize(playerid, CRAFTSIGN[playerid], 400.000000, 17.000000);
PlayerTextDrawSetOutline(playerid, CRAFTSIGN[playerid], 0);
PlayerTextDrawSetShadow(playerid, CRAFTSIGN[playerid], 0);
PlayerTextDrawAlignment(playerid, CRAFTSIGN[playerid], 2);
PlayerTextDrawColor(playerid, CRAFTSIGN[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, CRAFTSIGN[playerid], 255);
PlayerTextDrawBoxColor(playerid, CRAFTSIGN[playerid], 50);
PlayerTextDrawUseBox(playerid, CRAFTSIGN[playerid], 0);
PlayerTextDrawSetProportional(playerid, CRAFTSIGN[playerid], 1);
PlayerTextDrawSetSelectable(playerid, CRAFTSIGN[playerid], 0);
**/
            craftSign = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(435.000000, 109.000000), "CRAFT");

            //19478
            craftSign.Font = TextDrawFont.Slim;
            craftSign.LetterSize = new SampSharp.GameMode.Vector2(0.366665, 1.399996);
            craftSign.Outline = 1;
            craftSign.Width = 400f;
            craftSign.Height = 17f;
            craftSign.Shadow = 0;
            craftSign.Alignment = TextDrawAlignment.Center;
            craftSign.ForeColor = -1;
            craftSign.BackColor = 255;
            craftSign.BoxColor = 50;
            craftSign.UseBox = false;
            craftSign.Proportional = true;
            craftSign.Selectable = false;

            /**
craftslotmainName[playerid] = CreatePlayerTextDraw(playerid, 544.000000, 197.000000, "lockpick");
PlayerTextDrawFont(playerid, craftslotmainName[playerid], 1);
PlayerTextDrawLetterSize(playerid, craftslotmainName[playerid], 0.212500, 0.899999);
PlayerTextDrawTextSize(playerid, craftslotmainName[playerid], 400.000000, 17.000000);
PlayerTextDrawSetOutline(playerid, craftslotmainName[playerid], 1);
PlayerTextDrawSetShadow(playerid, craftslotmainName[playerid], 0);
PlayerTextDrawAlignment(playerid, craftslotmainName[playerid], 2);
PlayerTextDrawColor(playerid, craftslotmainName[playerid], -1);
PlayerTextDrawBackgroundColor(playerid, craftslotmainName[playerid], 255);
PlayerTextDrawBoxColor(playerid, craftslotmainName[playerid], 50);
PlayerTextDrawUseBox(playerid, craftslotmainName[playerid], 0);
PlayerTextDrawSetProportional(playerid, craftslotmainName[playerid], 1);
PlayerTextDrawSetSelectable(playerid, craftslotmainName[playerid], 0);
**/
            craftingItemName = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(544.000000, 197.000000), "lockpick");

            //19478
            craftingItemName.Font = TextDrawFont.Normal;
            craftingItemName.LetterSize = new SampSharp.GameMode.Vector2(0.212500, 0.899999);
            craftingItemName.Outline = 1;
            craftingItemName.Width = 400f;
            craftingItemName.Height = 17f;
            craftingItemName.Shadow = 0;
            craftingItemName.Alignment = TextDrawAlignment.Center;
            craftingItemName.ForeColor = -1;
            craftingItemName.BackColor = 255;
            craftingItemName.BoxColor = 50;
            craftingItemName.UseBox = false;
            craftingItemName.Proportional = true;
            craftingItemName.Selectable = false;

            /**
PublicTD[0] = TextDrawCreate(486.000000, 163.000000, "LD_BEAT:right");
TextDrawFont(PublicTD[0], 4);
TextDrawLetterSize(PublicTD[0], 0.600000, 2.000000);
TextDrawTextSize(PublicTD[0], 33.500000, 27.500000);
TextDrawSetOutline(PublicTD[0], 1);
TextDrawSetShadow(PublicTD[0], 0);
TextDrawAlignment(PublicTD[0], 1);
TextDrawColor(PublicTD[0], -1);
TextDrawBackgroundColor(PublicTD[0], 255);
TextDrawBoxColor(PublicTD[0], 50);
TextDrawUseBox(PublicTD[0], 1);
TextDrawSetProportional(PublicTD[0], 1);
TextDrawSetSelectable(PublicTD[0], 1);
**/
            craftButton = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(486.000000, 163.000000), "LD_BEAT:right");

            //19478
            craftButton.Font = TextDrawFont.DrawSprite;
            craftButton.LetterSize = new SampSharp.GameMode.Vector2(0.600000, 2.000000);
            craftButton.Outline = 1;
            craftButton.Width = 33.5f;
            craftButton.Height = 27.5f;
            craftButton.Shadow = 0;
            craftButton.Alignment = TextDrawAlignment.Left;
            craftButton.ForeColor = 1433087924;
            craftButton.BackColor = 255;
            craftButton.BoxColor = 50;
            craftButton.UseBox = true;
            craftButton.Proportional = true;
            craftButton.Selectable = true;
        }
        public void Show()
        {
            p.SelectTextDraw(SampSharp.GameMode.SAMP.Color.Yellow);
            Update();
            inventoryBackPlate.Show();
            playerButton.PreviewModel = p.Skin;
            playerButton.Show();




            pagerButton.Show();
            achievementsButton.Show();

            capacityPng.Show();
            clothPng.Show();
            batteryPng.Show();
            capacityBar.Show();
            clothBar.Show();
            batteryBar.Show();
            capacityNum.Text = $"{Convert.ToDouble(currentWeight) / 1000}/{maxWeight / 1000}_KG";
            capacityNum.Show();
            clothNum.Show();
            batteryNum.Show();

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

            if (helmetSlot == 0)
            {
                helmetbutton.PreviewModel = 19478;

            }
            helmetbutton.Show();
            if (ArmorSlot == 0)
            {
                armourButton.PreviewModel = 19478;

            }
            armourButton.Show();
            if (backpackSlot == 0)
            {
                backpackButton.PreviewModel = 19478;

            }
            backpackButton.Show();
            for (int i = 0; i <= 5; i++)
            {
                if (weaponSlotsInfo[i] != 0)
                {
                    this.p.GetWeaponData(i+1, out _, out weaponslotsAmmoNum[i]);
                    weaponslotsAmmo[i].Text = weaponslotsAmmoNum[i].ToString();
                    weaponslotsAmmo[i].Show();
                }
            }
            foreach (Slot s in slots)
            {
                s.Show();
            }
            pageNum.Show();
            backPage.Show();
            forwardPage.Show();
            isOpen = true;
        }

        public void ShowCookingSystem()
        {
            craftbackPlate.PreviewModel = 19527;
            craftbackPlate.BackColor = -764862924;
            craftbackPlate.ForeColor = -1;

            craftSign.Text = "Cooking";
            isCookingMenu = true;
            p.SelectTextDraw(SampSharp.GameMode.SAMP.Color.Yellow);
            Update();
            inventoryBackPlate.Show();

            closeinv.Show();


            foreach (Slot s in slots)
            {
                s.Show();
            }
            pageNum.Show();
            backPage.Show();
            forwardPage.Show();
            craftbackPlate.Show();
            for (int i = 0; i < craftsSlots.GetLength(0); i++)
            {
                for (int j = 0; j < craftsSlots.GetLength(1); j++)
                {
                    craftsSlots[i, j].Show();
                }
            }
            craftSign.Show();
            craftButton.Show();
            craftingItemSlot.Show();
            craftingItemName.Show();

        }

        public void OnClickForwardTd(object sender, ClickPlayerTextDrawEventArgs e)
        {
            if (e.PlayerTextDraw == forwardPage)
            {
                if (currentPage == 1)
                {
                    currentPage++;
                }
                else if (currentPage == 2)
                {
                    currentPage++;
                }
                Update();
            }
            if(e.PlayerTextDraw == backPage)
            {
                if(currentPage == 2)
                {
                    currentPage--;
                }
                else if(currentPage == 3)
                {
                    currentPage--;
                }
                Update();
            }
        }
        public Loot UpdateCraftMenu()
        {
            int currentRecipeW = 0;
            int currentRecipeH = 0;
            int currentRecipewStartIndex = -1;
            int currentRecipehStartIndex = -1;

            for (int i = 0; i < craftSlotsInfo.GetLength(0); i++)
            {
                for (int j = 0; j < craftSlotsInfo.GetLength(1); j++)
                {
                    if (craftSlotsInfo[i, j] != null)
                    {
                        craftsSlots[i, j].PreviewModel = craftSlotsInfo[i, j].previewModelId;
                    }
                    else craftsSlots[i, j].PreviewModel = 19478;
                }
            }
            for (int i = 0; i < craftSlotsInfo.GetLength(0); i++)
            {
                for (int j = 0; j < craftSlotsInfo.GetLength(1); j++)
                {

                    if (craftSlotsInfo[i, j] != null)
                    {
                        if (currentRecipehStartIndex == -1)
                        {
                            currentRecipehStartIndex = i;
                        }
                        currentRecipeH++;
                        break;
                    }
                }
            }

            for (int i = 0; i < craftSlotsInfo.GetLength(1); i++)
            {

                for (int j = 0; j < craftSlotsInfo.GetLength(0); j++)
                {
                    if (craftSlotsInfo[j, i] != null)
                    {
                        if (currentRecipewStartIndex == -1)
                        {
                            currentRecipewStartIndex = i;
                        }
                        currentRecipeW++;
                        break;
                    }
                }
            }
            var craftOrder = new Loot[currentRecipeH * currentRecipeW];

            for (int orderId = 0, i = currentRecipehStartIndex; i < currentRecipehStartIndex + currentRecipeH; i++)
            {
                for (int k = currentRecipewStartIndex; k < currentRecipewStartIndex + currentRecipeW; k++)
                { 
                    craftOrder[orderId++] = craftSlotsInfo[i, k];
                }
            }
            if (isCraftMenu)
            {
                foreach (var item in CraftRecipe.recipeList)
                {
                    if (item.itemsOrder.SequenceEqual(craftOrder))
                    {
                        craftingItemName.Text = item.EngName;
                        craftingItemSlot.PreviewModel = item.FinalLootItem.previewModelId;
                        if (item.recipeType == RecipeType.Easy)
                        {
                            craftingItemSlot.BackColor = 0x85B7C2A1;
                        }
                        if (item.recipeType == RecipeType.Medium)
                        {
                            craftingItemSlot.BackColor = 0x5B66EDA1;
                        }
                        if (item.recipeType == RecipeType.Hard)
                        {
                            craftingItemSlot.BackColor = 0x9D3FFFA1;
                        }
                        if (item.recipeType == RecipeType.Extra)
                        {
                            craftingItemSlot.BackColor = 0xDD4444A1;
                        }
                        if (item.recipeType == RecipeType.Legendary)
                        {
                            craftingItemSlot.BackColor = 0xFFC107A1;
                        }
                        craftingItemSlot.PreviewRotation = item.FinalLootItem.rotation;
                        
                        return item.FinalLootItem;
                        
                    }
                    else
                    {
                        craftingItemSlot.PreviewModel = 19478;
                        craftingItemSlot.BackColor = 0x85B7C2A1;
                        craftingItemName.Text = "";
                    }
                }
            }
            if (isCookingMenu)
            {
                foreach (var item in CookingRecipe.recipeList)
                {
                    if (item.itemsOrder.SequenceEqual(craftOrder))
                    {
                        craftingItemName.Text = item.EngName;
                        craftingItemSlot.PreviewModel = item.FinalLootItem.previewModelId;
                        if (item.recipeType == RecipeType.Easy)
                        {
                            craftingItemSlot.BackColor = 0x85B7C2A1;
                        }
                        if (item.recipeType == RecipeType.Medium)
                        {
                            craftingItemSlot.BackColor = 0x5B66EDA1;
                        }
                        if (item.recipeType == RecipeType.Hard)
                        {
                            craftingItemSlot.BackColor = 0x9D3FFFA1;
                        }
                        if (item.recipeType == RecipeType.Extra)
                        {
                            craftingItemSlot.BackColor = 0xDD4444A1;
                        }
                        if (item.recipeType == RecipeType.Legendary)
                        {
                            craftingItemSlot.BackColor = 0xFFC107A1;
                        }
                        craftingItemSlot.PreviewRotation = item.FinalLootItem.rotation;
                        
                        return item.FinalLootItem;
                        
                    }
                    else
                    {
                        craftingItemSlot.PreviewModel = 19478;
                        craftingItemSlot.BackColor = 0x85B7C2A1;
                        craftingItemName.Text = "";
                    }
                }
                
            }
            /**
            for (int i = 0; i < craftSlotsInfo.Length; i++)
            {

                if (craftSlotsInfo[i] != 0)
                {
                    craftsSlots[i].PreviewModel = Loot.loots.FirstOrDefault(l => l.Id == craftSlotsInfo[i]).previewModelId;
                }
                else craftsSlots[i].PreviewModel = 19478;
            }
            **/
            /**
            if (isCraftMenu)
            {
                foreach (var recipe in CraftRecipe.recipeList)
                {
                    if (recipe.recipeGrid.SequenceEqual(craftSlotsInfo))
                    {
                        craftingItemName.Text = recipe.EngName;
                        craftingItemSlot.PreviewModel = recipe.FinalLootItem.previewModelId;
                        if (recipe.recipeType == RecipeType.Easy)
                        {
                            craftingItemSlot.BackColor = 0x85B7C2A1;
                        }
                        if (recipe.recipeType == RecipeType.Medium)
                        {
                            craftingItemSlot.BackColor = 0x5B66EDA1;
                        }
                        if (recipe.recipeType == RecipeType.Hard)
                        {
                            craftingItemSlot.BackColor = 0x9D3FFFA1;
                        }
                        if (recipe.recipeType == RecipeType.Extra)
                        {
                            craftingItemSlot.BackColor = 0xDD4444A1;
                        }
                        if (recipe.recipeType == RecipeType.Legendary)
                        {
                            craftingItemSlot.BackColor = 0xFFC107A1;
                        }
                        craftingItemSlot.PreviewRotation = recipe.FinalLootItem.rotation;
                        break;
                    }
                    else
                    {
                        craftingItemSlot.PreviewModel = 19478;
                        craftingItemSlot.BackColor = 0x85B7C2A1;
                        craftingItemName.Text = "";
                    }
                }
            }
            if (isCookingMenu)
            {
                foreach (var recipe in CookingRecipe.recipeList)
                {
                    if (recipe.recipeGrid.SequenceEqual(craftSlotsInfo))
                    {
                        craftingItemName.Text = recipe.EngName;
                        craftingItemSlot.PreviewModel = recipe.FinalLootItem.previewModelId;
                        if (recipe.recipeType == RecipeType.Easy)
                        {
                            craftingItemSlot.BackColor = 0x85B7C2A1;
                        }
                        if (recipe.recipeType == RecipeType.Medium)
                        {
                            craftingItemSlot.BackColor = 0x5B66EDA1;
                        }
                        if (recipe.recipeType == RecipeType.Hard)
                        {
                            craftingItemSlot.BackColor = 0x9D3FFFA1;
                        }
                        if (recipe.recipeType == RecipeType.Extra)
                        {
                            craftingItemSlot.BackColor = 0xDD4444A1;
                        }
                        if (recipe.recipeType == RecipeType.Legendary)
                        {
                            craftingItemSlot.BackColor = 0xFFC107A1;
                        }
                        craftingItemSlot.PreviewRotation = recipe.FinalLootItem.rotation;
                        break;
                    }
                    else
                    {
                        craftingItemSlot.PreviewModel = 19478;
                        craftingItemSlot.BackColor = 0x85B7C2A1;
                        craftingItemName.Text = "";
                    }
                }
            }
            **/
            return null;
        }

        public void OnClickCraftButtons(object sender, ClickPlayerTextDrawEventArgs e)
        {
            //var dish = 0;
            for (int i = 0; i < craftSlotsInfo.GetLength(0); i++) {
                for (int j = 0; j < craftSlotsInfo.GetLength(1); j++)
                {

                    if (e.PlayerTextDraw == craftsSlots[i, j])
                    {
                        if (craftSlotsInfo[i, j] == null && selectedSlot >= 0 && slots[selectedSlot].Item.loot != null)
                        {
                            // dish = craftSlotsInfo[i];
                            craftSlotsInfo[i, j] = slots[selectedSlot].Item.loot;
                            craftsSlots[i, j].PreviewRotation = Loot.loots.Find(x => x == slots[selectedSlot].Item.loot).rotation;
                            DeleteItem(selectedSlot);
                            //slots[selectedSlot].ItemId = dish;
                            UpdateCraftMenu();
                            Update();
                            break;
                        }
                        else if (craftSlotsInfo[i, j] != null && selectedSlot >= 0)
                        {
                            for (int k = 0; k < slotsItem.Length; k++)
                            {
                                if (slotsItem[k].loot == null)
                                {
                                    slotsItem[k].loot = Loot.loots.FirstOrDefault(l => l == craftSlotsInfo[i, j]);
                                    craftSlotsInfo[i, j] = null;
                                    UpdateCraftMenu();
                                    Update();
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
            }
            if(e.PlayerTextDraw == craftingItemSlot)
            {
                if(UpdateCraftMenu != null)
                {
                    UpdateCraftMenu().Info(p);
                }
                /**
                if (isCraftMenu)
                {
                    foreach (var recipe in CraftRecipe.recipeList)
                    {
                        if (recipe.recipeGrid.SequenceEqual(craftSlotsInfo))
                        {
                            recipe.FinalLootItem.Info(p); 
                            break;
                        }

                    }
                }
                if (isCookingMenu)
                {
                    foreach (var recipe in CookingRecipe.recipeList)
                    {
                        if (recipe.recipeGrid.SequenceEqual(craftSlotsInfo))
                        {
                            recipe.FinalLootItem.Info(p);
                            break;
                        }

                    }
                }
                **/

            }
            if (e.PlayerTextDraw == craftButton)
            {
                var item = UpdateCraftMenu();
                if (isCraftMenu)
                {
                    if (item != null)
                    {
                        for (int i = 0; i < slotsItem.Length; i++)
                        {
                            if (slotsItem[i].loot == null)
                            {
                                slotsItem[i].loot = item;

                                for (int j = 0; j < craftSlotsInfo.GetLength(0); j++)
                                {
                                    for (int k = 0; k < craftSlotsInfo.GetLength(1); k++)
                                    {
                                        craftSlotsInfo[j, k] = null;
                                    }
                                }

                                p.SendClientMessage($"{{285C26}}Вы успешно скрафтили {{FFC107}}{item.Name}");
                                Update();
                                UpdateCraftMenu();
                                break;
                            }
                        }


                    }
                }
                if (isCookingMenu)
                {
                    if (item != null)
                    {
                        for (int i = 0; i < slotsItem.Length; i++)
                        {
                            if (slotsItem[i].loot == null)
                            {
                                slotsItem[i].loot = item;

                                for (int j = 0; j < craftSlotsInfo.GetLength(0); j++)
                                {
                                    for (int k = 0; k < craftSlotsInfo.GetLength(1); k++)
                                    {
                                        craftSlotsInfo[j, k] = null;
                                    }
                                }

                                p.SendClientMessage($"{{285C26}}Вы успешно приготовили {{FFC107}}{item.Name}");
                                Update();
                                UpdateCraftMenu();
                                break;
                            }
                        }


                    }
                }
                    /**
                     *
                    foreach (var recipe in CraftRecipe.recipeList)
                    {
                        if (recipe.recipeGrid.SequenceEqual(craftSlotsInfo))
                        {
                            for (int i = 0; i < slotsItem.Length; i++)
                            {
                                if (slotsItem[i].loot == null)
                                {
                                    slotsItem[i].loot = recipe.FinalLootItem;

                                    for (int j = 0; j < craftSlotsInfo.Length; j++)
                                    {
                                        craftSlotsInfo[j] = 0;
                                    }
                                    p.SendClientMessage($"{{285C26}}Вы успешно скрафтили {{FFC107}}{recipe.FinalLootItem.Name}");
                                    Update();
                                    UpdateCraftMenu();
                                    break;
                                }
                            }
                            break;
                        }

                    }
                    **/

                    if (isCookingMenu)
                {
                    /**
                    foreach (var recipe in CookingRecipe.recipeList)
                    {
                        if (recipe.recipeGrid.SequenceEqual(craftSlotsInfo))
                        {
                            for (int i = 0; i < slotsItem.Length; i++)
                            {
                                if (slotsItem[i].loot == null)
                                {
                                    slotsItem[i].loot = recipe.FinalLootItem;

                                    for (int j = 0; j < craftSlotsInfo.Length; j++)
                                    {
                                        craftSlotsInfo[j] = 0;
                                    }
                                    p.SendClientMessage($"{{285C26}}Вы успешно приготовили {{FFC107}}{recipe.FinalLootItem.Name}");
                                    Update();
                                    UpdateCraftMenu();
                                    break;
                                }
                            }
                            break;
                        }

                    }
                    **/
                }
            }
        }
        public void ShowCraftMenu()
        {
            if (!p.parameters.nearCampFire)
            {
                craftbackPlate.ForeColor = -764862721;
                craftbackPlate.BackColor = 1097458045;
                craftbackPlate.PreviewModel = 3096;

                craftSign.Text = "Craft";

                p.SelectTextDraw(SampSharp.GameMode.SAMP.Color.Yellow);
                Update();
                inventoryBackPlate.Show();

                closeinv.Show();
                isCraftMenu = true;

                foreach (Slot s in slots)
                {
                    s.Show();
                }
                pageNum.Show();
                backPage.Show();
                forwardPage.Show();
                craftbackPlate.Show();
                for (int i = 0; i < craftsSlots.GetLength(0); i++)
                {
                    for (int j = 0; j < craftsSlots.GetLength(1); j++)
                    {
                        craftsSlots[i,j].Show();
                    }
                }
                craftSign.Show();
                craftButton.Show();
                craftingItemSlot.Show();
                craftingItemName.Show();
            }
        }

        public bool AddItem(int id)
        {
            for (int i = 0; i < slotsItem.Length; i++)
            {
                if (slotsItem[i].loot == null)
                {
                    slotsItem[i].loot = Loot.loots.FirstOrDefault(l => l.Id == id);
                    return true;
                }
            }
            return false;
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

            capacityPng.Hide();
            clothPng.Hide();
            batteryPng.Hide();
            capacityBar.Hide();
            clothBar.Hide();
            batteryBar.Hide();
            capacityNum.Hide();
            clothNum.Hide();
            batteryNum.Hide();

            weaponslots[0].Hide();
            weaponslots[1].Hide();
            weaponslots[2].Hide();
            weaponslots[3].Hide();
            weaponslots[4].Hide();
            weaponslots[5].Hide();
            weaponslotsAmmo[0].Hide();
            weaponslotsAmmo[1].Hide();
            weaponslotsAmmo[2].Hide();
            weaponslotsAmmo[3].Hide();
            weaponslotsAmmo[4].Hide();
            weaponslotsAmmo[5].Hide();
            useButton.Hide();
            dropButton.Hide();
            sellButton.Hide();
            infoButton.Hide();
            closeinv.Hide();
            pageNum.Hide();
            forwardPage.Hide();
            backPage.Hide();

            craftbackPlate.Hide();
            
                craftingItemSlot.PreviewModel = 19478;
                craftingItemSlot.BackColor = Color.LightYellow;
                for (int i = 0; i < craftSlotsInfo.GetLength(0); i++)
                {
                for (int j = 0; j < craftSlotsInfo.GetLength(1); j++)
                {
                    craftsSlots[i,j].Hide();
                    craftsSlots[i,j].PreviewModel = 19478;
                    if (craftSlotsInfo[i, j] != null)
                    {
                        for (int k = 0; k < slotsItem.Length; k++)
                        {
                            if (slotsItem[k].loot == null)
                            {
                                slotsItem[k].loot = Loot.loots.FirstOrDefault(l => l == craftSlotsInfo[i, j]);

                                break;

                            }
                        }
                    }

                    craftSlotsInfo[i , j] = null;
                }
                    
                }
                isCraftMenu = false;
            isCookingMenu = false;
            
            craftSign.Hide();
            craftButton.Hide();
            craftingItemSlot.Hide();
            craftingItemName.Hide();
            
            foreach (Slot s in slots)
            {
                s.Hide();
            }
            isOpen = false;
            isCraftMenu = false;
            Update();
        }
        public void Clear()
        {
            foreach (var s in slots)
            {
                s.Item = null;
                s.Td.PreviewModel = 19478;

            }
            foreach (var ws in weaponslots)
            {
                ws.PreviewModel = 19478;
            }
            weaponSlotsInfo = weaponSlotsInfo.Select(x => 0).ToArray();

            foreach (var wsa in weaponslotsAmmo)
            {
                wsa.Text = "0";
            }
            for(int i = 0; i < weaponslotsAmmoNum.Length; i++)
            {
                weaponslotsAmmoNum[i] = 0;
            }
            ArmorSlot = 0;
            armourButton.PreviewModel = 19478;
            helmetSlot = 0;
            helmetbutton.PreviewModel = 19478;
            backpackSlot = 0;
            backpackButton.PreviewModel = 19478;


        }
        public void Select(ClickPlayerTextDrawEventArgs e)
        {
            for (int i = 0; i < slots.Length; i++)
            {
                if (e.PlayerTextDraw == slots[i].Td)
                {

                    selectedSlot = i;

                }
                else
                {
                    slots[i].Unselect();
                }
            }
            // selectedSlot = Array.FindIndex(slots, slot => slot.Td == e.PlayerTextDraw);
            if (selectedSlot != -1)
            {
                slots[selectedSlot].Select();
            }
            return;
        }
        public void Update()
        {
            int numerator = 0;
            pageNum.Text = currentPage.ToString();
            
            if(currentPage == 1)
            {
                numerator = 0;
            }
            else if(currentPage == 2)
            {
                numerator = 28;
            }
            else if(currentPage == 3)
            {
                numerator = 56;
            }
            for (int i = 0; i < slots.Length; i++)
            {
                
                if (slotsItem[i + numerator].loot != null)
                {
                    var slotsitem = slotsItem[i + numerator];
                    slots[i].Item = slotsitem;
                    slots[i].Td.PreviewModel = slotsitem.loot.previewModelId;
                    slots[i].Td.PreviewRotation = slotsitem.loot.rotation;
                    
                }
                else
                {
                    slots[i].Item = new InventoryLoot();
                    slots[i].Item.condition = 0;
                    slots[i].Td.PreviewModel = 19478;
                    
                }
                
            }
                
            
        }
        public void Use(ClickPlayerTextDrawEventArgs e)
        {

            if (e.PlayerTextDraw == useButton)
            {

                if (selectedSlot > -1)
                {
                    if (slots[selectedSlot].Item.loot != null)
                    {
                        Loot.Use(slots[selectedSlot].Item.loot.Id, selectedSlot, p);
                        slots[selectedSlot].Unselect();
                        selectedSlot = -1;
                        p.CancelSelectTextDraw();
                        Close();
                    }
                    return;
                }
            }
        }

        public void Info(ClickPlayerTextDrawEventArgs e)
        {
            if (e.PlayerTextDraw == infoButton)
            {
                if (selectedSlot > -1 && slots[selectedSlot].Item.loot != null)
                {
                    //  Loot.Info(slots[selectedSlot], p);
                    slots[selectedSlot].Item.loot.Info(p, slots[selectedSlot].Item.condition);
                    return;
                }
            }
        }
        public void Drop(ClickPlayerTextDrawEventArgs e)
        {
            if (e.PlayerTextDraw == dropButton)
            {
                if (selectedSlot > -1 && slots[selectedSlot].Item.loot != null)
                {
                    slots[selectedSlot].Item.loot.Drop(slots[selectedSlot].Item.loot, slots[selectedSlot].Item.condition, selectedSlot, p);
                    slots[selectedSlot].Unselect();
                    selectedSlot = -1;
                    Close();
                }
            }
        }
        public void OnClickHelmet(ClickPlayerTextDrawEventArgs e)
        {
            if (e.PlayerTextDraw == helmetbutton)
            {
                if (helmetSlot != 0)
                {
                    p.ApplyAnimation("GOGGLES", "GOGGLES_PUT_ON", 4.1f, false, true, true, false, 0, true);
                    for (int i = 0; i < slotsItem.Length; i++)
                    {
                        if (slotsItem[i].loot == null)
                        {
                            Update();
                            slotsItem[i].loot = Loot.loots.FirstOrDefault(l => l.Id == helmetSlot);
                            // slot.Td.PreviewModel = Loot.loots.Find(l => l.Id == helmetSlot).previewModelId;
                            currentWeight += Loot.loots.Find(l => l.Id == helmetSlot).weight;
                            helmetSlot = 0;
                            helmetbutton.PreviewModel = 19478;
                            p.SendClientMessage("{708090}Вы сняли свой шлем.");
                            p.RemoveAttachedObject(1);

                            break;
                        }
                    }
                }
            }
        }
        public void OnclickArmour(ClickPlayerTextDrawEventArgs e)
        {
            if (e.PlayerTextDraw == armourButton)
            {
                p.Armour = 0;
                p.ApplyAnimation("PLAYIDLES", "TIME", 4.1f, false, true, true, false, 2000, true);
                p.PlaySound(5602);
                if (ArmorSlot == Loot.loots.Find(l => l.Name == "Лёгкий бронежилет").Id)
                {
                    if (p.Armour < 50)
                    {
                        p.SendClientMessage("{708090}Ваш бронежилет слишком потрёпан, вы его выбросили.");
                    }
                    else
                    {
                        p.SendClientMessage("{708090}Вы сняли лёгкий бронежилет.");
                        for(int i = 0; i < slotsItem.Length; i++)
                        {
                            if (slotsItem[i].loot == null)
                            {
                                Update();
                                slotsItem[i].loot = Loot.loots.FirstOrDefault(l => l.Id == ArmorSlot);

                                currentWeight += Loot.loots.Find(l => l.Id == ArmorSlot).weight;
                                ArmorSlot = 0;
                                armourButton.PreviewModel = 19478;

                                break;
                            }
                        }

                    }

                }

                if (ArmorSlot == Loot.loots.Find(l => l.Name == "Бронежилет").Id)
                {
                    if (p.Armour < 100)
                    {
                        p.SendClientMessage("{708090}Ваш бронежилет слишком потрёпан, вы его выбросили.");
                        ArmorSlot = 0;
                        armourButton.PreviewModel = 19478;
                    }
                    else
                    {
                        p.SendClientMessage("{708090}Вы сняли бронежилет.");
                        for(int i = 0; i < slotsItem.Length; i++)
                        {
                            if (slotsItem[i].loot == null)
                            {
                                Update();
                                slotsItem[i].loot = Loot.loots.FirstOrDefault(l => l.Id == ArmorSlot);
                                //slot.Td.PreviewModel = Loot.loots.Find(l => l.Id == ArmorSlot).previewModelId;
                                currentWeight += Loot.loots.Find(l => l.Id == ArmorSlot).weight;
                                ArmorSlot = 0;
                                armourButton.PreviewModel = 19478;

                                break;
                            }
                        }

                    }

                }
            }
        }
        public void OnClickBackpack(ClickPlayerTextDrawEventArgs e)
        {
            if(e.PlayerTextDraw == backpackButton)
            {
                if(backpackSlot != 0)
                {
                    for (int i = 0; i < slotsItem.Length; i++)
                    {
                        if (slotsItem[i].loot == null)
                        {
                            Update();
                            slotsItem[i].loot = Loot.loots.FirstOrDefault(l => l.Id == backpackSlot);
                          //  slot.Td.PreviewModel = Loot.loots.Find(l => l.Id == backpackSlot).previewModelId;
                            currentWeight += Loot.loots.Find(l => l.Id == backpackSlot).weight;
                            backpackSlot = 0;
                            backpackButton.PreviewModel = 19478;
                            p.SendClientMessage("{708090}Вы сняли свой рюкзак.");
                            maxWeight = 20000;
                            p.RemoveAttachedObject(0);
                            break;
                        }
                    }
                }
            }
        }
        public void DropAllLoot()
        {
            foreach(var sl in slotsItem)
            {
                if(sl.loot != null)
                {
                    PlayerLootObject.Create(Loot.loots.Find(l => l == sl.loot),sl.condition,p.Position,p.VirtualWorld);
                    
                }
            }
            foreach(var ws in weaponSlotsInfo)
            {
                if(ws != 0)
                {
                    PlayerLootObject.Create(Loot.loots.Find(l => l.Id == ws),100, p.Position, p.VirtualWorld);
                    
                }
            }
            if(backpackSlot != 0)
            {
                PlayerLootObject.Create(Loot.loots.Find(l => l.Id == backpackSlot),100, p.Position, p.VirtualWorld);
            }
        }
        public void DeleteItem(int slotId)
        {
            if (currentPage == 1)
            {
                slotsItem[slotId].loot = null;
            }
            else if (currentPage == 2)
            {
                slotsItem[slotId + 28].loot = null;
            }
            else if (currentPage == 3)
            {
                slotsItem[slotId + 56].loot = null;
            }
            slots[slotId].Item.loot = null;
            slots[slotId].Item.condition = 0;
            slots[slotId].Td.PreviewModel = 19478;
        }
        
        public void CloseButton(ClickPlayerTextDrawEventArgs e)
        {
            if(e.PlayerTextDraw == closeinv)
            {
                Close();
                p.CancelSelectTextDraw();
            }
            return;
        }
        public bool HaveItem(int id)
        {
            for (int i = 0; i < slotsItem.Length; i++) {
                if (slotsItem[i].loot?.Id == id) return true;
            }
            return false;
        }
        

    }

    public class InventoryLoot
    {
        public Loot loot;

        public int condition = 100;
        
        public InventoryLoot()
        {
            
        }
        public InventoryLoot(Loot l, int condition)
        {
            loot = l;
            this.condition = condition;
        }

    }

    public class Slot {
        public PlayerTextDraw Td;
        public InventoryLoot Item;
        public bool IsPressed = false;

        
        public Slot(Player p)
        {
            Td = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(0,0), "Preview_Model");
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
            Item = new InventoryLoot();

        }
        
        public void Create(Player p,float posx, float posy)
        {
            Td.Position = new SampSharp.GameMode.Vector2(posx, posy);
        }
        public void Show()
        {
            
           
            Td.Show();
        }
        
        public void Hide()
        {
            Td.Hide();
        }
        public void Select()
        {
            
            Td.BackColor = -764862878;
            Td.BoxColor = -764862878;
            IsPressed = true;
        }
        public void Unselect()
        {
            Td.BackColor = -1094795651;
            Td.BoxColor = -16777103;
        }

    }
    
}

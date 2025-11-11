using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Display;
using SampSharp.GameMode.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasteLandWarriors.Others;

namespace WasteLandWarriors.Systems.BiomeGenerator.BiomeObjectMiniGames
{
    internal class BushMiniGame : IBiomeObjectMiniGame
    {
        public Player p;

        public PlayerTextDraw backPlate;

        public PlayerTextDraw target;

        public PlayerTextDraw[] bushes = new PlayerTextDraw[20];

        GeneratedObject GeneratedObject;

        public void Play(Player p, GeneratedObject go)
        {
            this.p = p;
            GeneratedObject = go;
            Create();
            Show();
            p.SelectTextDraw(SampSharp.GameMode.SAMP.Color.Yellow);
            p.ClickPlayerTextDraw += OnClickBushes;
            p.CancelClickTextDraw += OnCancelMiniGame;
        }
        void OnCancelMiniGame(object sender, PlayerEventArgs e)
        {
            Hide();
            p.ClickPlayerTextDraw -= OnClickBushes;
            p.ClearAnimations();
            p.CancelClickTextDraw -= OnCancelMiniGame;
        }
        void OnClickBushes(object sender, ClickPlayerTextDrawEventArgs e)
        {
            for (int i = 0; i < bushes.Length; i++) {
                if (e.PlayerTextDraw == bushes[i]) {
                    p.ApplyAnimation("BOMBER", "BOM_PLANT", 10.1f,false,false,false,false, 1);
                    bushes[i].Hide();
                    return;
                }
            }
            if(e.PlayerTextDraw == target)
            {
                p.CancelSelectTextDraw();
                p.inventory.AddItem(Loot.loots.FirstOrDefault(l => l.Name == "Ягода").Id);
                p.SendClientMessage("Вы нашли ягоду.");
                GeneratedObject.Delete();
                CreateBiome.genObjects.Remove(GeneratedObject);
            }
        }
        void Show()
        {
            backPlate.Show();
            target.Show();
            for (int i = 0; i < bushes.Length; i++)
            {
                bushes[i].Show();
            }
        }

        void Hide()
        {
            backPlate.Hide();
            target.Hide();
            for (int i = 0; i < bushes.Length; i++)
            {
                bushes[i].Hide();
            }
        }
        void Create()
        {
            

            /**
background = TextDrawCreate(320.000000, 169.000000, "_");
TextDrawFont(background, 1);
TextDrawLetterSize(background, 0.600000, 20.250003);
TextDrawTextSize(background, 305.000000, 244.000000);
TextDrawSetOutline(background, 1);
TextDrawSetShadow(background, 0);
TextDrawAlignment(background, 2);
TextDrawColor(background, -1);
TextDrawBackgroundColor(background, 255);
TextDrawBoxColor(background, 1804477274);
TextDrawUseBox(background, 1);
TextDrawSetProportional(background, 1);
TextDrawSetSelectable(background, 0);
**/
            backPlate = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(320, 169), "_");
            backPlate.Font = SampSharp.GameMode.Definitions.TextDrawFont.Normal;
            backPlate.LetterSize = new SampSharp.GameMode.Vector2(0.6, 20.250003);
            backPlate.Width = 305;
            backPlate.Height = 244;
            backPlate.Outline = 1;
            backPlate.Shadow = 1;
            backPlate.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Center;
            backPlate.ForeColor = -1;
            backPlate.BackColor = 255;
            backPlate.BoxColor = 1804477274;
            backPlate.UseBox = true;
            backPlate.Proportional = true;
            backPlate.Selectable = false;

            Random r = new Random();

            /**
vishnyastart = TextDrawCreate(197.000000, 315.000000, "_");
TextDrawFont(vishnyastart, 5);
TextDrawLetterSize(vishnyastart, 0.600000, 20.250003);
TextDrawTextSize(vishnyastart, 31.500000, 37.500000);
TextDrawSetOutline(vishnyastart, 1);
TextDrawSetShadow(vishnyastart, 0);
TextDrawAlignment(vishnyastart, 2);
TextDrawColor(vishnyastart, -1);
TextDrawBackgroundColor(vishnyastart, 24);
TextDrawBoxColor(vishnyastart, 1804477274);
TextDrawUseBox(vishnyastart, 1);
TextDrawSetProportional(vishnyastart, 1);
TextDrawSetSelectable(vishnyastart, 1);
TextDrawSetPreviewModel(vishnyastart, 19575);
TextDrawSetPreviewRot(vishnyastart, -10.000000, 0.000000, -20.000000, 0.709999);
TextDrawSetPreviewVehCol(vishnyastart, 1, 1);
**/
            target = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(197 + r.Next(200), 315 - r.Next(100)), "_");
            target.Font = SampSharp.GameMode.Definitions.TextDrawFont.PreviewModel;
            target.LetterSize = new SampSharp.GameMode.Vector2(0.6, 20.250003);
            target.Width = 31.5f;
            target.Height = 37.5f;
            target.Outline = 1;
            target.Shadow = 0;
            target.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Center;
            target.ForeColor = -1;
            target.BackColor = 0;
            target.BoxColor = 0;
            target.UseBox = true;
            target.Proportional = true;
            target.Selectable = true;
            target.PreviewModel = 19575;
            target.PreviewRotation = new SampSharp.GameMode.Vector3(-10, 0, -20);
            target.PreviewZoom = 0.709999f;

            for (int i = 0; i < bushes.Length; i++)
            {
                bushes[i] = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(197 + r.Next(170), 279 - r.Next(120)), "_");
                /**
kustikstart = TextDrawCreate(197.000000, 279.000000, "_");
TextDrawFont(kustikstart, 5);
TextDrawLetterSize(kustikstart, 0.600000, 20.250003);
TextDrawTextSize(kustikstart, 64.500000, 73.500000);
TextDrawSetOutline(kustikstart, 1);
TextDrawSetShadow(kustikstart, 0);
TextDrawAlignment(kustikstart, 2);
TextDrawColor(kustikstart, -1);
TextDrawBackgroundColor(kustikstart, 24);
TextDrawBoxColor(kustikstart, 1804477274);
TextDrawUseBox(kustikstart, 1);
TextDrawSetProportional(kustikstart, 1);
TextDrawSetSelectable(kustikstart, 1);
TextDrawSetPreviewModel(kustikstart, 647);
TextDrawSetPreviewRot(kustikstart, -10.000000, 0.000000, -20.000000, 0.709999);
TextDrawSetPreviewVehCol(kustikstart, 1, 1);
**/
                bushes[i].Font = TextDrawFont.PreviewModel;
                bushes[i].LetterSize = new SampSharp.GameMode.Vector2(0.6f, 20.250003f);
                bushes[i].Width = 64.5f;
                bushes[i].Height = 73.5f;
                bushes[i].Outline = 1;
                bushes[i].Shadow = 0;
                bushes[i].Alignment = TextDrawAlignment.Center;
                bushes[i].ForeColor = -1;
                bushes[i].BackColor = 0;
                bushes[i].BoxColor = 0;
                bushes[i].UseBox = true;
                bushes[i].Proportional = true;
                bushes[i].Selectable = true;
                bushes[i].PreviewModel = 647;
                bushes[i].PreviewRotation = new SampSharp.GameMode.Vector3(-10,0,-20);
                bushes[i].PreviewZoom = 0.709999f;
            }

        }

    }
}

using SampSharp.GameMode;
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
    internal class CopperMiniGame : IBiomeObjectMiniGame
    {
        public Player p;
        public PlayerTextDraw backPlate;
        public PlayerTextDraw tree;
        public PlayerTextDraw Hammer;
        GeneratedObject GeneratedObject;
        int progress = 0;
        

        void Create()
        {
            backPlate = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(320.000000, 163.000000), "_");
            backPlate.Font = SampSharp.GameMode.Definitions.TextDrawFont.Normal;
            backPlate.LetterSize = new SampSharp.GameMode.Vector2(0.662499, 21.050004);
            backPlate.Width = 300f;
            backPlate.Height = 203.5f;
            backPlate.Outline = 1;
            backPlate.Shadow = 0;
            backPlate.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Center;
            backPlate.ForeColor = -1;
            backPlate.BackColor = 255;
            backPlate.BoxColor = -253326256;
            backPlate.UseBox = true;
            backPlate.Proportional = true;
            backPlate.Selectable = false;

            tree = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(237.000000, 156.000000), "Preview_Model");
            tree.Font = SampSharp.GameMode.Definitions.TextDrawFont.PreviewModel;
            tree.LetterSize = new SampSharp.GameMode.Vector2(0.6, 2);
            tree.Width = 157.5f;
            tree.Height = 194;
            tree.Outline = 0;
            tree.Shadow = 0;
            tree.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            tree.ForeColor = -1;
            tree.BackColor = 0;
            tree.BoxColor = 0;
            tree.Proportional = true;
            tree.UseBox = false;
            tree.Selectable = false;
            tree.PreviewModel = 750;
            tree.PreviewRotation = new SampSharp.GameMode.Vector3(-10.000000, 0.000000, -20.000000);
            tree.PreviewZoom = 1;

            Hammer = new PlayerTextDraw(p, new SampSharp.GameMode.Vector2(316.000000, 257.000000), "Preview_Model");
            Hammer.Font = SampSharp.GameMode.Definitions.TextDrawFont.PreviewModel;
            Hammer.LetterSize = new SampSharp.GameMode.Vector2(0.600000, 2.000000);
            Hammer.Width = 69;
            Hammer.Height = 68.5f;
            Hammer.Outline = 0;
            Hammer.Outline = 0;
            Hammer.Shadow = 0;
            Hammer.Alignment = SampSharp.GameMode.Definitions.TextDrawAlignment.Left;
            Hammer.ForeColor = -1;
            Hammer.BackColor = 0;
            Hammer.BoxColor = 0;
            Hammer.UseBox = false;
            Hammer.Selectable = true;
            Hammer.Proportional = true;
            Hammer.PreviewModel = 19631;
            Hammer.Position = new SampSharp.GameMode.Vector2(250.000000, 268.000000);
            Hammer.PreviewRotation = new SampSharp.GameMode.Vector3(0.000000, -131.000000, 90.000000);
            Hammer.PreviewZoom = 1.0f;
        }

        public void Play(Player p, GeneratedObject obj)
        {

            if (p.inventory.HaveItem(Loot.loots.FirstOrDefault(l => l.Name == "Топор").Id))
            {
                GeneratedObject = obj;
                this.p = p;
                Create();
                Show();
                p.SelectTextDraw(SampSharp.GameMode.SAMP.Color.Yellow);
                p.ClickPlayerTextDraw += OnClickHammer;
                p.CancelClickTextDraw += OnCancelMiniGame;

            }

        }
        void OnCancelMiniGame(object sender, PlayerEventArgs e)
        {
            Hide();
            p.ClickPlayerTextDraw -= OnClickHammer;
            p.CancelClickTextDraw -= OnCancelMiniGame;
            progress = 0;
            p.RemoveAttachedObject(9);
        }
        void OnClickHammer(object sender, ClickPlayerTextDrawEventArgs e)
        {
            Random r = new Random();
            if (e.PlayerTextDraw == Hammer)
            {
                p.ApplyAnimation("BASEBALL", "BAT_4", 10.0f, false, false, false, false, 1000);
                p.SetAttachedObject(9, 19631, SampSharp.GameMode.Definitions.Bone.RightForearm, new Vector3(0.3299, -0.0089, 0.0439), new Vector3(0.0000, 0.0000, 0.0000), new Vector3(1, 1, 1), 0, 0);
                //ApplyAnimationWithAttachedObjectManager.ApplyAnimationWithAttachedObject(p, 9, SampSharp.GameMode.Definitions.Bone.RightForearm, 19631, new Vector3(0.3299, -0.0089, 0.0439), new Vector3(0.0000, 0.0000, 0.0000), new Vector3(1, 1, 1), "BASEBALL", "BAT_4", 10.0f, false, false, false, false, 1000);
                int num = r.Next(4);
                progress++;
                if (progress > 30)
                {
                    progress = 0;
                    p.inventory.slotsItem.FirstOrDefault(l => l.loot.Name == "Топор").condition -= 10;
                    //p.ApplyAnimation("BASEBALL", "BAT_4", 10.0f,false,false,false,false,2000);
                    p.SendClientMessage("Вы добыли медную руду");
                    p.inventory.AddItem(Loot.loots.FirstOrDefault(l => l.Name == "Медная руда").Id);
                    GeneratedObject.Delete();
                    CreateBiome.genObjects.Remove(GeneratedObject);
                    Hide();
                    p.CancelSelectTextDraw();
                    p.ClickPlayerTextDraw -= OnClickHammer;
                    p.RemoveAttachedObject(9);
                }
                switch (num)
                {
                    case 0:
                        Hammer.Position = new SampSharp.GameMode.Vector2(250.000000, 268.000000);
                        Hammer.PreviewRotation = new SampSharp.GameMode.Vector3(0.000000, -131.000000, 90.000000);
                        break;
                    case 1:
                        Hammer.Position = new SampSharp.GameMode.Vector2(316.000000, 257.000000);
                        Hammer.PreviewRotation = new SampSharp.GameMode.Vector3(0.000000, -49.000000, 90.000000);
                        break;
                    case 2:
                        Hammer.Position = new SampSharp.GameMode.Vector2(328.000000, 205.000000);
                        Hammer.PreviewRotation = new SampSharp.GameMode.Vector3(0.000000, -49.000000, 90.000000);
                        break;
                    case 3:
                        Hammer.Position = new SampSharp.GameMode.Vector2(262.000000, 191.000000);
                        Hammer.PreviewRotation = new SampSharp.GameMode.Vector3(0.000000, -131.000000, 90.000000);
                        break;

                }
            }
        }
        void Show()
        {
            backPlate.Show();
            tree.Show();
            Hammer.Show();
        }
        void Hide()
        {
            backPlate.Hide();
            tree.Hide();
            Hammer.Hide();
        }
    }
}

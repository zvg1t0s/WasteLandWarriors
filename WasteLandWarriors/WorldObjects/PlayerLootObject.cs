using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Display;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.World;
using SampSharp.Streamer.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using WasteLandWarriors.Others;

namespace WasteLandWarriors.WorldObjects
{
    internal class PlayerLootObject
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private DynamicObject DynamicObject { get; set; }
        public DynamicTextLabel Label { get; set; }
        public bool isTaked = false;
        // 0-noloot 1-usableLoot 2-weapon 3-clothes 4-helmet 5-armour 6-backpack
        static int LootIdentifier = 0;
        public int Idd = 0;
        public int modelId { get; set; }
        public SampSharp.GameMode.Vector3 position { get; set; }
        private static List<PlayerLootObject> loots = new List<PlayerLootObject>();
        private PlayerLootObject(Loot loot, SampSharp.GameMode.Vector3 vector, int world)
        {
            Idd = LootIdentifier;
            LootIdentifier++;
            Id = loot.Id;
            Name = loot.Name;

            modelId = loot.modelId;
            position = vector;
            DynamicObject = new DynamicObject(modelId, new SampSharp.GameMode.Vector3(vector.X, vector.Y, vector.Z - 0.9), worldid: world);
            DynamicObject.ShowInWorld(world);
            Label = new DynamicTextLabel($"{{e6dd37}}{Name}", 0, new SampSharp.GameMode.Vector3(vector.X, vector.Y, vector.Z - 0.8), 30.0f);
            Label.ShowInWorld(world);


        }
        public static void Create(Loot loot, SampSharp.GameMode.Vector3 vector, int world)
        {
            loots.Add(new PlayerLootObject(loot,vector,world));
            
        }
        public static void Take(Player p)
        {
            var dropDialog = new ListDialog("Предмет", "Взять", "Отмена");
            Dictionary<int, PlayerLootObject> dialogDic = new Dictionary<int, PlayerLootObject>();
            int index = 0;
            foreach (PlayerLootObject l in  loots)
            {
                if (p.IsInRangeOfPoint(5, l.position))
                {
                    dialogDic.Add(index, l);
                    dropDialog.AddItem(l.Name);
                    index++;
                }
            }
            dropDialog.Response += dropDialog_Response;
            dropDialog.Show(p);
            void dropDialog_Response(Object sender, DialogResponseEventArgs e)
            {
                if (e.DialogButton != DialogButton.Right)
                {
                    p.ApplyAnimation("BOMBER", "BOM_PLANT_CROUCH_IN", 2, false, true, true, true, 2, true);
                    for (int i = 0; i <= dropDialog.Items.Count; i++)
                    {
                        if (e.ListItem == i)
                        {
                            for (int j = 0; j < p.inventory.slotsinfo.Length; j++)
                            {
                                if (p.inventory.slotsinfo[j] == 0)
                                {

                                    if (dialogDic[i].isTaked == false)
                                    {
                                        p.SendClientMessage($"{{B1BA24}}Подобрано: {{177B3D}}{dialogDic[i].Name}");
                                        p.inventory.slotsinfo[j] = dialogDic[i].Id;
                                        loots.Find(item => item.Idd == dialogDic[i].Idd).isTaked = true;
                                        loots.Find(item => item.Idd == dialogDic[i].Idd).Delete();

                                        loots.Remove(dialogDic[i]);
                                        dialogDic.Clear();
                                        p.ClearAnimations(true);

                                        break;
                                    }
                                    else
                                    {
                                        p.SendClientMessage("{FF0000}Данный предмет уже подобрал другой человек.");
                                    }

                                }
                            }

                        }
                    }
                }
            }

        }
        public void Delete()
        {
            DynamicObject.Dispose();
            DynamicObject = null;
            Label.Dispose();
            Label = null;
        }

    }
}

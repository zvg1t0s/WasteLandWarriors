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
        private int id { get; set; }
        private string name { get; set; }
        private DynamicObject DynamicObject { get; set; }
        public DynamicTextLabel Label { get; set; }
        public bool isTaked = false;
        // 0-noloot 1-usableLoot 2-weapon 3-clothes 4-helmet 5-armour 6-backpack
        static int lootIdentifier = 0;
        public int idd = 0;
        public int modelId { get; set; }
        public int previewModelId { get; }
        public SampSharp.GameMode.Vector3 position { get; set; }
        public float rotation { get; set; }
        public int weight { get; set; }
        private static List<PlayerLootObject> loots = new List<PlayerLootObject>();
        private PlayerLootObject(Loot loot, SampSharp.GameMode.Vector3 vector, int world)
        {
            idd = lootIdentifier;
            lootIdentifier++;
            id = loot.Id;
            name = loot.Name;
            previewModelId = loot.previewModelId;
            modelId = loot.modelId;
            position = vector;
            rotation = loot.rotation;
            weight = loot.weight;
            DynamicObject = new DynamicObject(modelId, new SampSharp.GameMode.Vector3(vector.X, vector.Y, vector.Z - 0.9), worldid: world);
            DynamicObject.ShowInWorld(world);
            Label = new DynamicTextLabel($"{{bfbfbf}}{name} {{ff9933}}[F]", 0, new SampSharp.GameMode.Vector3(vector.X, vector.Y, vector.Z - 0.8), 30.0f);
            Label.ShowInWorld(world);


        }
        public static void Create(Loot loot, SampSharp.GameMode.Vector3 vector, int world)
        {
            loots.Add(new PlayerLootObject(loot,vector,world));
            
        }
        public static void Reloot()
        {
            
        }
        public static void Take(Player p)
        {
            var dropDialog = new ListDialog("Предмет", "Взять", "Отмена");
            Dictionary<int, PlayerLootObject> dialogDic = new Dictionary<int, PlayerLootObject>();
            int index = 0;
            foreach (PlayerLootObject l in  loots)
            {
                if (p.IsInRangeOfPoint(3, l.position))
                {
                    dialogDic.Add(index, l);
                    dropDialog.AddItem(l.name);
                    index++;
                }
            }
            dropDialog.Response += dropDialog_Response;
            dropDialog.Show(p);
            void dropDialog_Response(Object sender, DialogResponseEventArgs e)
            {
                p.ApplyAnimation("BOMBER", "BOM_PLANT_CROUCH_IN", 2, false, true, true, false, 0, true);
                if (e.DialogButton != DialogButton.Right)
                {
                    for (int i = 0; i <= dropDialog.Items.Count; i++)
                    {
                        if (e.ListItem == i)
                        {
                            for (int j = 0; j < p.inventory.slotsinfo.Length; j++)
                            {
                                if (p.inventory.slots[j].ItemId == 0)
                                {

                                    if (dialogDic[i].isTaked == false)
                                    {
                                        p.SendClientMessage($"{{B1BA24}}Подобрано: {{177B3D}}{dialogDic[i].name}");
                                        p.inventory.slots[j].ItemId = dialogDic[i].id;
                                        p.inventory.slots[j].Td.PreviewModel = dialogDic[i].previewModelId;
                                        p.inventory.slots[j].Td.PreviewRotation = new SampSharp.GameMode.Vector3(p.inventory.slots[j].Td.PreviewRotation.X, dialogDic[i].rotation, p.inventory.slots[j].Td.PreviewRotation.Z);
                                        loots.Find(item => item.idd == dialogDic[i].idd).isTaked = true;
                                        loots.Find(item => item.idd == dialogDic[i].idd).Delete();
                                        
                                        loots.Remove(dialogDic[i]);
                                        p.inventory.currentWeight += dialogDic[i].weight;
                                        dialogDic.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        p.SendClientMessage("{FF0000}Данный предмет уже подобрал другой человек.");
                                        p.ClearAnimations(true);
                                    }

                                }
                            }

                        }
                    }
                }
                if(e.DialogButton == DialogButton.Right)
                {
                    p.ClearAnimations(true);
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

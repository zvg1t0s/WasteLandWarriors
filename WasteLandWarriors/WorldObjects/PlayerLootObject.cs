using SampSharp.GameMode;
using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Display;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.World;
using SampSharp.Streamer.World;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using WasteLandWarriors.Others;

namespace WasteLandWarriors.WorldObjects
{
    internal class PlayerLootObject
    {
        private int id { get; set; }
        private DynamicObject DynamicObject { get; set; }
        public DynamicTextLabel Label { get; set; }
        public bool isTaked = false;
        // 0-noloot 1-usableLoot 2-weapon 3-clothes 4-helmet 5-armour 6-backpack
        static int lootIdentifier = 0;
  
        public Loot loot;
        public SampSharp.GameMode.Vector3 position { get; set; }
        public Vector3 rotation { get; set; }

        public int condition { get; set; }
        

        private static List<PlayerLootObject> loots = new List<PlayerLootObject>();
        private PlayerLootObject(Loot loot,int condition, SampSharp.GameMode.Vector3 vector, int world)
        {
            this.loot = loot;
            id = lootIdentifier;
            lootIdentifier++;
            position = vector;
            rotation = loot.rotation;
            this.condition = condition;
            DynamicObject = new DynamicObject(loot.modelId, new SampSharp.GameMode.Vector3(vector.X, vector.Y, vector.Z - 0.9), worldid: world);
            DynamicObject.ShowInWorld(world);
            Label = new DynamicTextLabel($"{{bfbfbf}}{loot.Name} {{ff9933}}[F]", 0, new SampSharp.GameMode.Vector3(vector.X, vector.Y, vector.Z - 0.8), 30.0f);
            Label.ShowInWorld(world);


        }
        public static void Create(Loot loot,int condition, SampSharp.GameMode.Vector3 vector, int world)
        {
            loots.Add(new PlayerLootObject(loot,condition,vector,world));
            
        }
        public static void Reloot()
        {
            
        }
        public static void Take(Player p)
        {
            var dropDialog = new ListDialog("Предмет", "Взять", "Отмена");
            Dictionary<int, PlayerLootObject> dialogDic = new Dictionary<int, PlayerLootObject>();
            int index = 0;
            if (loots.Count < 1) return;
            foreach (PlayerLootObject l in  loots)
            {
                if (p.IsInRangeOfPoint(3, l.position))
                {
                    dialogDic.Add(index, l);
                    dropDialog.AddItem(l.loot.Name);
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
                            for (int j = 0; j < p.inventory.slotsItem.Length; j++)
                            {
                                if (p.inventory.slotsItem[j].loot == null)
                                {

                                    if (dialogDic[i].isTaked == false)
                                    {
                                        p.SendClientMessage($"{{B1BA24}}Подобрано: {{177B3D}}{dialogDic[i].loot.Name}");
                                        p.inventory.slotsItem[j] = new Display.InventoryLoot(dialogDic[i].loot, dialogDic[i].condition);
                                        /**
                                        p.inventory.slots[j].ItemId = dialogDic[i].id;
                                        p.inventory.slots[j].Td.PreviewModel = dialogDic[i].previewModelId;
                                        p.inventory.slots[j].Td.PreviewRotation = new SampSharp.GameMode.Vector3(p.inventory.slots[j].Td.PreviewRotation.X, dialogDic[i].rotation, p.inventory.slots[j].Td.PreviewRotation.Z);
                                        **/
                                        
                                        loots.Find(item => item.id == dialogDic[i].id).isTaked = true;
                                        loots.Find(item => item.id == dialogDic[i].id).Delete();
                                        
                                        loots.Remove(dialogDic[i]);
                                        p.inventory.currentWeight += dialogDic[i].loot.weight;
                                        dialogDic.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        p.SendClientMessage("{8A1717}Данный предмет уже подобрал другой человек.");
                                        p.ClearAnimations(true);
                                        break;
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
        /**
        public static void AddtoInventory(Player p, Loot loot)
        {
            for (int j = 0; j < p.inventory.slotsItem.Length; j++)
            {
                if (p.inventory.slots[j].Item == null)
                { 
                        p.inventory.slots[j].ItemId = lootId;
                        p.inventory.slots[j].Td.PreviewModel = Loot.loots.Find(w => w.Id == lootId).previewModelId;
                        p.inventory.slots[j].Td.PreviewRotation = Loot.loots.Find(w => w.Id == lootId).rotation;


                    p.inventory.currentWeight += Loot.loots.Find(w => w.Id == lootId).weight;
                        
                        break;
                }
                    

                
            }
        }
        **/
        public void Delete()
        {
            DynamicObject.Dispose();
            DynamicObject = null;
            Label.Dispose();
            Label = null;
        }

    }
}

using SampSharp.GameMode.Pools;
using SampSharp.GameMode.World;
using SampSharp.GameMode;
using System;
using WasteLandWarriors.Display;
using SampSharp.GameMode.SAMP.Commands;
using SampSharp.GameMode.Events;
using WasteLandWarriors.WorldObjects;
using WasteLandWarriors.Others;

namespace WasteLandWarriors
{
    [PooledType]
    public class Player : BasePlayer
    {
        public Inventory inventory;
        PlayerMappingObjects mapping;
        Logo logo;
        PlayerInterface playerInterface;
        public override void OnConnected(EventArgs e)
        {
            
            base.OnConnected(e);
            playerInterface = new PlayerInterface(this);
            playerInterface.Create();
            logo = new Logo(this);
            logo.Show();
            inventory = new Inventory(this);
            WorldMapZones.Create(this);
            mapping = new PlayerMappingObjects(this);
            mapping.Remove();
            mapping.CreateNShow();

            SendClientMessage("Welcome to blank game mode by your name here!");
        }
        public override void OnSpawned(SpawnEventArgs e)
        {
            base.OnSpawned(e);
            playerInterface.Show();
        }

        [Command("Open")]
        public void OpenInventory()
        {
            inventory.Show();
        }
        [Command("CreateItem")]
        public void CreateItem(int id)
        {
            Loot s = Loot.loots.Find(s => s.Id == id);
            PlayerLootObject.Create(s,this.Position,this.VirtualWorld);
        }
        public override void OnCancelClickTextDraw(PlayerEventArgs e)
        {
            base.OnCancelClickTextDraw(e);
            inventory.Close();

        }
        public override void OnClickMap(PositionEventArgs e)
        {
            base.OnClickMap(e);
            this.Position = e.Position;

        }

    }
}
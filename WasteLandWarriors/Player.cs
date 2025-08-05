using SampSharp.GameMode;
using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.Pools;
using SampSharp.GameMode.SAMP.Commands;
using SampSharp.GameMode.World;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Timers;
using WasteLandWarriors.Display;
using WasteLandWarriors.Entities;
using WasteLandWarriors.NPC.WorldNPCs;
using WasteLandWarriors.Others;
using WasteLandWarriors.WorldObjects;
using WasteLandWarriors.Services;


namespace WasteLandWarriors
{
    [PooledType]
    public class Player : BasePlayer
    {
        ConstuctionsService constructor = new ConstuctionsService();
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
            this.ClearAnimations();
        }
        
        
        public override void OnSpawned(SpawnEventArgs e)
        {
            base.OnSpawned(e);
            playerInterface.Show();
            Time.Show(this);
            this.SetSpawnInfo(0, 285, new SampSharp.GameMode.Vector3(2177.5847, 1584.5847, 1000), 270f);
            this.Interior = 1;
            this.VirtualWorld = 1010;
            this.PutCameraBehindPlayer();
            
        }
        [Command("Music")]
        public void GetMusic()
        {
            this.PlayAudioStream("https://rux.muzmo.cc/get/cuts/b2/6e/b26e7775a9bc5277897608fca18c3250/64348877/John_Murphy_-_28_Theme_b128f0d211.mp3");
        }
        public override void OnDisconnected(DisconnectEventArgs e)
        {
            base.OnDisconnected(e);
            Time.Hide(this);
            this.Dispose();
        }
        [Command("gotopos")]
        public void gotopos(int x, int y, int z, int world, int interior)
        {
            this.Position = new SampSharp.GameMode.Vector3(x,y,z);
            this.VirtualWorld = world;
            this.Interior = interior;
            this.SetTime(12, 00);
            this.SetWeather(20);
        }
        [Command("Construction")]
        public void CreateItem(ConstructionType type)
        {
            constructor.Create(this,type , this.Position, new Vector3(0,0,0));
        }
        [Command("getpos")]
        public void getpos(string info)
        {
            string s = this.Position.ToString() + " " + info;
            SendClientMessage(s);
            using (StreamWriter sw = new StreamWriter("positions.txt", true))
            {
                
                sw.WriteLine(s);
                sw.Close();
            }
        }
        [Command("spawnloots")]
        public void SpawnLoots()
        {
            WorldLootSpawnpoints.SpawnLoot();
        }
        [Command("weapon")]
        public void weapon(Weapon weapon, int Ammo)
        {
            this.GiveWeapon(weapon,Ammo);
        }
        public override void OnDeath(DeathEventArgs e)
        {
            base.OnDeath(e);
            
            this.RemoveAttachedObject(1);
            
            this.inventory.currentWeight = 0;
            inventory.DropAllLoot();
            this.inventory.Clear();


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
            PlayerLootObject.Create(s,new SampSharp.GameMode.Vector3(this.Position.X,this.Position.Y,this.Position.Z-0.05),this.VirtualWorld);
        }
        public override void OnKeyStateChanged(KeyStateChangedEventArgs e)
        {
            base.OnKeyStateChanged(e);
            if (e.NewKeys == Keys.SecondaryAttack)
            {
                PlayerLootObject.Take(this);

            }
            if (e.NewKeys == Keys.Yes)
            {
                inventory.Show();

            }
        }
        public override void OnWeaponShot(WeaponShotEventArgs e)
        {
            base.OnWeaponShot(e);
            if(e.Weapon == Weapon.M4)
            {
                this.inventory.weaponslotsAmmoNum[5]--;
            }
            if (e.Weapon == Weapon.Deagle)
            {
                this.inventory.weaponslotsAmmoNum[0]--;
            }
        }
        public override void OnRequestClass(RequestClassEventArgs e)
        {
            base.OnRequestClass(e);
            Events.Authorization.ShowAuth(this);
        }
        public override void OnClickPlayerTextDraw(ClickPlayerTextDrawEventArgs e)
        {
            base.OnClickPlayerTextDraw(e);

            inventory.CloseButton(e);
            inventory.Select(e);
            inventory.Use(e);
            inventory.Info(e);
            inventory.Drop(e);
            inventory.OnClickHelmet(e);
            inventory.OnClickBackpack(e);
            inventory.OnclickArmour(e);
        }
        [Command("Skin")]
        public void SetSkin(int id)
        {
            this.Skin = id;
        }
        public override void OnTakeDamage(DamageEventArgs e)
        {
            SendClientMessage("debug");
            base.OnTakeDamage(e);
            var current = e.Amount;
            if(this.inventory.ArmorSlot != 0 &&  this.Armour - current <= 0)
            {
                SendClientMessage("debug2");
                this.inventory.ArmorSlot = 0;
            }
        }
        
        [Command("spawnCar")]
        private void MakeCar(VehicleModelType vh, float carHp)
        {
            if (carHp <= 50000)
            {
                var sv = BaseVehicle.Create(vh, this.Position, this.Angle, 1, 1, 1800, false);
                sv.Health = carHp;
                sv.Engine = true;
                sv.AddComponent(1010);
                int cSet = sv.Id;
                this.PutInVehicle(sv, 0);
            }
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
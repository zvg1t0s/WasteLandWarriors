using SampSharp.Core.Natives.NativeObjects;
using SampSharp.GameMode;
using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Display;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.Pools;
using SampSharp.GameMode.SAMP.Commands;
using SampSharp.GameMode.World;
using SampSharp.Streamer;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using WasteLandWarriors.AC;
using WasteLandWarriors.Display;
using WasteLandWarriors.Entities;
using WasteLandWarriors.NPC.WorldNPCs;
using WasteLandWarriors.Others;
using WasteLandWarriors.Services;
using WasteLandWarriors.Systems;
using WasteLandWarriors.Systems.BiomeGenerator;
using WasteLandWarriors.WorldObjects;

namespace WasteLandWarriors
{
    [PooledType]
    public class Player : BasePlayer
    {
        ConstuctionsService constructor = new ConstuctionsService();
        public Inventory inventory;
        PlayerMappingObjects mapping;
        Logo logo;
        public PlayerInterface playerInterface;
        public int waterNum = 100;
        public int hungerNum = 100;
       // public int imunNum = 1000;
        public bool isAuth = false;
        public int spichki = 0;
        public int cigarettes = 0;
        public Speedo speedometer;
        public skillmenu skillMenu;
        public diseases diseases;
        public HumanityCounter humanity;
        public PlayerParams parameters;
        public WarmCounter warmCounter;
        public PlayerTimer timer;
        public Weapon currentHeld;
        public User user;
        public override void OnConnected(EventArgs e)
        {

            base.OnConnected(e);
            
            RakcheatNatives.AC_EnableAntiCheat(this.Id, 30, false);
            RakcheatNatives.AC_EnableAntiCheat(this.Id, 39, false);
            RakcheatNatives.AC_EnableAntiCheat(this.Id, 22, false);
            RakcheatNatives.AC_EnableAntiCheat(this.Id, 2, false);
            RakcheatNatives.AC_EnableAntiCheat(this.Id, 11, false);
            RakcheatNatives.AC_EnableAntiCheat(this.Id, 16, false);
            // var instance = NativeObjectProxyFactory.CreateInstance<RakcheatNatives>();
            // Console.Write(instance.EnableAntiCheat(21, false));
            timer = new PlayerTimer();
            
            playerInterface = new PlayerInterface(this);
            playerInterface.Create();
            parameters = new PlayerParams(this);
            logo = new Logo(this);
            logo.Show();
            speedometer = new Speedo(this);
            speedometer.Create();
            skillMenu = new skillmenu(this);
            inventory = new Inventory(this);
            diseases = new diseases(this);
            WorldMapZones.Create(this);
            mapping = new PlayerMappingObjects(this);
            mapping.Remove();
            mapping.CreateNShow();
            this.ClearAnimations();
            //timer.Count(this);
            VehicleManager.UpdateSpeed(this);
            humanity = new HumanityCounter(this);
            warmCounter = new WarmCounter(this);
            this.KeyStateChanged += openCraftMenu;
            
        }
        
        
        
        public override void OnSpawned(SpawnEventArgs e)
        {
            base.OnSpawned(e);
            playerInterface.Show();
            Time.Show(this);
            RakcheatNatives.AC_SetSpawnInfo(this.Id, 0, 285, new SampSharp.GameMode.Vector3(2177.5847, 1584.5847, 1000), 270f);
            this.SetSpawnInfo(0, 285, new SampSharp.GameMode.Vector3(2177.5847, 1584.5847, 1000), 270f);
            RakcheatNatives.AC_setInterior(Id, 1);
            this.Interior = 1;
            this.VirtualWorld = 1010;
            this.SetWeather(20);
            this.PutCameraBehindPlayer();
            this.waterNum = 100;
            this.hungerNum = 100;
            
            
            ClearAnimations();
            


        }
        
        public override void OnStateChanged(StateEventArgs e)
        {
            base.OnStateChanged(e);
            if(e.NewState == PlayerState.Driving)
            {
                speedometer.Show();
                VehicleManager.sendCarInfo(this);
                
            }
            if (e.NewState == PlayerState.OnFoot) {
                speedometer.Hide();
                
            }
            currentHeld = this.Weapon;
        }
        
        
        [Command("dojdik")]
        public void dojdik()
        {
            CampFire.DeleteAll();
        }
        
        
        public override void OnDisconnected(DisconnectEventArgs e)
        {
            
            Time.Hide(this);
            PlayerMappingObjects.DisposeAll(this);
            

            logo = null;

            timer.millsecTimer.Dispose();
            timer = null;
            warmCounter = null;
            
            skillMenu = null;
            inventory = null;
            diseases = null;
            humanity = null;
            mapping = null;
            speedometer = null;
            playerInterface = null;
            this.Dispose();
            base.OnDisconnected(e);


        }
        [Command("gotopos")]
        public void gotopos(int x, int y, int z, int world, int interior)
        {
            this.Position = new SampSharp.GameMode.Vector3(x,y,z);
            RakcheatNatives.AC_SetPlayerPos(this, new Vector3(x,y,z));
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
        [Command("part")]
        public void AddPart(int compid)
        {
            this.Vehicle.AddComponent(compid);
        }

        

        [Command("inv")]
        public void OpenInventory() 
        {
            inventory.Show();
        }
        [Command("CreateItem")]
        public void CreateItem(int id)
        {
            if (id > 0)
            {
                if (id <= Loot.loots.LastOrDefault().Id)
                {
                    Loot s = Loot.loots.FirstOrDefault(s => s.Id == id);
                    PlayerLootObject.Create(s,100, new SampSharp.GameMode.Vector3(this.Position.X, this.Position.Y, this.Position.Z - 0.05), this.VirtualWorld);
                }
                else
                {
                    SendClientMessage($"максимальный индекс лута {Loot.loots.LastOrDefault().Id}");
                }
            }
        }
        [Command("Money")]
        public void Givemoney(int amount)
        {
            //this.GiveMoney(amount);
            AC.RakcheatNatives.AC_SetPlayerMoney(this, amount);
        }
        
        public override void OnKeyStateChanged(KeyStateChangedEventArgs e)
        {
            base.OnKeyStateChanged(e);
            InCarWeaponChange.Change(this, e);
            if (e.NewKeys == Keys.SecondaryAttack)
            {
                
                PlayerLootObject.Take(this);

            }
            if (e.NewKeys == Keys.Yes )
            {
                
                    inventory.Show();
                
            }
            if (e.NewKeys == Keys.No)
            {
                
                    this.SelectTextDraw(100);
                
            }
            if (e.NewKeys == Keys.SecondaryAttack && this.IsInRangeOfPoint(5,new Vector3(1329.4857, 1357.2468, 3001.1155)) )
            {
                Others.Dialogs.ShopDialog.ShowMainDialog(this);
            }
            if(e.NewKeys == Keys.SecondaryAttack)
            {
                CreateBiome.Use(this);
            }
            if(e.NewKeys == Keys.SecondaryAttack && this.IsInRangeOfPoint(5, new Vector3(-196.06013f, 1219.5857f, 19.902187f)))
            {
                CarMechanicSystem.Mechanic(this);
            }
            VehicleManager.StartEngine(e, this);
            
        }
        public override void OnWeaponShot(WeaponShotEventArgs e)
        {
            base.OnWeaponShot(e);
            
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
           // SendClientMessage("debug");
            base.OnTakeDamage(e);
          
            
        }
        
        
        public void openCraftMenu(object sender, KeyStateChangedEventArgs e)
        {
            if (e.NewKeys == SampSharp.GameMode.Definitions.Keys.SecondaryAttack)
            {
                foreach (var tables in CraftTables.craftTables)
                {
                    if (this.IsInRangeOfPoint(5, tables.tablePos))
                    {
                        this.inventory.ShowCraftMenu();
                    }
                }
            }
            if(e.NewKeys == SampSharp.GameMode.Definitions.Keys.CtrlBack && this.parameters.nearCampFire)
            {
                this.inventory.ShowCookingSystem();
            }
        }

        [Command("spawnCar")]
        private void MakeCar(VehicleModelType vh, int carHp)
        {
            /**
            if (carHp <= 50000)
            {
                var sv = BaseVehicle.Create(vh, this.Position, this.Angle, 1, 1, 1800, false);
                sv.Health = carHp;
                sv.Engine = true;
                sv.AddComponent(1010);
                int cSet = sv.Id;
                this.PutInVehicle(sv, 0);
            }
            **/
            var veh = new VehicleEntity(vh, carHp, this.Position);
            VehicleManager.CreateAndSpawn(veh, this.Position);
        }
        [Command("check")]
        public void Check()
        {
            foreach(var car in VehicleEntity.allCars)
            {
                SendClientMessage(car.vehicle.Id.ToString());
            }
        }
        [Command("SPAWNVEG")]
        public void spawnveg()
        {
            CreateBiome.Create();
        }

        public override void OnCancelClickTextDraw(PlayerEventArgs e)
        {
            base.OnCancelClickTextDraw(e);

            if (e.Player == this)
            {
                inventory.Close();
                skillMenu.Close();
            }

        }
        
        public override void OnClickMap(PositionEventArgs e)
        {
            base.OnClickMap(e);
            
            this.Position = e.Position;
            RakcheatNatives.AC_SetPlayerPos(this, e.Position);

        }

    }
}
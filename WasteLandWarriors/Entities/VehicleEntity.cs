using SampSharp.GameMode;
using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.SAMP;
using SampSharp.GameMode.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WasteLandWarriors.AC;
using WasteLandWarriors.Display;

namespace WasteLandWarriors.Entities
{
    public class VehicleEntity 
    {
       // public static Timer speedoTimer = new Timer(120, true);
       // public static Timer fuelTimer = new Timer(10000, true);
        public static int Idd = 1;
        public int Id = 0;
        public BaseVehicle vehicle { get; set; }
        public VehicleModelType ModelType { get; set; }

        public int vehicleId { get; set; }

        public int VehicleHealth { get; set; } = 1000;

        public int Color1 { get; set; } = 0;

        public int Color2 { get; set; } = 0;

        public int[] modifications { get; set; }

        public User Owner { get; set; } = null;

        public int Fuel { get; set; } = 30;

        public int Accum { get; set; } = 0;

        public int Cost { get; set; } = 0;
        public bool isLocked { get; set; } = false;

        public int FrontBumper { get; set; } = 0;

        public int RearBumper { get; set; } = 0;

        public int Hydraulics { get; set; } = 0;

        public int SideSkirts { get; set; } = 0;

        public int Spoiler { get; set; } = 0;

        public int Exhaust { get; set; } = 0;

        public int Wheels { get; set; } = 0;

        public int Nitro { get; set; } = 0;

        public int Hood { get; set; } = 0;
        public int Roof { get; set; } = 0;

        public int Bumper { get; set; } = 0;

        public int PaintJob { get; set; } = 0; 
        public int speed;

        public static List<VehicleEntity> allCars = new List<VehicleEntity>(); 
        
        public VehicleEntity()
        {

        }
        

        public VehicleEntity(VehicleModelType type, int health, Vector3 vector, User user = null, int cost = 1000) {
            this.vehicle = new BaseVehicle();
            ModelType = type;
            VehicleHealth = health;
            Owner = user;
            vehicle.AddComponent(FrontBumper);
            vehicle.AddComponent(RearBumper);
            vehicle.AddComponent(Nitro);
            vehicle.AddComponent(Spoiler);
            vehicle.AddComponent(Wheels);
            vehicle.AddComponent(Hood);
            //vehicle = BaseVehicle.Create(ModelType, vector, 0, 0,0, -1, false);
            // vehicle.Engine = true;
            // RakcheatNatives.AC_SetVehicleHealth(vehicle.Id, (float)health, false);
            // vehicle.Health = VehicleHealth;
            Cost = cost;
            
            

        }
        public void SetOwner(User user)
        {
            Owner = user;
        }
        
        public void ClearOwner()
        {
            Owner = null;
        }

    }
}

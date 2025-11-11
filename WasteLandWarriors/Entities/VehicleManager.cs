using SampSharp.GameMode;
using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.SAMP;
using SampSharp.GameMode.World;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using WasteLandWarriors.NPC.Definitions;

namespace WasteLandWarriors.Entities
{
    public class VehicleManager
    {

        public static Timer speedoTimer = new Timer(120, true);
        public static Timer fuelTimer = new Timer(10000, true);

        public static Dictionary<int, VehicleEntity> _vehicles = new Dictionary<int, VehicleEntity>();

        public static VehicleEntity CreateVehicle(VehicleEntity veh)
        {
            //var v = new VehicleEntity(type, health, vector, user, cost);
            _vehicles[veh.Id] = veh;
            return veh;

        }
        public static bool SpawnVehicle(VehicleEntity entity, Vector3 position)
        {
            if (entity == null) return false;

            entity.vehicle = BaseVehicle.Create(entity.ModelType, position, 0, 0, 0, -1, false);
            entity.vehicle.ChangeColor(entity.Color1, entity.Color2);
            entity.vehicle.Health = entity.VehicleHealth;


            return true;
        }

        public static VehicleEntity CreateAndSpawn(VehicleEntity veh, Vector3 pos)
        {
            var e = CreateVehicle(veh);
            SpawnVehicle(e, pos);
            return e;

        }

        public static bool DeleteVehicle(VehicleEntity entity)
        {
            if (entity == null || entity.vehicle.IsDisposed) return false;

            entity.vehicle.Dispose();
            return true;

        }

        public static bool RespawnVehicle(VehicleEntity entity)
        {
            if(entity == null) return false;
            entity.vehicle.Respawn();
            return true;
        }

        public static double GetSpeed(Player p)
        {
            var velocity = new Vector3();
            if (p.IsDisposed) return 0;

            else if (p.Vehicle != null)
            {
                float x = 0;
                float y = 0;
                float z = 0;
                BaseVehicle.VehicleInternal.Instance.GetVehicleVelocity(BasePlayer.PlayerInternal.Instance.GetPlayerVehicleID(p.Id), out x, out y, out z);
                velocity = new Vector3(x, y, z);


            }
            else { velocity = p.Velocity; }

            return Math.Sqrt(Math.Pow(Math.Abs(velocity.X), 2) + Math.Pow(Math.Abs(velocity.Y), 2) + Math.Pow(Math.Abs(velocity.Z), 2)) * 100.3;

        }

        public static void UpdateFuel()
        {

            fuelTimer.Tick += OnFuelTimedEvent;


            void OnFuelTimedEvent(object sender, EventArgs e)
            {
                foreach (var cars in _vehicles.ToList())
                {


                    if (cars.Value.vehicle.Engine && cars.Value.Fuel > 0)
                    {
                        cars.Value.Fuel -= 1;
                        if (cars.Value.Fuel <= 0)
                        {
                            cars.Value.vehicle.Engine = false;
                        }
                    }

                }
            }
        }
        public static void sendCarInfo(Player p)
        {
            if (_vehicles.Values.FirstOrDefault(v => v.vehicle.Id == p.Vehicle.Id).Fuel <= 0)
            {
                p.SendClientMessage("{8C0000}Отсутствует топливо.");
            }
            if (_vehicles.Values.FirstOrDefault(v => v.vehicle.Id == p.Vehicle.Id).Accum <= 0)
            {
                p.SendClientMessage("{8C0000}Отсутствует аккумулятор.");
            }
        }
        public static void UpdateSpeed(Player p)
        {
            speedoTimer.Tick += OnSpeedoUpdateEvent;
            void OnSpeedoUpdateEvent(object sender, EventArgs e)
            {
                int vehId = BaseVehicle.FindOrCreate(BasePlayer.PlayerInternal.Instance.GetPlayerVehicleID(p.Id)).Id;
                var inst = _vehicles.Values.FirstOrDefault(v => v.vehicle.Id == vehId, null);
                int fuel = 0;
                if (p.IsDisposed || p.speedometer == null)
                {
                    speedoTimer.Tick -= OnSpeedoUpdateEvent;
                    return;
                }

                if (inst != null)
                {
                    fuel = inst.Fuel;
                }
                if (fuel > 25)
                {
                    p.speedometer.Fuel.ForeColor = 16711935;
                }
                if (fuel <= 25 && fuel > 10)
                {
                    p.speedometer.Fuel.ForeColor = -2686721;

                }
                if (fuel <= 10)
                {
                    p.speedometer.Fuel.ForeColor = -1962934017;

                }
                p.speedometer.Speedometer.Text = $"{Convert.ToInt32(GetSpeed(p))}_km/h";
            }

        }
        public static void StartEngine(KeyStateChangedEventArgs e, Player p)
        {
            if (e.NewKeys == Keys.Action && p.InAnyVehicle && !p.Vehicle.Engine && _vehicles.Values.FirstOrDefault(v => v.vehicle.Id == p.Vehicle.Id).Fuel > 0)
            {
                p.Vehicle.Engine = true;

            }
            else if (e.NewKeys == Keys.Action && p.InAnyVehicle && _vehicles.Values.FirstOrDefault(v => v.vehicle.Id == p.Vehicle.Id).Fuel <= 0)
            {
                p.SendClientMessage("{8C0000}Отсутствует топливо.");
            }
            else if (e.NewKeys == Keys.Action && p.InAnyVehicle)
            {
                p.Vehicle.Engine = false;
            }
        }
        public static VehicleEntity FindClosedCar(Player p, float range)
        {
            foreach (var car in _vehicles.Values.ToList())
            {
                if (p.IsInRangeOfPoint(range, car.vehicle.Position))
                {
                    return car;

                }

            }
            return null;

        }
        public static VehicleEntity FindClosestCar(Vector3 pos, float range)
        {
            foreach (var car in _vehicles.Values.ToList())
            {
                if (pos.DistanceTo(car.vehicle.Position) <= range)
                {
                    return car;

                }

            }
            return null;
        }

        public static void CreateWorldCars()
        {
            CreateAndSpawn(new VehicleEntity(VehicleModelType.Sentinel,1000, new Vector3(103.3748, 1043.7207, 13.490233), null, 15000), new Vector3(103.3748, 1043.7207, 13.490233));
        }
    }

}

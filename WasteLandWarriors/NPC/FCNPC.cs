
using SampSharp.Core.Natives.NativeObjects;
using SampSharp.GameMode;
using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.Pools;
using SampSharp.GameMode.World;
using SampSharpGameMode1.Physics;
using System;
using WasteLandWarriors.NPC.Definitions;
namespace WasteLandWarriors.NPC
{
    
    public partial class FCNPC : IdentifiedPool<FCNPC>, IWorldObject
    {
        public const int IncludeVersion = 207;
        public const int MaxNodes = 64;
        public const int InvalidMovePathId = -1;
        public const int InvalidRecordId = -1;

        public static int UpdateRate
        {
            get => _internal.GetUpdateRate();
            set => _internal.SetUpdateRate(value);
        }
        public static int TickRate
        {
            get => _internal.GetTickRate();
            set => _internal.SetTickRate(value);
        }

        
        public BasePlayer Player
        {
            get
            {
                AssertNotDisposed();
                return BasePlayer.Find(Id);
            }
        }
        public string Name
        {
            get
            {
                AssertNotDisposed();
                return BasePlayer.Find(Id)?.Name;
            }
            set
            {
                AssertNotDisposed();
                BasePlayer.Find(Id).Name = value;
            }
        }
        public bool IsSpawned
        {
            get
            {
                AssertNotDisposed();
                return _internal.IsSpawned(Id);
            }
        }

        public bool IsDead
        {
            get
            {
                AssertNotDisposed();
                return _internal.IsDead(Id);
            }
        }

        public bool IsValid
        {
            get
            {
                AssertNotDisposed();
                return _internal.IsValid(Id);
            }
        }

        public bool IsStreamedInForAnyone
        {
            get
            {
                AssertNotDisposed();
                return _internal.IsStreamedInForAnyone(Id);
            }
        }
        public Vector3 Position
        {
            get
            {
                AssertNotDisposed();
                _internal.FCNPC_GetPosition(Id, out float x, out float y, out float z);
                return new Vector3(x, y, z);
            }
            set
            {
                AssertNotDisposed();
                _internal.FCNPC_SetPosition(Id, value.X, value.Y, value.Z);
            }
        }
        public void GivePosition(Vector3 pos)
        {
            AssertNotDisposed();
            _internal.FCNPC_GivePosition(Id,pos.X,pos.Y,pos.Z);
        }
        public float Angle
        {
            get
            {
                AssertNotDisposed();
                return _internal.FCNPC_GetAngle(Id);
            }
            set
            {
                AssertNotDisposed();
                _internal.FCNPC_SetAngle(Id, value);
            }
        }
             public Quaternion Quaternion
            {
            get
            {
                AssertNotDisposed();
                _internal.FCNPC_GetQuaternion(Id, out float w, out float x, out float y, out float z);
                return new Quaternion(x, y, z, w);
            }
            set
            {
                AssertNotDisposed();
                _internal.FCNPC_SetQuaternion(Id, value.W, value.X, value.Y, value.Z);
            }

        }
        public Vector3 Velocity
        {
            get
            {
                AssertNotDisposed();
                _internal.FCNPC_GetVelocity(Id, out float x, out float y, out float z);
                return new Vector3(x, y, z);
            }
            set
            {
                AssertNotDisposed();
                _internal.FCNPC_SetVelocity(Id, value.X, value.Y, value.Z);
            }
        }

        public float Speed
        {
            get
            {
                AssertNotDisposed();
                return _internal.FCNPC_GetSpeed(Id);
            }
            set
            {
                AssertNotDisposed();
                _internal.FCNPC_SetSpeed(Id, value);
            }
        }

        public int Interior
        {
            get
            {
                AssertNotDisposed();
                return _internal.FCNPC_GetInterior(Id);
            }
            set
            {
                AssertNotDisposed();
                _internal.FCNPC_SetInterior(Id, value);
            }
        }
        public int VirtualWorld
        {
            get
            {
                AssertNotDisposed();
                return _internal.FCNPC_GetVirtualWorld(Id);
            }
            set
            {
                AssertNotDisposed();
                _internal.FCNPC_SetVirtualWorld(Id, value);
            }
        }

        public float Health
        {
            get
            {
                AssertNotDisposed();
                return _internal.FCNPC_GetHealth(Id);
            }
            set
            {
                AssertNotDisposed();
                _internal.FCNPC_SetHealth(Id, value);
            }
        }
        public float Armour
        {
            get
            {
                AssertNotDisposed();
                return _internal.FCNPC_GetArmour(Id);
            }
            set
            {
                AssertNotDisposed();
                _internal.FCNPC_SetArmour(Id, value);
            }
        }
        public bool IsInvulnerable
        {
            get
            {
                AssertNotDisposed();
                return _internal.FCNPC_IsInvulnerable(Id);
            }
            set
            {
                AssertNotDisposed();
            }
        }

        public int Skin
        {
            get
            {
                AssertNotDisposed();
                return _internal.GetSkin(Id);
            }
            set
            {
                AssertNotDisposed();
                _internal.SetSkin(Id, value);
            }
        }
        public Weapon Weapon
        {
            get
            {
                AssertNotDisposed();
                return (Weapon)_internal.GetWeapon(Id);
            }
            set
            {
                AssertNotDisposed();
                _internal.SetWeapon(Id, (int)value);
            }
        }
        public int Ammo
        {
            get
            {
                AssertNotDisposed();
                return _internal.GetAmmo(Id);
            }
            set
            {
                AssertNotDisposed();
                _internal.SetAmmo(Id, value);
            }
        }
        public int AmmoInClip
        {
            get
            {
                AssertNotDisposed();
                return _internal.GetAmmoInClip(Id);
            }
            set
            {
                AssertNotDisposed();
                _internal.SetAmmoInClip(Id, value);
            }
        }
        public WeaponState WeaponState
        {
            get
            {
                AssertNotDisposed();
                return (WeaponState)_internal.GetWeaponState(Id);
            }
            set
            {
                AssertNotDisposed();
                _internal.SetWeaponState(Id, (int)value);
            }
        }

        public Vector3 DestinationPoint
        {
            get
            {
                AssertNotDisposed();
                _internal.GetDestinationPoint(Id, out float x, out float y, out float z);
                return new Vector3(x, y, z);
            }
        }

        public FightStyle FightStyle
        {
            get
            {
                AssertNotDisposed();
                return (FightStyle)_internal.GetFightingStyle(Id);
            }
            set
            {
                AssertNotDisposed();
                _internal.SetFightingStyle(Id, (int)value);
            }
        }
        public bool IsMoving
        {
            get
            {
                AssertNotDisposed();
                return _internal.IsMoving(Id);
            }
        }

        public bool IsAttacking
        {
            get
            {
                AssertNotDisposed();
                return _internal.IsAttacking(Id);
            }
        }
        public bool MeleeAttack(int delay = -1, bool useFightStyle = false)
        {
            AssertNotDisposed();
            return _internal.MeleeAttack(Id, delay, useFightStyle);
        }

        public Vector3 SurfingOffsets
        {
            get
            {
                AssertNotDisposed();
                _internal.GetSurfingOffsets(Id, out float x, out float y, out float z);
                return new Vector3(x, y, z);
            }
            set
            {
                AssertNotDisposed();
                _internal.SetSurfingOffsets(Id, value.X, value.Y, value.Z);
            }
        }

        public PlayerObject SurfingPlayerObject
        {
            get
            {
                AssertNotDisposed();
                return PlayerObject.Find(Player, _internal.GetSurfingPlayerObject(Id));
            }
            set
            {
                AssertNotDisposed();
                _internal.SetSurfingPlayerObject(Id, value.Id);
            }
        }
        public MoveMode SetMoveMode
        {

            set
            {
                AssertNotDisposed();
                _internal.FCNPC_SetMoveMode(Id, (int)value);
            }
            get
            {
                AssertNotDisposed();
                return (MoveMode)_internal.FCNPC_GetMoveMode(Id);
            }
        }
        //ctor
        public FCNPC() { }

        public event EventHandler Created;
        public event EventHandler Destroyed;
        public event EventHandler Spawned;
        public event EventHandler Respawned;
        public event EventHandler<DeathEventArgs> Died;

        //
       //public event EventHandler<VehicleEntryEventArgs> VehicleEntryCompleted;
        public event EventHandler VehicleExitCompleted;

        //
        public event EventHandler DestinationReached;
        public event EventHandler PlaybackFinished;

        //
        public event EventHandler<DamageEventArgs> TakeDamage;
        public event EventHandler<DamageEventArgs> GiveDamage;

        //public event EventHandler<VehicleTakeDamageEventArgs> VehicleTakeDamage;
        public event EventHandler<WeaponShotEventArgs> WeaponShot;
        //public event EventHandler<WeaponStateChangedEventArgs> WeaponStateChanged;

        /**
        public event EventHandler<NodePointFinishedEventArgs> NodePointFinished;
        public event EventHandler<NodeChangedEventArgs> NodeChanged;
        public event EventHandler NodeFinished;
        **/
        //
        public event EventHandler<PlayerEventArgs> StreamedIn;
        public event EventHandler<PlayerEventArgs> StreamedOut;

        //
        public event EventHandler<PlayerUpdateEventArgs> Update;

        //
        /**
        public event EventHandler<MovePathFinishedEventArgs> MovePathFinished;
        public event EventHandler<MovePathPointFinishedEventArgs> MovePathPointFinished;

        //
        public event EventHandler<HeightPositionChangedEventArgs> HeightPositionChanged;
        **/

        public static FCNPC Create(string name)
        {
            return Create(_internal.Create(name));
        }
        protected override void Dispose(bool disposing)
        {
            if (IsValid)
                _internal.Destroy(Id);

            base.Dispose(disposing);
        }
        public bool Equals(FCNPC other)
        {
            return this.Id == other.Id;
        }

        public int CompareTo(FCNPC other)
        {
            return this.Id - other.Id;
        }

        //
        public override string ToString()
        {
            return $"{Name} ({Id})";
        }

        public bool Spawn(int skinid, Vector3 position)
        {
            AssertNotDisposed();
            return _internal.Spawn(Id, skinid, position.X, position.Y, position.Z);
        }
        public bool Respawn()
        {
            AssertNotDisposed();
            return _internal.Respawn(Id);
        }

        public bool Kill()
        {
            AssertNotDisposed();
            return _internal.Kill(Id);
        }

        public bool SetAngleToPos(float x, float y)
        {
            AssertNotDisposed();
            return _internal.FCNPC_SetAngleToPos(Id, x, y);
        }

        public bool SetAngleToPlayer(BasePlayer player)
        {
            AssertNotDisposed();
            return _internal.FCNPC_SetAngleToPlayer(Id, player.Id);

        }


        /**
native FCNPC_GoTo(npcid, Float:x, Float:y, Float:z, type = FCNPC_MOVE_TYPE_AUTO, Float:speed = FCNPC_MOVE_SPEED_AUTO, mode = FCNPC_MOVE_MODE_AUTO, pathfinding = FCNPC_MOVE_PATHFINDING_AUTO, Float:radius = 0.0, bool:set_angle = true, Float:min_distance = 0.0, stop_delay = 250);
native FCNPC_GoToPlayer(npcid, playerid, type = FCNPC_MOVE_TYPE_AUTO, Float:speed = FCNPC_MOVE_SPEED_AUTO, mode = FCNPC_MOVE_MODE_AUTO, pathfinding = FCNPC_MOVE_PATHFINDING_AUTO, Float:radius = 0.0, bool:set_angle = true, Float:min_distance = 0.0, Float:dist_check = 1.5, stop_delay = 250);
**/
        //int npcid, float x, float y, float z, int type = (int)Definitions.MoveType.Auto, float speed = Definitions.MoveSpeed.Auto,int movemode = (int)MoveMode.Auto, int pathfinding = (int)Definitions.PathFinding.Auto, float radius = 0f, bool setangle = true, float min_dist = 0f, int stopdelay = 250
        public bool GoTo(Vector3 position, int type = (int)Definitions.MoveType.Auto, float speed = Definitions.MoveSpeed.Auto, int movemode = (int)MoveMode.Auto, int pathfinding = (int)Definitions.PathFinding.Auto, float radius = 0f, bool setangle = true, float dist_offset = 0f, int stopdelay = 250)
        {
            AssertNotDisposed();
            return _internal.GoTo(
                Id,
                position.X,
                position.Y,
                position.Z,
                (int)type,
                speed,
                movemode,
                pathfinding,
                radius,
                setangle,
                dist_offset,
                stopdelay
            );
        }
        public bool GoTo(BasePlayer player, int type = (int)Definitions.MoveType.Auto, float speed = Definitions.MoveSpeed.Auto, int movemode = (int)MoveMode.Auto, int pathfinding = (int)Definitions.PathFinding.Auto, float radius = 0f, bool setangle = true, float dist_offset = 0f, int stopdelay = 250)
        {
            AssertNotDisposed();
            return _internal.GoToPlayer(
                Id,
                player.Id,
                (int)type,
                speed,
                movemode,
                pathfinding,
                radius,
                setangle,
                dist_offset,
                stopdelay
            );
        }

    }

}

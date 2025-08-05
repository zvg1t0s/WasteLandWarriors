using SampSharp.Core.Natives;
using SampSharp.Core.Natives.NativeObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using SampSharp.GameMode;
using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.Pools;
using SampSharp.GameMode.World;

using WasteLandWarriors.NPC.Definitions;

namespace WasteLandWarriors.NPC
{
    public partial class FCNPC
    {
        private static readonly FCNPCInternal _internal;

        static FCNPC()
        {
            _internal = NativeObjectProxyFactory.CreateInstance<FCNPCInternal>();


        }

        internal static void OnCreate(int npcid)
        {
            var fcnpc = Find(npcid);
            fcnpc?.Created?.Invoke(fcnpc, EventArgs.Empty);
        }

        internal static void OnDestroy(int npcid)
        {
            var fcnpc = Find(npcid);
            fcnpc?.Destroyed?.Invoke(fcnpc, EventArgs.Empty);
        }

        internal static void OnSpawn(int npcid)
        {
            var fcnpc = Find(npcid);
            fcnpc?.Spawned?.Invoke(fcnpc, EventArgs.Empty);
        }

        internal static void OnRespawn(int npcid)
        {
            var fcnpc = Find(npcid);
            fcnpc?.Respawned?.Invoke(fcnpc, EventArgs.Empty);
        }

        internal static void OnDeath(int npcid, int killerid, int weaponid)
        {
            var fcnpc = Find(npcid);
            var args = new DeathEventArgs(BasePlayer.Find(killerid), (Weapon)weaponid);
            fcnpc?.Died?.Invoke(fcnpc, args);
        }
        /**
        internal static void OnVehicleEntryComplete(int npcid, int vehicleid, int seatid)
        {
            var fcnpc = Find(npcid);
            var args = new VehicleEntryEventArgs()
            {
                Vehicle = BaseVehicle.Find(vehicleid),
                Seat = seatid
            };
            fcnpc?.VehicleEntryCompleted?.Invoke(fcnpc, args);
        }
        **/
        internal static void OnVehicleExitComplete(int npcid)
        {
            var fcnpc = Find(npcid);
            fcnpc?.VehicleExitCompleted?.Invoke(fcnpc, EventArgs.Empty);
        }

        internal static void OnReachDestination(int npcid)
        {
            var fcnpc = Find(npcid);
            fcnpc?.DestinationReached?.Invoke(fcnpc, EventArgs.Empty);
        }

        internal static void OnFinishPlayback(int npcid)
        {
            var fcnpc = Find(npcid);
            fcnpc?.PlaybackFinished?.Invoke(fcnpc, EventArgs.Empty);
        }

        internal static void OnTakeDamage(int npcid, int damagerid, int weaponid, int bodyPart, float healthLoss)
        {
            var fcnpc = Find(npcid);
            var args = new DamageEventArgs(BasePlayer.Find(damagerid), healthLoss, (Weapon)weaponid, (BodyPart)bodyPart);
            fcnpc?.TakeDamage?.Invoke(fcnpc, args);
        }

        internal static void OnGiveDamage(int npcid, int damagedid, int weaponid, int bodyPart, float healthLoss)
        {
            var fcnpc = Find(npcid);
            var args = new DamageEventArgs(BasePlayer.Find(damagedid), healthLoss, (Weapon)weaponid, (BodyPart)bodyPart);
            fcnpc?.GiveDamage?.Invoke(fcnpc, args);
        }
        /**
        internal static void OnVehicleTakeDamage(int npcid, int damagerid, int vehicleid, int weaponid, float x, float y, float z)
        {
            var fcnpc = Find(npcid);
            var args = new VehicleTakeDamageEventArgs()
            {
                Damager = BasePlayer.Find(damagerid),
                Vehicle = BaseVehicle.Find(vehicleid),
                Weapon = (Weapon)weaponid,
                Position = new Vector3(x, y, z)
            };
            fcnpc?.VehicleTakeDamage?.Invoke(fcnpc, args);
        }
        **/
        internal static bool OnWeaponShot(int npcid, int weaponid, int hittype, int hitid, float x, float y, float z)
        {
            var fcnpc = Find(npcid);
            var args = new WeaponShotEventArgs((Weapon)weaponid, (BulletHitType)hittype, hitid, new Vector3(x, y, z));
            fcnpc?.WeaponShot?.Invoke(fcnpc, args);
            return !args.PreventDamage;
        }

        /**
        internal static void OnWeaponStateChange(int npcid, int weapon_state)
        {
            var fcnpc = Find(npcid);
            var args = new WeaponStateChangedEventArgs()
            {
                WeaponState = (WeaponState)weapon_state
            };
            fcnpc?.WeaponStateChanged?.Invoke(fcnpc, args);
        }
        
        internal static void OnFinishNodePoint(int npcid, int point)
        {
            var fcnpc = Find(npcid);
            var args = new NodePointFinishedEventArgs()
            {
                Point = point
            };
            fcnpc?.NodePointFinished?.Invoke(fcnpc, args);
        }
        
        internal static void OnChangeNode(int npcid, int nodeid)
        {
            var fcnpc = Find(npcid);
            var args = new NodeChangedEventArgs()
            {
                Node = new Node(nodeid)
            };
            fcnpc?.NodeChanged?.Invoke(fcnpc, args);

        }
        
        internal static void OnFinishNode(int npcid)
        {
            var fcnpc = Find(npcid);
            fcnpc?.NodeFinished?.Invoke(fcnpc, EventArgs.Empty);

        }
        **/
        internal static void OnStreamIn(int npcid, int forplayerid)
        {
            var fcnpc = Find(npcid);
            var args = new PlayerEventArgs(BasePlayer.Find(forplayerid));
            fcnpc?.StreamedIn?.Invoke(fcnpc, args);
        }

        internal static void OnStreamOut(int npcid, int forplayerid)
        {
            var fcnpc = Find(npcid);
            var args = new PlayerEventArgs(BasePlayer.Find(forplayerid));
            fcnpc?.StreamedOut?.Invoke(fcnpc, args);
        }

        internal static bool OnUpdate(int npcid)
        {
            var fcnpc = Find(npcid);
            var e = new PlayerUpdateEventArgs();
            fcnpc?.Update?.Invoke(fcnpc, e);
            return !e.PreventPropagation;
        }
        /**
        internal static void OnFinishMovePath(int npcid, int pathid)
        {
            var fcnpc = Find(npcid);
            var args = new MovePathFinishedEventArgs()
            {
                MovePath = MovePath.FindOrCreate(pathid)
            };
            fcnpc?.MovePathFinished?.Invoke(fcnpc, args);
        }
        **/
        /**
        internal static void OnFinishMovePathPoint(int npcid, int pathid, int pointid)
        {
            var fcnpc = Find(npcid);
            var args = new MovePathPointFinishedEventArgs()
            {
                MovePath = MovePath.FindOrCreate(pathid),
                Point = pointid
            };
            fcnpc?.MovePathPointFinished?.Invoke(fcnpc, args);
        }

        // disabled by default, see FCNPC_SetMinHeightPosCall
       
        internal static void OnChangeHeightPos(int npcid, float new_z, float old_z)
        {
            var fcnpc = Find(npcid);
            var args = new HeightPositionChangedEventArgs()
            {
                NewHeight = new_z,
                OldHeight = old_z
            };
            fcnpc?.HeightPositionChanged?.Invoke(fcnpc, args);

        }
        **/
        public class FCNPCInternal {
            [NativeMethod(Function = "FCNPC_SetUpdateRate")]
            public virtual bool SetUpdateRate(int rate) =>
               throw new NativeNotImplementedException();
            
            [NativeMethod(Function = "FCNPC_GetUpdateRate")]
            public virtual int GetUpdateRate() =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetTickRate")]
            public virtual bool SetTickRate(int rate) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetTickRate")]
            public virtual int GetTickRate() =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_UseMoveMode")]
            public virtual int UseMoveMode(int moveMode) =>
                throw new NativeNotImplementedException();
            /**
            native bool:FCNPC_IsMoveModeUsed(mode);
            native FCNPC_UseMovePathfinding(pathfinding, bool:use = true);
            native bool:FCNPC_IsMovePathfindingUsed(pathfinding);
            native FCNPC_UseCrashLog(bool:use = true);
            native bool:FCNPC_IsCrashLogUsed();
            **/
            [NativeMethod(Function = "FCNPC_IsMoveModeUsed")]
            public virtual bool IsMoveModeUsed(int mode) =>
                throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_UseMovePathfinding")]
            public virtual int UseMovePathfinding(int pathFinding, bool use = true) =>
                throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_IsMovePathfindingUsed")]
            public virtual bool UseMovePathfindingUsed(int pathFinding) =>
                throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_UseCrashLog")]
            public virtual int UseCrashLog(bool use = true) =>
                throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_IsCrashLogUsed")]
            public virtual bool FCNPC_IsCrashLogUsed() =>
                throw new NativeNotImplementedException();
            /**
native FCNPC_
            
            (const name[]);
native FCNPC_Destroy(npcid);
native FCNPC_Spawn(npcid, skinid, Float:x, Float:y, Float:z);
native FCNPC_Respawn(npcid);
native bool:FCNPC_IsSpawned(npcid);
native FCNPC_Kill(npcid);
native bool:FCNPC_IsDead(npcid);
native bool:FCNPC_IsValid(npcid);
native bool:FCNPC_IsStreamedIn(npcid, forplayerid);
native bool:FCNPC_IsStreamedInForAnyone(npcid);
native FCNPC_GetValidArray(npcs[], const size = sizeof(npcs));
**/
            [NativeMethod(Function = "FCNPC_Create")]
            public virtual int Create(string name) =>
                throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_Destroy")]
            public virtual bool Destroy(int id) =>
                throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_Spawn")]
            public virtual bool Spawn(int id, int skinId, float x, float y, float z) =>
                throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_Respawn")]
            public virtual bool Respawn(int id) =>
                throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_IsSpawned")]
            public virtual bool IsSpawned(int id) =>
                throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_Kill")]
            public virtual bool Kill(int id) =>
                throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_IsDead")]
            public virtual bool IsDead(int id) =>
                throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_IsValid")]
            public virtual bool IsValid(int id) =>
                throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_IsStreamedIn")]
            public virtual bool IsStreamedIn(int id, int idfor) =>
                throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_IsStreamedInForAnyone")]
            public virtual bool IsStreamedInForAnyone(int id) =>
                throw new NativeNotImplementedException();
            /**
native FCNPC_SetPosition(npcid, Float:x, Float:y, Float:z);
native FCNPC_GivePosition(npcid, Float:x, Float:y, Float:z);
native FCNPC_GetPosition(npcid, &Float:x, &Float:y, &Float:z);
native FCNPC_SetAngle(npcid, Float:angle);
native Float:FCNPC_GiveAngle(npcid, Float:angle);
native FCNPC_SetAngleToPos(npcid, Float:x, Float:y);
native FCNPC_SetAngleToPlayer(npcid, playerid);
native Float:FCNPC_GetAngle(npcid);
native FCNPC_SetQuaternion(npcid, Float:w, Float:x, Float:y, Float:z);
native FCNPC_GiveQuaternion(npcid, Float:w, Float:x, Float:y, Float:z);
native FCNPC_GetQuaternion(npcid, &Float:w, &Float:x, &Float:y, &Float:z);
native FCNPC_SetVelocity(npcid, Float:x, Float:y, Float:z, bool:update_pos = false);
native FCNPC_GiveVelocity(npcid, Float:x, Float:y, Float:z, bool:update_pos = false);
native FCNPC_GetVelocity(npcid, &Float:x, &Float:y, &Float:z);
native FCNPC_SetSpeed(npcid, Float:speed);
native Float:FCNPC_GetSpeed(npcid);
native FCNPC_SetInterior(npcid, interiorid);
native FCNPC_GetInterior(npcid);
native FCNPC_SetVirtualWorld(npcid, worldid);
native FCNPC_GetVirtualWorld(npcid);


**/
            /* FCNPC World-Positioning */
            [NativeMethod(Function = "FCNPC_SetPosition")]
            public virtual bool FCNPC_SetPosition(int id, float x, float y, float z) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GivePosition")]
            public virtual bool FCNPC_GivePosition(int id, float x, float y, float z) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetPosition")]
            public virtual bool FCNPC_GetPosition(int id,out float x,out float y,out float z) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetAngle")]
            public virtual bool FCNPC_SetAngle(int id, float angle) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GiveAngle")]
            public virtual float FCNPC_GiveAngle(int id, float angle) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetAngleToPos")]
            public virtual bool FCNPC_SetAngleToPos(int id, float x, float y) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetAngleToPlayer")]
            public virtual bool FCNPC_SetAngleToPlayer(int id, int playerid) =>
                throw new NativeNotImplementedException();
            
                [NativeMethod(Function = "FCNPC_GetAngle")]
            public virtual float FCNPC_GetAngle(int id) =>
                throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_SetQuaternion")]
            public virtual bool FCNPC_SetQuaternion(int id, float w, float x , float y, float z) =>
            throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_GiveQuaternion")]
            public virtual bool FCNPC_GiveQuaternion(int id, float w, float x, float y, float z) =>
            throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_GetQuaternion")]
            public virtual bool FCNPC_GetQuaternion(int id,out float w,out float x,out float y,out float z) =>
            throw new NativeNotImplementedException();
            
            [NativeMethod(Function = "FCNPC_SetVelocity")]
            public virtual bool FCNPC_SetVelocity(int id, float x, float y, float z, bool update_pos = false) =>
            throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_GiveVelocity")]
            public virtual bool FCNPC_GiveVelocity(int id, float x, float y, float z, bool update_pos = false) =>
            throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_GetVelocity")]
            public virtual bool FCNPC_GetVelocity(int id, out float x,out float y,out float z) =>
            throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_SetSpeed")]
            public virtual bool FCNPC_SetSpeed(int id, float speed) =>
            throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_GetSpeed")]
            public virtual float FCNPC_GetSpeed(int id) =>
            throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_SetInterior")]
            public virtual bool FCNPC_SetInterior(int id, int interiorId) =>
            throw new NativeNotImplementedException();
            
            [NativeMethod(Function = "FCNPC_GetInterior")]
            public virtual int FCNPC_GetInterior(int id) =>
            throw new NativeNotImplementedException();
            
            [NativeMethod(Function = "FCNPC_SetVirtualWorld")]
            public virtual bool FCNPC_SetVirtualWorld(int id, int virtualWorldId) =>
            throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_GetVirtualWorld")]
            public virtual int FCNPC_GetVirtualWorld(int id) =>
            throw new NativeNotImplementedException();

            /**
native FCNPC_SetHealth(npcid, Float:health);
native Float:FCNPC_GiveHealth(npcid, Float:health);
native Float:FCNPC_GetHealth(npcid);
native FCNPC_SetArmour(npcid, Float:armour);
native Float:FCNPC_GiveArmour(npcid, Float:armour);
native Float:FCNPC_GetArmour(npcid);

native FCNPC_SetInvulnerable(npcid, bool:invulnerable = true);
native bool:FCNPC_IsInvulnerable(npcid);
**/
            [NativeMethod(Function = "FCNPC_SetHealth")]
            public virtual bool FCNPC_SetHealth(int id, float health) =>
            throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GiveHealth")]
            public virtual float FCNPC_GiveHealth(int id, float health) =>
            throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetHealth")]
            public virtual float FCNPC_GetHealth(int id) =>
            throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetArmour")]
            public virtual bool FCNPC_SetArmour(int id, float armour) =>
            throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GiveArmour")]
            public virtual float FCNPC_GiveArmour(int id, float armour) =>
            throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetArmour")]
            public virtual float FCNPC_GetArmour(int id) =>
            throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetInvulnerable")]
            public virtual bool FCNPC_SetInvulnerable(int id,bool invulnerable = true) =>
            throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_IsInvulnerable")]
            public virtual bool FCNPC_IsInvulnerable(int id, bool invulnerable = true) =>
            throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetSkin")]
            public virtual bool SetSkin(int npcid, int skinid) =>
               throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetSkin")]
            public virtual int GetSkin(int npcid) =>
                throw new NativeNotImplementedException();

            /* FCNPC Weapons */
            [NativeMethod(Function = "FCNPC_SetWeapon")]
            public virtual bool SetWeapon(int npcid, int weaponid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetWeapon")]
            public virtual int GetWeapon(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetAmmo")]
            public virtual bool SetAmmo(int npcid, int ammo) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GiveAmmo")]
            public virtual bool GiveAmmo(int npcid, int ammo) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetAmmo")]
            public virtual int GetAmmo(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetAmmoInClip")]
            public virtual bool SetAmmoInClip(int npcid, int ammo) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GiveAmmoInClip")]
            public virtual bool GiveAmmoInClip(int npcid, int ammo) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetAmmoInClip")]
            public virtual int GetAmmoInClip(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetWeaponSkillLevel")]
            public virtual bool SetWeaponSkillLevel(int npcid, int skill, int level) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GiveWeaponSkillLevel")]
            public virtual bool GiveWeaponSkillLevel(int npcid, int skill, int level) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetWeaponSkillLevel")]
            public virtual int GetWeaponSkillLevel(int npcid, int skill) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetWeaponState")]
            public virtual bool SetWeaponState(int npcid, int weaponstate) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetWeaponState")]
            public virtual int GetWeaponState(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetWeaponReloadTime")]
            public virtual bool SetWeaponReloadTime(int npcid, int weaponid, int time) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetWeaponReloadTime")]
            public virtual int GetWeaponReloadTime(int npcid, int weaponid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetWeaponActualReloadTime")]
            public virtual int GetWeaponActualReloadTime(int npcid, int weaponid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetWeaponShootTime")]
            public virtual bool SetWeaponShootTime(int npcid, int weaponid, int time) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetWeaponShootTime")]
            public virtual int GetWeaponShootTime(int npcid, int weaponid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetWeaponClipSize")]
            public virtual bool SetWeaponClipSize(int npcid, int weaponid, int size) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetWeaponClipSize")]
            public virtual int GetWeaponClipSize(int npcid, int weaponid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetWeaponActualClipSize")]
            public virtual int GetWeaponActualClipSize(int npcid, int weaponid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetWeaponAccuracy")]
            public virtual bool SetWeaponAccuracy(int npcid, int weaponid, float accuracy) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetWeaponAccuracy")]
            public virtual float GetWeaponAccuracy(int npcid, int weaponid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetWeaponInfo")]
            public virtual bool SetWeaponInfo(int npcid, int weaponid, int reload_time = -1, int shoot_time = -1, int clip_size = -1, float accuracy = 1f) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetWeaponInfo")]
            public virtual bool GetWeaponInfo(int npcid, int weaponid, out int reload_time, out int shoot_time, out int clip_size, out float accuracy) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetWeaponDefaultInfo")]
            public virtual bool SetWeaponDefaultInfo(int weaponid, int reload_time = -1, int shoot_time = -1, int clip_size = -1, float accuracy = 1f) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetWeaponDefaultInfo")]
            public virtual bool GetWeaponDefaultInfo(int weaponid, out int reload_time, out int shoot_time, out int clip_size, out float accuracy) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GoByMovePath")]
            public virtual bool GoByMovePath(int npcid, int pathid, int type = (int)Definitions.MoveType.Auto, float speed = Definitions.MoveSpeed.Auto, bool useMapAndreas = false, float radius = 0f, bool setangle = true, float dist_offset = 0f) =>
                throw new NativeNotImplementedException();

            /**
native FCNPC_GoTo(npcid, Float:x, Float:y, Float:z, type = FCNPC_MOVE_TYPE_AUTO, Float:speed = FCNPC_MOVE_SPEED_AUTO, mode = FCNPC_MOVE_MODE_AUTO, pathfinding = FCNPC_MOVE_PATHFINDING_AUTO, Float:radius = 0.0, bool:set_angle = true, Float:min_distance = 0.0, stop_delay = 250);
native FCNPC_GoToPlayer(npcid, playerid, type = FCNPC_MOVE_TYPE_AUTO, Float:speed = FCNPC_MOVE_SPEED_AUTO, mode = FCNPC_MOVE_MODE_AUTO, pathfinding = FCNPC_MOVE_PATHFINDING_AUTO, Float:radius = 0.0, bool:set_angle = true, Float:min_distance = 0.0, Float:dist_check = 1.5, stop_delay = 250);
**/
            /* FCNPC Movement */
            [NativeMethod(Function = "FCNPC_GoTo")]
            public virtual bool GoTo(int npcid, float x, float y, float z, int type = (int)Definitions.MoveType.Auto, float speed = Definitions.MoveSpeed.Auto,int movemode = (int)MoveMode.Auto, int pathfinding = (int)Definitions.PathFinding.Auto, float radius = 0f, bool setangle = true, float min_dist = 0f, int stopdelay = 250) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GoToPlayer")]
            public virtual bool GoToPlayer(int npcid, int playerid, int type = (int)Definitions.MoveType.Auto, float speed = Definitions.MoveSpeed.Auto, int movemode = (int)MoveMode.Auto, int pathfinding = (int)Definitions.PathFinding.Auto, float radius = 0f, bool setangle = true, float min_dist = 0f, float dist_check = 1.5f, int stopdelay = 250) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_Stop")]
            public virtual bool Stop(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_IsMoving")]
            public virtual bool IsMoving(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_IsMovingAtPlayer")]
            public virtual bool IsMovingAtPlayer(int npcid, int playerid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetDestinationPoint")]
            public virtual bool GetDestinationPoint(int npcid, out float x, out float y, out float z) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetKeys")]
            public virtual bool SetKeys(int npcid, int ud_analog, int lr_analog, int keys) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetKeys")]
            public virtual bool GetKeys(int npcid, out int ud_analog, out int lr_analog, out int keys) =>
                throw new NativeNotImplementedException();

            /* FCNPC Animations  */
            [NativeMethod(Function = "FCNPC_SetSpecialAction")]
            public virtual bool SetSpecialAction(int npcid, int actionid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetSpecialAction")]
            public virtual int GetSpecialAction(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetAnimation")]
            public virtual bool SetAnimation(int npcid, int animationid, float fDelta = 4.1f, bool loop = false, bool lockx = true, bool locky = true, bool freeze = false, int time = 1) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetAnimationByName")]
            public virtual bool SetAnimationByName(int npcid, string name, float fDelta = 4.1f, bool loop = false, bool lockx = true, bool locky = true, bool freeze = false, int time = 1) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_ResetAnimation")]
            public virtual bool ResetAnimation(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetAnimation")]
            public virtual bool GetAnimation(int npcid, out int animationid, out float fDelta, out bool loop, out bool lockx, out bool locky, out bool freeze, out int time) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_ApplyAnimation")]
            public virtual bool ApplyAnimation(int npcid, string animlib, string animname, float fDelta = 4.1f, bool loop = false, bool lockx = true, bool locky = true, bool freeze = false, int time = 1) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_ClearAnimations")]
            public virtual bool ClearAnimations(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetFightingStyle")]
            public virtual bool SetFightingStyle(int npcid, int style) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetFightingStyle")]
            public virtual int GetFightingStyle(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_AimAt")]
            public virtual bool AimAt(int npcid, float x, float y, float z, bool shoot = false, int shoot_delay = -1, bool setangle = true, float offset_from_x = 0f, float offset_from_y = 0f, float offset_from_z = 0f) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_AimAtPlayer")]
            public virtual bool AimAtPlayer(int npcid, int playerid, bool shoot = false, int shoot_delay = -1, bool setangle = true, float offset_x = 0f, float offset_y = 0f, float offset_z = 0f, float offset_from_x = 0f, float offset_from_y = 0f, float offset_from_z = 0f) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_StopAim")]
            public virtual bool StopAim(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_MeleeAttack")]
            public virtual bool MeleeAttack(int npcid, int delay = -1, bool fightstyle = false) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_StopAttack")]
            public virtual bool StopAttack(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_IsAttacking")]
            public virtual bool IsAttacking(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_IsAiming")]
            public virtual bool IsAiming(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_IsAimingAtPlayer")]
            public virtual bool IsAimingAtPlayer(int npcid, int playerid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetAimingPlayer")]
            public virtual int GetAimingPlayer(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_IsShooting")]
            public virtual bool IsShooting(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_IsReloading")]
            public virtual bool IsReloading(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_TriggerWeaponShot")]
            public virtual bool TriggerWeaponShot(int npcid, int weaponid, int hittype, int hitid, float x, float y, float z, bool ishit = true, float offset_from_x = 0f, float offset_from_y = 0f, float offset_from_z = 0f) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_EnterVehicle")]
            public virtual bool EnterVehicle(int npcid, int vehicleid, int seatid, int type = (int)Definitions.MoveType.Walk) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_ExitVehicle")]
            public virtual bool ExitVehicle(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_PutInVehicle")]
            public virtual bool PutInVehicle(int npcid, int vehicleid, int seatid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_RemoveFromVehicle")]
            public virtual bool RemoveFromVehicle(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetVehicleID")]
            public virtual int GetVehicleID(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetVehicleSeat")]
            public virtual int GetVehicleSeat(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetVehicleSiren")]
            public virtual bool SetVehicleSiren(int npcid, bool status) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_IsVehicleSiren")]
            public virtual bool IsVehicleSiren(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetVehicleHealth")]
            public virtual bool SetVehicleHealth(int npcid, float health) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetVehicleHealth")]
            public virtual float GetVehicleHealth(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetVehicleHydraThrusters")]
            public virtual bool SetVehicleHydraThrusters(int npcid, bool direction) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetVehicleHydraThrusters")]
            public virtual bool GetVehicleHydraThrusters(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetVehicleGearState")]
            public virtual bool SetVehicleGearState(int npcid, bool gear_state) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetVehicleGearState")]
            public virtual bool GetVehicleGearState(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetSurfingOffsets")]
            public virtual bool SetSurfingOffsets(int npcid, float x, float y, float z) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GiveSurfingOffsets")]
            public virtual bool GiveSurfingOffsets(int npcid, float x, float y, float z) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetSurfingOffsets")]
            public virtual bool GetSurfingOffsets(int npcid, out float x, out float y, out float z) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetSurfingVehicle")]
            public virtual bool SetSurfingVehicle(int npcid, int vehicleid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetSurfingVehicle")]
            public virtual int GetSurfingVehicle(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetSurfingObject")]
            public virtual bool SetSurfingObject(int npcid, int objectid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetSurfingObject")]
            public virtual int GetSurfingObject(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_SetSurfingPlayerObject")]
            public virtual bool SetSurfingPlayerObject(int npcid, int objectid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetSurfingPlayerObject")]
            public virtual int GetSurfingPlayerObject(int npcid) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_StopSurfing")]
            public virtual bool StopSurfing(int npcid) =>
                throw new NativeNotImplementedException();
            [NativeMethod(Function = "FCNPC_UseMoveMode")]
            public virtual bool FCNPC_UseMoveMode(int mode, bool use = true) =>
                throw new NativeNotImplementedException();
            
            [NativeMethod(Function = "FCNPC_SetMoveMode")]
            public virtual bool FCNPC_SetMoveMode(int botid, int mode) =>
                throw new NativeNotImplementedException();

            [NativeMethod(Function = "FCNPC_GetMoveMode")]
            public virtual int FCNPC_GetMoveMode(int botid) =>
                throw new NativeNotImplementedException();

        }



    }
}

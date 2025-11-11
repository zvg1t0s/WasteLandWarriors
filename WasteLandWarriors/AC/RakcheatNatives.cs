using SampSharp.Core.Natives.NativeObjects;
using SampSharp.GameMode;
using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.AC
{
    public class RakcheatNatives : NativeObjectSingleton<RakcheatNatives>
    {
        
        
        [NativeMethod]
        public virtual int CallRemoteFunction(string func, string format, params object[] args)
        {
            throw new NativeNotImplementedException();
        }
        public static void AC_SetSpawnInfo(int id,int team,int skin, Vector3 pos, float rotation, Weapon weapon = Weapon.None, int ammo1 = 0, Weapon weapon2 = Weapon.None, int ammo2 = 0, Weapon weapon3 = Weapon.None, int ammo3 = 0)
        {
            //"ac_SetSpawnInfo", "iiiffffididid", playerid, team, skin, x, y, z, rotation, weapon1, weapon1_ammo, weapon2, weapon2_ammo, weapon3, weapon3_ammo
            Instance.CallRemoteFunction("ac_SetSpawnInfo", "iiiffffididid", id,team, skin,pos.X, pos.Y, pos.Z, rotation, weapon, ammo1, weapon2, ammo2, weapon3, ammo3);
        }
        public static void AC_SpawnPlayer(int id)
        {
            Instance.CallRemoteFunction("ac_SpawnPlayer", "i", id);
        }
        //"ac_SetPlayerInterior", "ii", playerid, interiorid
        public static void AC_setInterior(int id, int interiorId)
        {
            Instance.CallRemoteFunction("ac_SetPlayerInterior", "ii", id, interiorId);
        }
        //"ac_EnableAntiCheatForPlayer", "iii", playerid, code, enable
        public static void AC_EnableAntiCheat(int id, int code, bool enable)
        {
            Instance.CallRemoteFunction("ac_EnableAntiCheatForPlayer", "iii", id, code, enable);
        }
        //"ac_GivePlayerWeapon", "iid", playerid, weaponid, ammo
        public static void AC_GivePlayerWeapon(Player p, Weapon weapon, int ammo)
        {
            Instance.CallRemoteFunction("ac_GivePlayerWeapon", "iid", p.Id, (int)weapon, ammo);
        }
        //"ac_CreatePickup", "iiifff", ac_pickid, model, type, X, Y, Z
        public static void AC_CreatePickup(int pickUpId, int model , int type, Vector3 pos)
        {
            Instance.CallRemoteFunction("ac_CreatePickup", "iiifff", pickUpId, model,type,pos.X, pos.Y, pos.Z);
        }
        //"ac_TogglePlayerSpectating", "ii", playerid, toggle
        public static void AC_TogglePlayerSpectating(Player p, bool toggle)
        {
            Instance.CallRemoteFunction("ac_TogglePlayerSpectating", "ii", p.Id, toggle);
        }
        //"ac_SetVehicleHealth", "ifi", vehicleid, health, false
        public static void AC_SetVehicleHealth(int vehicleId, float health, bool repair)
        {
            Instance.CallRemoteFunction("ac_SetVehicleHealth", "ifi", vehicleId, health, repair);
        }
        //"ac_SetPlayerHealth", "if", playerid, health
        public static void AC_SetPlayerHealth(Player p, float health)
        {
            Instance.CallRemoteFunction("ac_SetPlayerHealth", "if", p.Id, health);
        }
        //"ac_SetPlayerPos", "ifffi", playerid, x, y, z, 1
        public static void AC_SetPlayerPos(BasePlayer p, Vector3 position)
        {
            Instance.CallRemoteFunction("ac_SetPlayerPos", "ifffi", p.Id, position.X, position.Y,position.Z, 1);
        }
        //"ac_DisableInteriorEnterExits", ""
        public static void AC_DisableInteriorEnterExits()
        {
            Instance.CallRemoteFunction("ac_DisableInteriorEnterExits", "");
        }
        //ac_SetPlayerArmour", "if", playerid, armour
        public static void AC_SetPlayerArmour(Player p, float armour)
        {
            Instance.CallRemoteFunction("ac_SetPlayerArmour", "if", p.Id, armour);
        }
        public static void AC_SetPlayerMoney(Player p, int money)
        {
            //ac_GivePlayerMoney
            Instance.CallRemoteFunction("ac_GivePlayerMoney", "ii", p.Id, money);
        }
    }
}

using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasteLandWarriors.AC;

namespace WasteLandWarriors.Systems
{
    internal class InCarWeaponChange
    {
        public static void Change(Player p, KeyStateChangedEventArgs e) {
            if (p.State == SampSharp.GameMode.Definitions.PlayerState.Passenger)
            {
                Weapon curr = Weapon.None;
                int ammo = 0;
                if (e.NewKeys == SampSharp.GameMode.Definitions.Keys.LookRight)
                {
                    
                    if(p.currentHeld == Weapon.None)
                    {
                        p.GetWeaponData(2, out curr, out ammo);
                        p.SendClientMessage(curr.ToString());
                        p.SendClientMessage(ammo.ToString());
                        p.currentHeld = Weapon.Deagle;
                        if (curr != Weapon.None)
                        {
                            
                            p.SetArmedWeapon(Weapon.Deagle);
                            return;
                        }
                    }
                    if (p.currentHeld == Weapon.Deagle)
                    {
                        p.currentHeld = Weapon.CombatShotgun;
                        p.GetWeaponData(3, out curr, out ammo);
                        if (curr != Weapon.None)
                        {
                            
                            p.SetArmedWeapon(Weapon.CombatShotgun);
                            return;
                        }
                        
                    }
                    if(p.currentHeld == Weapon.CombatShotgun)
                    {
                        p.currentHeld = Weapon.M4;
                        p.GetWeaponData(5, out curr, out ammo);
                        if (curr != Weapon.None)
                        {
                            
                            p.SetArmedWeapon(Weapon.M4);
                            return;
                        }
                    }
                    if (p.currentHeld == Weapon.M4)
                    {
                        p.currentHeld = Weapon.Deagle;
                        p.GetWeaponData(5, out curr, out ammo);
                        if (curr != Weapon.None)
                        {

                            p.SetArmedWeapon(Weapon.Deagle);
                            return;
                        }
                    }
                    if (p.currentHeld != Weapon.None)
                    {
                        p.currentHeld = Weapon.None;
                        p.SetArmedWeapon(Weapon.None);
                        return;
                    }

                }
                if(e.NewKeys == Keys.LookLeft)
                {
                    if (p.currentHeld == Weapon.None)
                    {
                        p.GetWeaponData(5, out curr, out ammo);
                        p.currentHeld = Weapon.M4;
                        if (curr != Weapon.None)
                        {
                            
                            p.SetArmedWeapon(Weapon.M4);
                            return;
                        }
                       
                    }
                    if (p.currentHeld == Weapon.M4)
                    {
                        p.GetWeaponData(3, out curr, out ammo);
                        p.currentHeld = Weapon.CombatShotgun;
                        if (curr != Weapon.None)
                        {
                            
                            p.SetArmedWeapon(Weapon.CombatShotgun);
                            return;
                        }
                        
                    }
                    if (p.currentHeld == Weapon.CombatShotgun)
                    {
                        p.GetWeaponData(2, out curr, out ammo);
                        p.currentHeld = Weapon.Deagle;
                        if (curr != Weapon.None)
                        {
                            
                            p.SetArmedWeapon(Weapon.Deagle);
                            return;
                        }
                    }
                    if (p.currentHeld == Weapon.Deagle)
                    {
                        p.GetWeaponData(2, out curr, out ammo);
                        p.currentHeld = Weapon.M4;
                        if (curr != Weapon.None)
                        {
                            
                            p.SetArmedWeapon(Weapon.M4);
                            return;
                        }
                    }
                    if (p.currentHeld != Weapon.None)
                    {
                        p.currentHeld = Weapon.None;
                        p.SetArmedWeapon(Weapon.None);
                        return;
                    }


                }
            }
        }
    }
}

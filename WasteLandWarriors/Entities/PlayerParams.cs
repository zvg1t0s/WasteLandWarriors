using SampSharp.GameMode.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.Entities
{
    public class PlayerParams
    {
        Player player;
        public int respirator = 0;
        public int humanityNum = 1000;
        public int bodyTemp = 1000;
        public int clothWet = 0;
        public ClothesType clothesType = ClothesType.Normal;
        public bool nearCampFire = false;
        public PlayerParams(Player p) {
            player = p;
            player.Died += OnDied;
        }
        public void OnDied(object sender, DeathEventArgs e)
        {
            respirator = 0;
            humanityNum = 1000;
            bodyTemp = 1000;
            clothWet = 0;
        }
    }
    public enum ClothesType
    {
        None,
        Sick,
        Normal,
        Warm,
    }

    
}

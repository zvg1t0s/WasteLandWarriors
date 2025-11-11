using SampSharp.GameMode;
using SampSharp.GameMode.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.Systems
{
    internal class CraftTables
    {
        public static List<CraftTables> craftTables = new List<CraftTables>();
        
        public Vector3 tablePos {  get; set; }
        public CraftTables(Vector3 pos) {
            tablePos = pos;
            
        }
        public static void CreateCraftTables(Vector3 pos)
        {
            craftTables.Add(new CraftTables(pos));
            
        }
        
    }
}

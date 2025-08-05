using SampSharp.GameMode;
using SampSharp.Streamer.World;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.Entities
{
    public class Constructions
    {

        public int Id { get; set; }

        public int OwnerId { get; set; }

        public int ModelId { get; set; }

        public ConstructionType ConstructionType { get; set; } = ConstructionType.None;

        public double Health { get; set; }

        public double posX {  get; set; }
        public double posY { get; set; }
        public double posZ { get; set; }

        public double rotX { get; set; }
        public double rotY { get; set; }
        public double rotZ { get; set; }


        

        

        
    }
}

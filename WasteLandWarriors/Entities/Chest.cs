using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.Entities
{
    public class Chest
    {
        public int Id { get; set; }

        public int ConstructionId { get; set; }

        public string Name { get; set; }

        public int[] Items { get; set; } = new int[10];

        public Chest(Constructions construct) {
            ConstructionId = construct.Id;

        }


    }
}

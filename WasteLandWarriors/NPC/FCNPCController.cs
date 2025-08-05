using SampSharp.GameMode.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.NPC
{
    public class FCNPCController : ITypeProvider
    {
        public virtual void RegisterTypes()
        {
            FCNPC.Register<FCNPC>();
        }
    }
}

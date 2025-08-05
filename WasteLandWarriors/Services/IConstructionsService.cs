using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.Services
{
    internal interface IConstructionsService
    {
        public Task Create();

        public Task Read();


        public Task Update();

        public Task Delete();


    }
}

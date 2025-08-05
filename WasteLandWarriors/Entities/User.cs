using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string NickName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool Sex { get; set; }

        public DateTime Created { get; set; }

        public int Level {  get; set; }

        public double LastPosX { get; set; } = 0;

        public double LastPosY { get; set; } = 0;

        public double LastPosZ { get; set; } = 0;



        public User() { }

    }
}

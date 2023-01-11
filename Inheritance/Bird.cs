using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {

        }

        public bool Wings { get; set; }
        public bool Fly { get; set; }
        public bool Claws { get; set; }
        public bool HollowBones { get; set; }

    }
}

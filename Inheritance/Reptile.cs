using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {

        }

        public bool ColdBlooded { get; set; }
        public bool Vertebrates { get; set; }
        public bool ShedSkin { get; set; }
        public bool HasScales { get; set; }

    }
}

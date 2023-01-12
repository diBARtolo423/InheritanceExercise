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
            Legs = 2;
            BreathesAir = true;
            HasTail = true;
            CanSwim = false;
        }

        public bool CanFly { get; set; } = true;
        public bool HasFeathers { get; set; } = true;
        public bool CanSing { get; set; } = true;
        public bool BuildsNest { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Can fly: {CanFly}");
            Console.WriteLine($"Specialty: {CanSing}");
        }


    }
}

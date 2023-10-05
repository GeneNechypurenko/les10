using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les10
{
    internal class Bike : Vehicle, IDrivable
    {
        public Bike() { FuelLevel = 100; Speed = 0; }
        public void Accelerate()
        {
            Console.WriteLine("Bike using acceleration... top speed increasing"); ;
        }

        public void Break()
        {
            Console.WriteLine("Bike using breaks... top speed decreasing");
        }

        public override void Start()
        {
            Console.WriteLine("Bike begin to move...");
        }

        public override void Stop()
        {
            Console.WriteLine("Bike stoped...");
        }

        public void Turn()
        {
            Console.WriteLine("Bike turns...");
        }
    }
}

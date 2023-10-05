using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les10
{
    internal class Cargo : Vehicle, IDrivable, ICargoCarrier
    {
        public Cargo() { FuelLevel = 100; Speed = 0; }
        public void Accelerate()
        {
            Console.WriteLine("Cargo using acceleration... top speed increasing"); ;
        }

        public void Break()
        {
            Console.WriteLine("Cargo using breaks... top speed decreasing");
        }

        public override void Start()
        {
            Console.WriteLine("Cargo begin to move...");
        }

        public override void Stop()
        {
            Console.WriteLine("Cargo stoped...");
        }

        public void Turn()
        {
            Console.WriteLine("Cargo turns...");
        }
        public void LoadCargo()
        {
            Console.WriteLine("Load cargo");
        }

        public void UnloadCargo()
        {
            Console.WriteLine("Unload cargo");
        }
    }
}

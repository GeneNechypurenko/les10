using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les10
{
    internal class ElectroCar : Vehicle, IDrivable, IElectricVehicle
    {
        public ElectroCar() { FuelLevel = 100; Speed = 0; }
        public void Accelerate()
        {
            Console.WriteLine("ElectroCar using acceleration... top speed increasing"); ;
        }

        public void Break()
        {
            Console.WriteLine("ElectroCar using breaks... top speed decreasing");
        }
        public override void Start()
        {
            Console.WriteLine("ElectroCar begin to move...");
        }

        public override void Stop()
        {
            Console.WriteLine("ElectroCar stoped...");
        }

        public void Turn()
        {
            Console.WriteLine("ElectroCar turns...");
        }

        public void ChargeBattery()
        {
            Console.WriteLine("Charging");
        }

        public void LevelOfCharge()
        {
            Console.WriteLine($"Battery level {FuelLevel}");
        }
    }
}

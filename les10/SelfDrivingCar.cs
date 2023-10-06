using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les10
{
    internal class SelfDrivingCar : Vehicle, IDrivable, ISelfDriving
    {
        public SelfDrivingCar() { FuelLevel = 100; Speed = 0; }
        public void Accelerate()
        {
            Console.WriteLine("SelfDrivingCar using acceleration... top speed increasing"); ;
        }

        public void Break()
        {
            Console.WriteLine("SelfDrivingCar using breaks... top speed decreasing");
        }

        public override void Start()
        {
            Console.WriteLine("SelfDrivingCar begin to move...");
        }

        public override void Stop()
        {
            Console.WriteLine("SelfDrivingCar stoped...");
        }

        public void Turn()
        {
            Console.WriteLine("SelfDrivingCar turns...");
        }

        public void StartAutopilot()
        {
            Console.WriteLine("Autopilot start");
        }

        public void StopAutopilot()
        {
            Console.WriteLine("Autopilot stop");
        }
    }
}

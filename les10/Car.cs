using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les10
{
    internal class Car : Vehicle, IDrivable
    {
        public void Accelerate()
        {
            Console.WriteLine("Car using acceleration... top speed increasing"); ;
        }

        public void Break()
        {
            Console.WriteLine("Car using breaks... top speed decreasing");
        }

        public override void Start()
        {
            Console.WriteLine("Car begin to move...");
        }

        public override void Stop()
        {
            Console.WriteLine("Car stoped...");
        }

        public void Turn()
        {
            Console.WriteLine("Car turns...");
        }
    }
}

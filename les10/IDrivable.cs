using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les10
{
    internal interface IDrivable
    {
        public void Accelerate();
        public void Break();
        public void Turn();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les10
{
    internal abstract class Vehicle
    {
        protected int _speed;
        protected int _fuelLevel;
        public int Speed
        {
            get
            {
                return _speed;
            }
            init
            {
                _speed = 0;
            }
        }
        public int FuelLevel
        {
            get
            {
                return _fuelLevel;
            }
            set
            {
                _fuelLevel = value;
            }
        }
        public abstract void Start();
        public abstract void Stop();
    }
}

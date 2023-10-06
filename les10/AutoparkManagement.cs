using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les10
{
    internal class AutoparkManagement
    {
        List<Vehicle> autopark = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            autopark.Add(vehicle);
        }
        public int GetVehicleCount()
        {
            int count = 0;
            foreach (Vehicle vehicle in autopark) { count++; }
            return count;
        }
        public void DrivingInterfaceTest(int currentVehicle)
        {
            Vehicle vehicle = autopark[currentVehicle];

            vehicle.Start();

            if (vehicle is IDrivable drivableVehicle)
            {
                drivableVehicle.Accelerate();
                drivableVehicle.Break();
                drivableVehicle.Turn();
            }

            vehicle.Stop();
        }

        public void CargoCarrierTest(int currentVehicle)
        {
            Vehicle vehicle = autopark[currentVehicle];

            if (vehicle is ICargoCarrier cargoCarrier)
            {
                cargoCarrier.LoadCargo();
                cargoCarrier.UnloadCargo();
            }
        }

        public void ElectricVehicleTest(int currentVehicle)
        {
            Vehicle vehicle = autopark[currentVehicle];

            if (vehicle is IElectricVehicle electricVehicle)
            {
                electricVehicle.ChargeBattery();
                electricVehicle.LevelOfCharge();
            }
        }

        public void SelfDrivingTest(int currentVehicle)
        {
            Vehicle vehicle = autopark[currentVehicle];

            if (vehicle is ISelfDriving selfDrivingVehicle)
            {
                selfDrivingVehicle.StartAutopilot();
                selfDrivingVehicle.StopAutopilot();
            }
        }
    }
}
using les10;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        AutoparkManagement autoparkManagement = new AutoparkManagement();
        autoparkManagement.AddVehicle(new Car());
        autoparkManagement.AddVehicle(new Bike());
        autoparkManagement.AddVehicle(new Cargo());
        autoparkManagement.AddVehicle(new ElectroCar());
        autoparkManagement.AddVehicle(new SelfDrivingCar());

        for (int i = 0; i < autoparkManagement.GetVehicleCount(); ++i)
        {
            autoparkManagement.DrivingInterfaceTest(i);
            autoparkManagement.CargoCarrierTest(i);
            autoparkManagement.ElectricVehicleTest(i);
            autoparkManagement.SelfDrivingTest(i);

            Console.WriteLine();
        }


        //Vehicle vehicle = new Car();
        //IDrivable drivable = new Car();

        //vehicle.Start();
        //vehicle.Stop();
        //drivable.Turn();
        //drivable.Accelerate();
        //drivable.Break();


        //vehicle = new Bike();
        //drivable = new Bike();

        //vehicle.Start();
        //vehicle.Stop();
        //drivable.Turn();
        //drivable.Accelerate();
        //drivable.Break();


        //vehicle = new Cargo();
        //drivable = new Cargo();
        //ICargoCarrier cargoCarrier = new Cargo();

        //vehicle.Start();
        //vehicle.Stop();
        //drivable.Turn();
        //drivable.Accelerate();
        //drivable.Break();
        //cargoCarrier.LoadCargo();
        //cargoCarrier.UnloadCargo();


        //vehicle = new ElectroCar();
        //drivable = new ElectroCar();
        //IElectricVehicle electricVehicle = new ElectroCar();

        //vehicle.Start();
        //vehicle.Stop();
        //drivable.Turn();
        //drivable.Accelerate();
        //drivable.Break();
        //electricVehicle.ChargeBattery();
        //electricVehicle.LevelOfCharge();


        //vehicle = new SelfDrivingCar();
        //drivable = new SelfDrivingCar();
        //ISelfDriving selfDriving = new SelfDrivingCar();

        //vehicle.Start();
        //vehicle.Stop();
        //drivable.Turn();
        //drivable.Accelerate();
        //drivable.Break();
        //selfDriving.StartAutopilot();
        //selfDriving.StopAutopilot();
    }
}

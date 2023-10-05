using les10;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Vehicle vehicle = new Car();
        IDrivable drivable = new Car();

        vehicle.Start();
        vehicle.Stop();
        drivable.Turn();
        drivable.Accelerate();
        drivable.Break();



        vehicle = new Bike();
        drivable = new Bike();

        vehicle.Start();
        vehicle.Stop();
        drivable.Turn();
        drivable.Accelerate();
        drivable.Break();




        vehicle = new Cargo();
        drivable = new Cargo();
        ICargoCarrier cargoCarrier = new Cargo();

        vehicle.Start();
        vehicle.Stop();
        drivable.Turn();
        drivable.Accelerate();
        drivable.Break();
        cargoCarrier.LoadCargo();
        cargoCarrier.UnloadCargo();






        vehicle = new ElectroCar();
        drivable = new ElectroCar();
        IElectricVehicle electricVehicle = new ElectroCar();

        vehicle.Start();
        vehicle.Stop();
        drivable.Turn();
        drivable.Accelerate();
        drivable.Break();
        electricVehicle.ChargeBattery();
        electricVehicle.LevelOfCharge();
    }
}

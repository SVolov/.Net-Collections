using System.Collections.Generic;
using System.Linq;
using TaskThree.Parts;
using TaskThree.Vehicles;
using System.Xml.Linq;
using System.Xml.Serialization;
using System;
using TaskFive;

class Program
{
    static void Main(string[] args)
    {
        Engine enginerCar = new Engine(125, 2.5, "Petrol", 123456);
        Chassis chassisCar = new Chassis(4, 654321, 2);
        Transmission transmissionCar = new Transmission("AUTO", 7, "GERMANY");

        Engine enginerCar1 = new Engine(101, 1.4, "Petrol", 483756);
        Chassis chassisCar1 = new Chassis(4, 123098, 2);
        Transmission transmissionCar1 = new Transmission("AUTO", 5, "JAPAN");

        Engine enginerBus = new Engine(250, 3.0, "Diesel", 756546);
        Chassis chassisBus = new Chassis(4, 567891, 4);
        Transmission transmissionBus = new Transmission("MANUAL", 6, "BELARUS");

        Engine enginerBus1 = new Engine(200, 2.5, "Diesel", 873486);
        Chassis chassisBus1 = new Chassis(4, 176441, 3);
        Transmission transmissionBus1 = new Transmission("MANUAL", 5, "BELARUS");

        Engine enginerLorry = new Engine(400, 3.5, "Diesel", 974652);
        Chassis chassisLorry = new Chassis(6, 234876, 30);
        Transmission transmissionLorry = new Transmission("MANUAL", 5, "NORWAY");

        Engine enginerLorry1 = new Engine(350, 3.0, "Diesel", 333652);
        Chassis chassisLorry1 = new Chassis(6, 194876, 20);
        Transmission transmissionLorry1 = new Transmission("AUTO", 6, "SWEDEN");

        Engine enginerScooter = new Engine(45, 0.5, "Petrol", 324629);
        Chassis chassisScooter = new Chassis(2, 027552, 1);
        Transmission transmissionScooter = new Transmission("AUTO", 4, "JAPAN");

        Engine enginerScooter1 = new Engine(50, 0.6, "Petrol", 678595);
        Chassis chassisScooter1 = new Chassis(2, 012433, 1);
        Transmission transmissionScooter1 = new Transmission("AUTO", 5, "GERMANY");

        var vehicles = new VehiclesList();
        vehicles.VehiclesListObjects = new List<Vehicle>()
        {
            new Car(enginerCar, chassisCar, transmissionCar, 6.0),
            new Car(enginerCar1, chassisCar1, transmissionCar1, 9.0),
            new Bus(enginerBus, chassisBus, transmissionBus, 36),
            new Bus(enginerBus1, chassisBus1, transmissionBus1, 30),
            new Lorry(enginerLorry, chassisLorry, transmissionLorry, 20),
            new Lorry(enginerLorry1, chassisLorry1, transmissionLorry1, 15),
            new Scooter(enginerScooter, chassisScooter, transmissionScooter, 2),
            new Scooter(enginerScooter1, chassisScooter1, transmissionScooter1, 2)
        };

        vehicles.VehiclesListObjects.Sort();
        XML.SerializeToXml(vehicles, "vechiclesSort.xml");

        var vehiclesList = new VehiclesList();
        vehiclesList.VehiclesListObjects = vehicles.VehiclesListObjects.Where(v => v.Engine.Volume >= 1.5).ToList();
        XML.SerializeToXml(vehiclesList, "vechiclesVolumeMore1.5.xml");

        var vehiclesList2 = new VehiclesList();
        vehiclesList2.VehiclesListObjects = vehicles.VehiclesListObjects.Where(v => v.GetType() == typeof(Bus) || v.GetType() == typeof(Lorry))
            .ToList();
        XML.SerializeToXmlWithoutVolume(vehiclesList2, "vehiclesBusAndLorry.xml");
    }
}

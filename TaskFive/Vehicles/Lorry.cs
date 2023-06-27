using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskThree.Parts;

namespace TaskThree.Vehicles
{
    public class Lorry : Vehicle
    {
        public int CargoWeight;

        public Lorry(Engine engine, Chassis chassis, Transmission transmission, int cargoWeight) : base(engine, chassis, transmission)
        {
            CargoWeight = cargoWeight;
        }

        public Lorry() { }

        public override void PrintInfo()
        {
            Console.WriteLine("Lorry");
            base.PrintInfo();
            Console.WriteLine($"Cargo Weight: {CargoWeight};");
        }
    }
}
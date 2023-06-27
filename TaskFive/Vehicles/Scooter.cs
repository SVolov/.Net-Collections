using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskThree.Parts;

namespace TaskThree.Vehicles
{
    public class Scooter : Vehicle
    {
        public int NumberOfHelmets;

        public Scooter(Engine engine, Chassis chassis, Transmission transmission, int numberOfHelmets) : base(engine, chassis, transmission)
        {
            NumberOfHelmets = numberOfHelmets;
        }

        public Scooter() { }

        public override void PrintInfo()
        {
            Console.WriteLine("Scooter");
            base.PrintInfo();
            Console.WriteLine($"Number Of Helmets: {NumberOfHelmets};");
        }
    }
}

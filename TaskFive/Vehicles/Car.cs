using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TaskThree.Parts;

namespace TaskThree.Vehicles
{
    public class Car : Vehicle
    {
        public double TimeTo100;

        public Car(Engine engine, Chassis chassis, Transmission transmission, double timeTo100) : base(engine, chassis, transmission)
        {
            TimeTo100 = timeTo100;
        }

        public Car() { }

        public override void PrintInfo()
        {
            Console.WriteLine("Car");
            base.PrintInfo();
            Console.WriteLine($"Time To 100: {TimeTo100};");
        }
    }
}
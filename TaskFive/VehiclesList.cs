using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TaskThree.Vehicles;

namespace TaskFive
{
    public class VehiclesList
    {
        [XmlArrayItem(typeof(Car))]
        [XmlArrayItem(typeof(Bus))]
        [XmlArrayItem(typeof(Lorry))]
        [XmlArrayItem(typeof(Scooter))]
        public List<Vehicle> VehiclesListObjects { get; set; }
    }

}

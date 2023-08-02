using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TaskThree.Parts;

namespace TaskFive
{
    public class XML
    {
       public static void SerializeToXml(VehiclesList vehicles, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(VehiclesList));
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, vehicles);
            }
        }

        public static void SerializeToXmlWithoutVolume(VehiclesList vehicles, string filePath)
        {
            XmlAttributeOverrides overrides = new XmlAttributeOverrides();
            XmlAttributes attribs = new XmlAttributes();
            attribs.XmlIgnore = true;
            attribs.XmlElements.Add(new XmlElementAttribute("Volume"));
            overrides.Add(typeof(Engine), "Volume", attribs);

            XmlSerializer serializer = new XmlSerializer(typeof(VehiclesList), overrides);
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, vehicles);
            }
        }
    }
}

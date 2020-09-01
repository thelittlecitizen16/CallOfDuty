using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace CallOfDuty.XMLSerialization
{
    public class LoadConfigFromStream<T>
    {
        public T LoadConfig(Stream stream)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            return (T)serializer.Deserialize(stream);
        }
    }
}

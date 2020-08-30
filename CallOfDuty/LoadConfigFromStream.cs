using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace CallOfDuty
{
    public class LoadConfigFromStream<T>
    {
        public T[] Deserialize(Stream stream)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T[]));

            return (T[])serializer.Deserialize(stream);
        }
    }
}

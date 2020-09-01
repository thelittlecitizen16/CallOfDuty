using CallOfDuty.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace CallOfDuty.XMLSerialization
{
    public class SaveObjectToPath<T> : ISaveObjectToPath<T>
    {
        public void SaveObject(T configuration, string path)
        {
            XmlSerializer writer = new XmlSerializer(configuration.GetType());
            StreamWriter fileWrite = new StreamWriter(path);
            writer.Serialize(fileWrite, configuration);
            fileWrite.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace CallOfDuty
{
    public class SaveObjectToPath<T>
    {
        public void Serialize(T configuration, string path)
        {
            XmlSerializer writer = new XmlSerializer(configuration.GetType());
            StreamWriter fileWrite = new StreamWriter(path);
            writer.Serialize(fileWrite, configuration);
            fileWrite.Close();
        }
    }
}

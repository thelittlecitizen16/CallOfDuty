using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace CallOfDuty
{
    public class LoadObjectFromPath<T>
    {
        public T GetObject(string path)
        {
            XmlSerializer writer = new XmlSerializer(typeof(T));
            StreamReader fileWrite = new StreamReader(path);
            var configuration = (T)writer.Deserialize(fileWrite);
            fileWrite.Close();

            return configuration;
        }
    }
}

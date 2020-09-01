using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace CallOfDuty.XMLSerialization
{
    public class SaveObjectToStream<T>
    {
        public Stream SaveObject(string path)
        {         
            FileStream fileStream = File.OpenRead(path);

            return fileStream;
        }
    }
}

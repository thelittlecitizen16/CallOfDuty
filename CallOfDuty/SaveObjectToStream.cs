using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace CallOfDuty
{
    public class SaveObjectToStream<T>
    {
        Stream Serialize(T configurationToSerialize,string path)
        {         
            FileStream fileStream = File.OpenRead(path);

            return fileStream;
        }
    }
}

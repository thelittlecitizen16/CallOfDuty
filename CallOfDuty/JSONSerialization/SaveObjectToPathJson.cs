using System;
using CallOfDuty.Interfaces;
using System.Text.Json;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace CallOfDuty.JSONSerialization
{
    public class SaveObjectToPathJson<T> : ISaveObjectToPath<T>
    {
        public void SaveObject(T configuration, string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(configuration));
        }
    }
}

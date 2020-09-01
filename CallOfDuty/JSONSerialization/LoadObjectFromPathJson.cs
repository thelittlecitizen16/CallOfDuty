using CallOfDuty.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CallOfDuty.JSONSerialization
{
    public class LoadObjectFromPathJson<T> : ILoadObjectFromPath<T>
    {
        public T GetObject(string path)
        {
            return  JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
        }
    }
}

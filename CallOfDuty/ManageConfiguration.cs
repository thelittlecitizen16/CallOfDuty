using CallOfDuty.Interfaces;
using CallOfDuty.PlayersObjects;
using CallOfDuty.XMLSerialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDuty
{
    public class ManageConfiguration
    {
        public Configuration GetConfiguration(ISaveObjectToPath<Configuration> saveObjectToPath,ILoadObjectFromPath<Configuration> loadObjectFromPath,Configuration configuration, string path)
        {
            saveObjectToPath.SaveObject(configuration, path);
          return loadObjectFromPath.GetObject(path);
        }
    }
}

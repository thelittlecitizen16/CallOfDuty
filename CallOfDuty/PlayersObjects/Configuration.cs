using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CallOfDuty.PlayersObjects
{
    [Serializable()]
    public class Configuration
    {
        public List<Settings> AllPlayersSetting {get;set;}
        public Configuration()
        {
        }
        public Configuration(List<Settings> allPlayersSetting)
        {
            AllPlayersSetting = allPlayersSetting;
        }   
    }
}

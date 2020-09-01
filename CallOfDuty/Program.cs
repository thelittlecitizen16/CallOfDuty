using CallOfDuty.JSONSerialization;
using CallOfDuty.PlayersObjects;
using CallOfDuty.XMLSerialization;
using System;
using System.Collections.Generic;
using System.IO;

namespace CallOfDuty
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathXml = @"C:\Users\thelittlecitizen16\source\repos\CallOfDuty\CallOfDuty\ConfigurationXML.xml";
            string pathJson = @"C:\Users\thelittlecitizen16\source\repos\CallOfDuty\CallOfDuty\ConfigurationJSON.json";

            Gun gun1 = new Gun("BOOM",50,8,"RED");
            Settings player1 = new Settings("player1","p1",DateTime.Now, 10,10,5,new List<Gun> { gun1 },false);
            Configuration configuration = new Configuration(new List<Settings> { player1 });

            ManageConfiguration manage = new ManageConfiguration();

            //XML FROM FILE
            SaveObjectToPath<Configuration> saveObjectToPath = new SaveObjectToPath<Configuration>();
            LoadObjectFromPath<Configuration> loadObjectFromPath = new LoadObjectFromPath<Configuration>();
            Configuration configurationAfterXml = manage.GetConfiguration(saveObjectToPath, loadObjectFromPath,configuration, pathXml);

            //JSON FROM FILE
            SaveObjectToPathJson<Configuration> saveObjectToPathJson = new SaveObjectToPathJson<Configuration>();
            LoadObjectFromPathJson<Configuration> loadObjectFromPathJson = new LoadObjectFromPathJson<Configuration>();
            Configuration configurationAfterJson = manage.GetConfiguration(saveObjectToPathJson, loadObjectFromPathJson, configuration, pathJson);

            //XML FROM Stream
            LoadConfigFromStream<Configuration> loadConfigFromStream = new LoadConfigFromStream<Configuration>();
            SaveObjectToStream<Configuration> saveObjectToStream = new SaveObjectToStream<Configuration>();
            Stream stream = saveObjectToStream.SaveObject(pathXml);
            Configuration configurationFromStream = loadConfigFromStream.LoadConfig(stream);

        }
    }
}

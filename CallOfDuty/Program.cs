using CallOfDuty.PlayersObjects;
using System;
using System.Collections.Generic;

namespace CallOfDuty
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Users\thelittlecitizen16\source\repos\CallOfDuty\CallOfDuty\ConfigurationXML.xml";
            Gun gun1 = new Gun("BOOM",50,8,"RED");
            Settings player1 = new Settings("player1","p1",DateTime.Now, 10,10,5,new List<Gun> { gun1},false);
            Configuration configuration = new Configuration(new List<Settings> { player1 });
            Console.WriteLine("Hello World!");
        }
    }
}

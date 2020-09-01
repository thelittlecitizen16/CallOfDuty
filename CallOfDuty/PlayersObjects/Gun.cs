using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDuty.PlayersObjects
{
    [Serializable()]
    public class Gun
    {
        public string Name { get; set; }
        public int BolutCount { get; set; }
        public int Damage { get; set; }
        public string Color { get; set; }
        public Gun()
        {

        }
        public Gun(string name, int bolutCount, int damage, string color)
        {
            Name = name;
            BolutCount = bolutCount;
            Damage = damage;
            Color = color;
        }
    }
}

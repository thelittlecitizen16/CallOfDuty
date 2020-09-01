using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CallOfDuty.PlayersObjects
{
    [Serializable()]
    public class Settings
    {
        public string FullName {get;set;}
        public string Nickname { get; set; }
        public DateTime SignInDate { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double DayAvrageOfKill { get; set; }
        public List<Gun> AllFavoriteGun { get; set; }
        [XmlIgnoreAttribute]
        public bool IsCheater { get; set; }
        public Settings()
        {

        }
        public Settings(string fullName, string nickname, DateTime signInDate, double width, double length, double dayAvrageOfKill, List<Gun> allFavoriteGun, bool isCheater)
        {
            FullName = fullName;
            Nickname = nickname;
            SignInDate = signInDate;
            Width = width;
            Length = length;
            DayAvrageOfKill = dayAvrageOfKill;
            AllFavoriteGun = allFavoriteGun;
            IsCheater = isCheater;
        }
    }
}

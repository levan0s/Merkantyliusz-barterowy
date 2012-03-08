using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MerkantyliuszBarterowy.Model
{
    class Town
    {
        int longitude;      //długość geograficzna
        int latitude;       //szerokość geograficzna
        string name;
        public Town(int latitude, int longitude, string name)
        { 
        this.latitude = latitude;
        this.longitude = longitude;
        this.name = name;
        }
        public int Longitude
        {
            get { return this.longitude; }
        }
        public int Latitude
        {
            get { return this.latitude; }
        }
        public string Name
        {
            get {return name; }
        }
        public int GetTravelDistance(Town destination)
        {
            int latDiff = Math.Abs(Latitude - destination.Latitude);
            int lonDiff = Math.Abs(Longitude - destination.Longitude);
            return (latDiff + lonDiff);                         //yes, that's silly
        }
        public static List<Town> CreateTowns()
        {
            List<Town> towns = new List<Town>(){
            new Town(-155, -235, "Cintra"),
            new Town(100, -195, "Mos Eisley"),
            new Town(130, -60, "Krondor"),
            new Town(-40, -20, "Bree"),
            new Town(-255, 65, "Whiterun"),
            new Town(170, 175, "King's Landing")};
            
            return towns;
        }
    }
}

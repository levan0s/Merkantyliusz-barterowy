using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MerkantyliuszBarterowy.Model
{
    class Town
    {
        public PriceList PriceList{ get; set; }
        
        public Town(int latitude, int longitude, string name, PriceList priceList)
        { 
            _latitude = latitude;
            _longitude = longitude;
            _name = name;
            this.PriceList = priceList;
        }

        public int Longitude
        {
            get { return _longitude; }
        }

        public int Latitude
        {
            get { return _latitude; }
        }

        public string Name
        {
            get {return _name; }
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
            new Town(-155, -235, "Cintra", PriceList.defaultPriceList()),
            new Town(100, -195, "Mos Eisley", PriceList.defaultPriceList()),
            new Town(130, -60, "Krondor", PriceList.defaultPriceList()),
            new Town(-40, -20, "Bree", PriceList.defaultPriceList()),
            new Town(-255, 65, "Whiterun", PriceList.defaultPriceList()),
            new Town(170, 175, "King's Landing", PriceList.defaultPriceList())};
            
            return towns;
        }


        private int _longitude;      //długość geograficzna
        private int _latitude;       //szerokość geograficzna
        private string _name;
    }
}

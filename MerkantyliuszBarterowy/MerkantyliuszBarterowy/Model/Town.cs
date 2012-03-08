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
        public int Longitude
        {
            get { return this.longitude; }
        }
        public int Latitude
        {
            get { return this.latitude; }
        }
        
        public int GetTravelDistance(Town destination)
        {
            int latDiff = Math.Abs(Latitude - destination.Latitude);
            int lonDiff = Math.Abs(Longitude - destination.Longitude);
            return (latDiff + lonDiff);                         //yes, that's silly
        }
    }
}

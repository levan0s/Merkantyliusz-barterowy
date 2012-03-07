using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MerkantyliuszBarterowy.Model
{
    class PCMerchant
    {
        string name;
        private Town actualLocation;
        List<TradeGood> belongings;
        const int cashPerDistance = 5;      //stała, wyrażająca cenę za podróż na jednostkowym dystansie
        public PCMerchant(String name, Town startingLocation, List<TradeGood> belongings ) 
        {
            this.name = name;
            this.actualLocation = startingLocation;
            this.belongings = belongings;
        }
        

        public void travel(Town destination)
        { 
        //todo - potrącanie ceny za podróż z 'sakiewki'
            actualLocation = destination;
        }
        private decimal GetTravelPrice(Town destination)
        {
            return (GetTravelDistance(destination) * cashPerDistance);
        }
        private int GetTravelDistance(Town destination)     
        {
            int latDiff = Math.Abs(actualLocation.Latitude - destination.Latitude);
            int lonDiff = Math.Abs(actualLocation.Longitude - destination.Longitude);
            return (latDiff + lonDiff);                         //yes, that's silly
        }

    }
}

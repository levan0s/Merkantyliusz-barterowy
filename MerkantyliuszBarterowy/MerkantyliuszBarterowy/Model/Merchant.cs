using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MerkantyliuszBarterowy.Model
{
    class Merchant
    {
      
        public Merchant(String name, Town startingLocation, List<TradeGood> belongings ) 
        {
            _name = name;
            _actualLocation = startingLocation;
            _belongings = belongings;
        }
        

        public void Travel(Town destination)
        { 
        //todo - potrącanie ceny za podróż z 'sakiewki'
            _actualLocation = destination;
        }

        private decimal GetTravelPrice(Town destination)
        {
            return (_actualLocation.GetTravelDistance(destination) * _cashPerDistance);
        }

        private readonly int _cashPerDistance = 5;      //stała, wyrażająca cenę za podróż na jednostkowym dystansie
        private string _name;
        private Town _actualLocation;
        private List<TradeGood> _belongings;
    }
}

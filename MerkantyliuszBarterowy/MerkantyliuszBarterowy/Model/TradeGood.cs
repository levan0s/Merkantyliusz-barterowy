using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MerkantyliuszBarterowy.Model.TradeGoods;

namespace MerkantyliuszBarterowy.Model
{
    class TradeGood
    {
        public TradeGood(string name, TradeGoodType tradeGoodType) 
        {
            _name = name;
            _tradeGoodType = tradeGoodType;
        }
        
        public string Name
        {
            get { return _name; }
        }
        
        private string _name;
        private TradeGoodType _tradeGoodType;
    }
   
}

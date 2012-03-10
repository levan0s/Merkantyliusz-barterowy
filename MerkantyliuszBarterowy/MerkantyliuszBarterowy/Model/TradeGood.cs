using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MerkantyliuszBarterowy.Model.TradeGoods;

namespace MerkantyliuszBarterowy.Model
{
    class TradeGood
    {
        public TradeGood(string name, decimal cashEquvalent, TradeGoodType tradeGoodType) 
        {
            _cashEquivalent = cashEquvalent;
            _name = name;
            _tradeGoodType = tradeGoodType;
        }

        public decimal CashEquivalent
        {
            get { return _cashEquivalent; }
            set { _cashEquivalent = value; }
        }
        public string Name
        {
            get { return _name; }
        }

        private decimal _cashEquivalent;
        private string _name;
        private TradeGoodType _tradeGoodType;
    }
   
}

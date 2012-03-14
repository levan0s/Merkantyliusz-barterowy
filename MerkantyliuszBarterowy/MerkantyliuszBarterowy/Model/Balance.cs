using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MerkantyliuszBarterowy.Model
{
    class Balance
    { 
        public int Quantity
        { get; set; }

        public string BalanceName
        { get { return _balanceName; } }
        
        public Balance(TradeGood tradeGood, int quantity)
        {
            Quantity = quantity;
            _balanceName = tradeGood.Name;
            _tradeGood = tradeGood;
        }

        private TradeGood _tradeGood;
        private string _balanceName;
    }
}

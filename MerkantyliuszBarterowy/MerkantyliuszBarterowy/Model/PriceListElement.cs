using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MerkantyliuszBarterowy.Model
{
    class PriceListElement
    {
        public decimal CashEquivalent { get; set; }

        public string GetName()
        {
            return _tradeGood.Name;
        }

        public PriceListElement(TradeGood tradegood, decimal cashEquivalent)
        {
            _tradeGood = tradegood;
            CashEquivalent = cashEquivalent;
        }

        private TradeGood _tradeGood;
    }
}

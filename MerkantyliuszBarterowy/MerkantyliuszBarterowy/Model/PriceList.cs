using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MerkantyliuszBarterowy.Model
{
    class PriceList
    {
        #region public methods

        public string GetTownName()
        {
            return _town.Name;
        }
        public decimal GetCashEquivalent(string tradeGoodName)
        {
            decimal cashEquivalent = 0;
            foreach (TradeGood trGood in _tradeGood)
            {
                if (trGood.Name == tradeGoodName)
                {
                    cashEquivalent = trGood.CashEquivalent;
                }
            }
            return cashEquivalent;
        }
        public void SetCashEquivalent(string tradeGoodName, decimal cashEquivalent)
        {
            foreach (TradeGood trGood in _tradeGood)
            {
                if (trGood.Name == tradeGoodName)
                {
                    trGood.CashEquivalent = cashEquivalent;
                }
            }
        }

        #endregion


        public PriceList(Town town, params TradeGood[] tradeGood )
        {
            _town = town;
            foreach (TradeGood trGood in tradeGood)
            {
                _tradeGood.Add(trGood);
            }
        }

        private Town _town;
        private List<TradeGood> _tradeGood = new List<TradeGood>();
    }
}

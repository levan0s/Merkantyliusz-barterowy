using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MerkantyliuszBarterowy.Model
{
    class PriceList
    {
        #region public methods
        
        public decimal GetCashEquivalent(string tradeGoodName)
        {
            decimal cashEquivalent = 0;
            foreach (PriceListElement priceListElement in _priceList)
            {
                if (priceListElement.GetName() == tradeGoodName)
                {
                    cashEquivalent = priceListElement.CashEquivalent;
                }
            }
            return cashEquivalent;
        }

        public void SetCashEquivalent(string tradeGoodName, decimal cashEquivalent)
        {
            foreach (PriceListElement priceListElement in _priceList)
            {
                if (priceListElement.GetName() == tradeGoodName)
                {
                    priceListElement.CashEquivalent = cashEquivalent;
                }
            }
        }

        public static PriceList defaultPriceList()
        { 
            PriceList defaultPriceList = new PriceList(
               new PriceListElement(new TradeGood("wood", TradeGoods.TradeGoodType.material), 30),
               new PriceListElement(new TradeGood("stone", TradeGoods.TradeGoodType.material), 35),
               new PriceListElement(new TradeGood("steel", TradeGoods.TradeGoodType.material), 40),
               new PriceListElement(new TradeGood("meat", TradeGoods.TradeGoodType.material), 17),
               new PriceListElement(new TradeGood("fish", TradeGoods.TradeGoodType.material), 19),
               new PriceListElement(new TradeGood("cheese", TradeGoods.TradeGoodType.material), 16),
               new PriceListElement(new TradeGood("apples", TradeGoods.TradeGoodType.material), 10),
               new PriceListElement(new TradeGood("bread", TradeGoods.TradeGoodType.material), 6),
               new PriceListElement(new TradeGood("salt", TradeGoods.TradeGoodType.material), 15),
               new PriceListElement(new TradeGood("wine", TradeGoods.TradeGoodType.material), 20),
               new PriceListElement(new TradeGood("beer", TradeGoods.TradeGoodType.material), 15),
               new PriceListElement(new TradeGood("mead", TradeGoods.TradeGoodType.material), 17));

            return defaultPriceList;
        }

        #endregion


        public PriceList( params PriceListElement[] priceListelements )
        {
            _priceList.AddRange(priceListelements);
        }

        private List<PriceListElement> _priceList = new List<PriceListElement>();
    }
}

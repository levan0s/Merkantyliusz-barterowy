using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MerkantyliuszBarterowy.Model
{
    class PriceList
    {
        public Dictionary<TradeGood, decimal> PriceListDictionary { get; set; }
        
        public decimal GetCashEquivalent(string tradeGoodName)
        {
            PriceListElement listElement = (PriceListElement)PriceListDictionary.Where(x => x.Key.Name == tradeGoodName);
            decimal cashEquivalent = listElement.CashEquivalent;
            return cashEquivalent;
        }

        public void SetCashEquivalent(string tradeGoodName, decimal cashEquivalent)
        {
            PriceListElement listElement = (PriceListElement)PriceListDictionary.Where(x => x.Key.Name == tradeGoodName);
            listElement.CashEquivalent = cashEquivalent;
        }

        public static PriceList GetDefaultPriceList()
        { 
            List<TradeGood> tradeGoodList = TradeGood.GetDefaultTradeGoodList();
            Dictionary<TradeGood, decimal> priceList = new Dictionary<TradeGood, decimal>();
            priceList.Add((TradeGood)tradeGoodList.Where(X => X.Name == "wood"), 30);
            priceList.Add((TradeGood)tradeGoodList.Where(X => X.Name == "stone"), 35);
            priceList.Add((TradeGood)tradeGoodList.Where(X => X.Name == "steel"), 40);
            priceList.Add((TradeGood)tradeGoodList.Where(X => X.Name == "fish"), 19);
            priceList.Add((TradeGood)tradeGoodList.Where(X => X.Name == "cheese"), 16);
            priceList.Add((TradeGood)tradeGoodList.Where(X => X.Name == "apples"), 10);
            priceList.Add((TradeGood)tradeGoodList.Where(X => X.Name == "bread"), 6);
            priceList.Add((TradeGood)tradeGoodList.Where(X => X.Name == "salt"), 15);
            priceList.Add((TradeGood)tradeGoodList.Where(X => X.Name == "wine"), 20);
            priceList.Add((TradeGood)tradeGoodList.Where(X => X.Name == "beer"), 15);
            priceList.Add((TradeGood)tradeGoodList.Where(X => X.Name == "mead"), 17);

            PriceList defaultPriceList = new PriceList();

            return defaultPriceList;
        }
    }
}

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
        public static List<TradeGood> GetDefaultTradeGoodList()
        {
            List<TradeGood> defalutTradeGoodList = new List<TradeGood>();
            defalutTradeGoodList.Add(new TradeGood("wood", TradeGoods.TradeGoodType.material));
            defalutTradeGoodList.Add(new TradeGood("stone", TradeGoods.TradeGoodType.material));
            defalutTradeGoodList.Add(new TradeGood("steel", TradeGoods.TradeGoodType.material));
            defalutTradeGoodList.Add(new TradeGood("meat", TradeGoods.TradeGoodType.material));
            defalutTradeGoodList.Add(new TradeGood("fish", TradeGoods.TradeGoodType.material));
            defalutTradeGoodList.Add(new TradeGood("cheese", TradeGoods.TradeGoodType.material));
            defalutTradeGoodList.Add(new TradeGood("apples", TradeGoods.TradeGoodType.material));
            defalutTradeGoodList.Add(new TradeGood("bread", TradeGoods.TradeGoodType.material));
            defalutTradeGoodList.Add(new TradeGood("salt", TradeGoods.TradeGoodType.material));
            defalutTradeGoodList.Add(new TradeGood("wine", TradeGoods.TradeGoodType.material));
            defalutTradeGoodList.Add(new TradeGood("beer", TradeGoods.TradeGoodType.material));
            defalutTradeGoodList.Add(new TradeGood("mead", TradeGoods.TradeGoodType.material));
            return defalutTradeGoodList;
         }
        
        private string _name;
        private TradeGoodType _tradeGoodType;
    }
   
}

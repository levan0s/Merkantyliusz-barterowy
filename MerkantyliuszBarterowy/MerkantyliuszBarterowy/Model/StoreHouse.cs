using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MerkantyliuszBarterowy.Model
{
    class StoreHouse
    {
        public StoreHouse(params Balance[] balances)
        {
            foreach (Balance balance in balances)
            {
                _balanceList.Add(balance);
            }
        }

        public void AddBalanceList(List<Balance> addList)
        {
            foreach (Balance addListElement in addList)
            {
                addElement(addListElement);
            }
            
        }

        public void SubstractBalanceList(List<Balance> substractList)
        {
            foreach (Balance substractListElement in substractList)
            { 
                removeElement(substractListElement);
            }
        }


        private void addElement(Balance addListElement)
        {
            bool isOnList = false;
            foreach (Balance bal in _balanceList)
            {
                if (bal.BalanceName == addListElement.BalanceName)
                { 
                    bal.Quantity += addListElement.Quantity;
                    isOnList = true;
                }
            }
            if (!isOnList)
            {
                _balanceList.Add(addListElement);
            }
        }

        private void removeElement(Balance substractListElement)
        {   
            foreach (Balance bal in _balanceList)
            {
                if (bal.BalanceName == substractListElement.BalanceName)
                {
                    bal.Quantity -= substractListElement.Quantity;
                }
            }
        }
        private List<Balance> _balanceList = new List<Balance>();
    }
}

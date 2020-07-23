using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Order
    {
        List<Item> orderList = new List<Item>();
        private int size = 0;
        private int indexRemove = 0;

        //constructor
        public Order()
        {

        }
        //add the item to the list
        public void AddItem(Item item)
        {
            orderList.Add(item);
        }
        //gets the drink list
        public List<Item> getItemList()
        {
            return orderList;

        }
        public int Size
        {
            get { return orderList.Count; }
        }
        public List<Item> removeItem(int indexRemove, int listSize)
        {
            orderList.RemoveAt(indexRemove);
            //for (int i = 0; i < listSize; i++)
            //{
            //    if (i == indexRemove)
            //    {
            //        orderList.RemoveAt(indexRemove);
            //    }

            //}
            return orderList;
        }
        public List<Item> clearOrder(int index)
        {
            //cleasr the entire order list
            for (int i = 0; i < orderList.Count; i++)
            {
                orderList.RemoveAt(indexRemove);
            }
            return orderList;
        }

    }
}

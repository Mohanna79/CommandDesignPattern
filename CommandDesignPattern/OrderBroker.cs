using CommandDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
     class OrderBroker
    {
        private  ordersList;

        public void AddOrder(IOrder order)
        {
            ordersList.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (var item in ordersList )
            {
                item.Execute();
            }
            ordersList.Clear();
        }
    }
}

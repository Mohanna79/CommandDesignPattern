using CommandDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    internal class OrderSell : IOrder
    {
        private Stock stock;
        public OrderSell(Stock stock)
        {
            this.stock = stock;
        }
        public void Execute()
        {
            stock.Sell();
        }
    }
}

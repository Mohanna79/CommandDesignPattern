using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    internal class Stock
    {
        public int Cnt { get; set; }
        public string Name { get; set; }

        public void Sell()
        {
            Console.WriteLine("Selling Order");
        }
        public void Buy()
        {
            Console.WriteLine("Buying Order");
        }
    }
}

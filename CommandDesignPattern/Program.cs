using CommandDesignPattern.Interfaces;
using System;

namespace CommandDesignPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            var modifyPrice = new ModifyPrice();
            var product = new Product("Phone", 500);

            #region Execute Queue commands for product price

            var commandList = new List();
            commandList.Add(new ProductCommand(product, PriceAction.Decrease, product.Price * 20 / 100));
            commandList.Add(new ProductCommand(product, PriceAction.Increase, product.Price * 9 / 100));

            ExecuteList(product, modifyPrice, commandList);

            Console.WriteLine(product);
            Console.WriteLine();

            modifyPrice.UndoActions();
            Console.WriteLine(product);

            #endregion

            string line = Console.ReadLine();
        }

        private static void Execute(Product product, ModifyPrice modifyPrice, ICommand productCommand)
        {
            modifyPrice.SetCommand(productCommand);
            modifyPrice.Invoke();
        }


        private static void ExecuteList(Product product, ModifyPrice modifyPrice, List productCommand)
        {
            foreach (var item in productCommand)
            {
                modifyPrice.SetCommand(item);
                modifyPrice.Invoke();
            }
        }
    }
}

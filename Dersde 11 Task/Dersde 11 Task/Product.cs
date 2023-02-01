using System;
using System.Collections.Generic;
using System.Text;
using Dersde_11_Task.Exaption;

namespace Dersde_11_Task
{
    internal class Product
    {
        public Product()
        {
            Count++;
            No = Count;
        }
        static int Count;
        public readonly int No;
        public string Category;
        private double _price;
        public double Price { set { if (value > 0) { _price = value; } else { throw new PriceCantBeMinusException(); } } get { return _price; } }

        public void ShowInfo()
        {
            Console.WriteLine($"\nMehsulun nomresi: {No}\nMehsulun kateqoriyasi: {Category}\nMehsulun qiymeti: {_price}\n");
        }

    }
}

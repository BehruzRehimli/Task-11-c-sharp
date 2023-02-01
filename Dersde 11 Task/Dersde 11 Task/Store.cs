using Dersde_11_Task.Exaption;
using System;

namespace Dersde_11_Task
{
    internal class Store
    {
        public Product[] Products=new Product[0];
        public void AddProduct(Product pr)
        {
            Array.Resize(ref Products,Products.Length+1);
            Products[Products.Length-1] = pr;
        }
        public bool HasProductByNo(int no)
        {
            foreach (var item in Products)
            {
                if (item.No==no)
                {
                    return true;
                }
            }
            return false;
        }
        public Product GetProductByNo(int no)
        {
            if (Products.Length==0)
            {
                throw new ThereIsNoProductException();
            }
            foreach (var item in Products)
            {
                if (item.No==no)
                {
                    return item;
                }
            }
            throw new ProductNotFoundException();
        }
        public void ShowAllProduct()
        {
            if (Products.Length!=0)
            {
                foreach (var item in Products) { Console.WriteLine($"\nMehsulun nomresi: {item.No}\nMehsulun kateqoriyasi: {item.Category}\nMehsulun qiymeti: {item.Price}\n\n"); }
            }
            else
            {
                throw new ThereIsNoProductException ();
            }

        }
    }
}

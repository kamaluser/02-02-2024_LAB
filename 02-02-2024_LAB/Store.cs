using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_02_2024_LAB
{
    internal class Store
    {
        public List<Product> products = new List<Product>();

        public void ApplyDiscount(List<Product> products)
        {
            foreach (var item in products)
            {
                if ((DateTime.Now - item.ExpireDate).TotalDays <= 3)
                {
                    item.SellPrice = item.SellPrice * 0.8;
                }
            }
        }

        public static void ShowProducts(List<Product> products)
        {
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
        }
    }
}

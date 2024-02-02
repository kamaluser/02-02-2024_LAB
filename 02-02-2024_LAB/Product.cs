using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02_02_2024_LAB
{
    internal class Product
    {
        public Product()
        {
            staticNo++;
            No = staticNo;
        }
        public Product(string name, double sellprice, DateTime expireDate):this()
        {
            Name = name;
            SellPrice = sellprice;
            ExpireDate = expireDate;
        }

        public int No;
        public static int staticNo;
        public string Name;
        public double CostPrice;
        public DateTime ExpireDate;
        public double SellPrice;
        public double Profit { get => SellPrice - CostPrice; }


        public override string ToString()
        {
            return $"{this.No} - {this.Name} - {this.SellPrice} - {this.ExpireDate.Date}";
        }
    }
}

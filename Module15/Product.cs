using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module15
{
    public class Product
    {
        private string _ProductName;
        public string ProductName 
        {
            get {return _ProductName; }
            set { _ProductName = value; }
        }
        private decimal _ProductPrice;
        public decimal ProductPrice
        {
            get {return _ProductPrice; }
            set {_ProductPrice = value; }
        }



        public Product(string ProductName,decimal Productprice)
            { this.ProductName = ProductName; this.ProductPrice = Productprice; }


    }
}

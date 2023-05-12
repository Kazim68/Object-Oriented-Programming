using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Brand
    {
        public string name;
        public int sales;
        public List<Product> products;

        // parameterized constructor
        public Brand(string name, List<Product> products)
        {
            this.name = name;
            this.sales = 0;
            this.products = products;
        }
    }
}

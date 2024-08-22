using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<IProduct> _products = new List<IProduct>();

        public void add(IProduct product)
        {
            _products.Add(product);
        }

        public int getTotal()
        {
            int total = 0;

            foreach (IProduct p in _products)
            {
                total += p.Price;
            }

            return total;
        }

        public bool isInBasket(String name)
        {
            foreach (IProduct p in _products)
            {
                if (p.Name.Equals(name))
                {
                    return true;
                }
            }

            return false;
        }
    }
}

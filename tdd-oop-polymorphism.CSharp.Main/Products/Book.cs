using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_polymorphism.CSharp.Main;

namespace Products
{
    public class Book : IProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Book(string name, int price)
        {
            Name = name;
            Price = price;
        }

       
    }
}

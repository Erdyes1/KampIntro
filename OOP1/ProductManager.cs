using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {                    //string name = gibi düsün!!!!
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "  Eklendi. ");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "  Güncellendi. ");
        }
        public void Remove(Product product)
        {
            Console.WriteLine(product.ProductName + "  SILINDI" ) ;
        }
        


    }
}

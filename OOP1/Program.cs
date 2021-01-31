using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CatagoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.unitInStock = 2;

            Product product2 = new Product() { ID = 2, CatagoryId = 3, UnitPrice = 500, ProductName = "kitap", unitInStock = 88 };
            Product product3 = new Product() { ID = 3, CatagoryId = 7, UnitPrice = 75, ProductName = "gözlük", unitInStock = 3505 };
            Product product4 = new Product() { ID = 4, CatagoryId = 3, UnitPrice = 175, ProductName = "kalem", unitInStock = 15 };
            Product product5 = new Product() { ID = 5, CatagoryId = 2, UnitPrice = 725, ProductName = "masha", unitInStock = 205 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);
            productManager.Add(product3);
            productManager.Add(product4);
            productManager.Add(product5);

            

        }
    }
}

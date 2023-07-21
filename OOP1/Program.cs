using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.unitsİnStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, unitsİnStock = 5, ProductName = "Kalem", UnitPrice = 35 };
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            productManager.Topla2(3, 5);
            int toplamaSonucu = productManager.Topla(3, 6);
            Console.WriteLine(toplamaSonucu * 2);
            Console.ReadLine();

        }
    }
}

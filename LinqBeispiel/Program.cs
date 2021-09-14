using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqBeispiel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get list with all products
            List<Product> productList = Product.CreateProducts();

            // Add some LINQ stuff here :-)
            productList = productList
                .Where(x => x.Category == "Tiefkühlware" || x.Category == "Obst")
                .OrderByDescending(x => x.Price)
                .ToList();

            decimal totalPrice = productList.Sum(x => x.Price);

            Console.WriteLine("Gesamtpreis: " + totalPrice + " EUR\n");

            // Write products in console
            foreach(Product product in productList)
            {
                string content = string.Format("{0} ({1}) | Preis: {2} EUR | Mindestens haltbar bis: {3}\n", 
                    product.Name, product.Category, product.Price, product.BestBeforeDate.ToShortDateString());

                Console.WriteLine(content);
            }
        }
    } 
}

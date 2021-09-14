using System;
using System.Collections.Generic;

namespace LinqBeispiel
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public DateTime BestBeforeDate { get; set; }

        public static List<Product> CreateProducts()
        {
            List<Product> list = new List<Product>()
            {
                new Product(){Name = "Apfel", Category = "Obst", Price = 0.45m, BestBeforeDate = Convert.ToDateTime("21.09.2021") },
                new Product(){Name = "Katzenfutter Trocken", Category = "Tiernahrung", Price = 3.99m, BestBeforeDate = Convert.ToDateTime("01.03.2022") },
                new Product(){Name = "Hundefutter Trocken", Category = "Tiernahrung", Price = 5.49m, BestBeforeDate = Convert.ToDateTime("22.06.2023") },
                new Product(){Name = "Banane", Category = "Obst", Price = 0.99m, BestBeforeDate = Convert.ToDateTime("29.09.2021") },
                new Product(){Name = "Tiefkühl Pizza", Category = "Tiefkühlware", Price = 2.39m, BestBeforeDate = Convert.ToDateTime("10.05.2022") },
                new Product(){Name = "Tiefkühl Fischfilet", Category = "Tiefkühlware", Price = 6.99m, BestBeforeDate = Convert.ToDateTime("12.02.2022") },
                new Product(){Name = "Tiefkühl Lasagne", Category = "Tiefkühlware", Price = 3.19m, BestBeforeDate = Convert.ToDateTime("28.07.2023") },
                new Product(){Name = "Katzenfutter Nass", Category = "Tiernahrung", Price = 2.99m, BestBeforeDate = Convert.ToDateTime("15.01.2022") },
                new Product(){Name = "Hundefutter Nass", Category = "Tiernahrung", Price = 3.49m, BestBeforeDate = Convert.ToDateTime("27.04.2022") },
                new Product(){Name = "Schlangengurke", Category = "Gemüse", Price = 0.30m, BestBeforeDate = Convert.ToDateTime("10.10.2021") }
            };

            return list;
        }
    }
}

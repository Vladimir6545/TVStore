using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TVStore.Models;

namespace TVStore.Helpers
{
    public class ApplicationDbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            Product tv1 = new Product { NameTV = "Samsung", Price = 500.00, Quantity = 3 };
            Product tv2 = new Product { NameTV = "LG", Price = 450.00, Quantity = 2 };
            Product tv3 = new Product { NameTV = "Berezka", Price = 1400.35, Quantity = 1 };
            Product tv4 = new Product { NameTV = "Orion", Price = 800.00, Quantity = 30 };
            Product tv5 = new Product { NameTV = "BBS", Price = 700.00, Quantity = 8 };
            Product tv6 = new Product { NameTV = "Panasonic", Price = 750.00, Quantity = 6 };
            Product tv7 = new Product { NameTV = "Philips", Price = 650.55, Quantity = 44 };
            Product tv8 = new Product { NameTV = "Akai", Price = 633.03, Quantity = 7 };

            context.Products.Add(tv1);
            context.Products.Add(tv2);
            context.Products.Add(tv3);
            context.Products.Add(tv4);
            context.Products.Add(tv5);
            context.Products.Add(tv6);
            context.Products.Add(tv7);
            context.Products.Add(tv8);

        }
    }
}
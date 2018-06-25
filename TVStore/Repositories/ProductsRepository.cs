using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TVStore.Helpers;
using TVStore.Models;

namespace TVStore.Repositories
{
    public class ProductsRepository
    {
        public List<Product> GetProducts()
        {
            using (var db = ApplicationDbContext.Create())
            {
                return db.Products
                    .ToList();
            }
        }
    }
}
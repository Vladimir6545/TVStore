using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TVStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string NameTV { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
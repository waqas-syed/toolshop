using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToolShop.Model.Models
{
    public class Product
    {
        public Product()
        {
            DateCreated = DateTime.Now;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public DateTime DateCreated { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToolShop.Model.Models
{
    /// <summary>
    /// Category
    /// </summary>
    public class Category
    {
        public Category()
        {
            DateCreated = DateTime.Now;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual IList<Product> Products { get; set; }
    }
}
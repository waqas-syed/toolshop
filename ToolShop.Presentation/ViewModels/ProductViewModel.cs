using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToolShop.Presentation.ViewModels
{
    /// <summary>
    /// Represents the Product entity in the view
    /// </summary>
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public CategoryViewModel Category { get; set; }
    }
}
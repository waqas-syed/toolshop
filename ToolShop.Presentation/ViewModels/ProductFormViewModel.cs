using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToolShop.Presentation.ViewModels
{
    /// <summary>
    /// Represents the ViewModel which is used to post a new Product or to update an existing product
    /// </summary>
    public class ProductFormViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public int CategoryId { get; set; }
    }
}
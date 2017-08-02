using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToolShop.Presentation.ViewModels
{
    /// <summary>
    /// Represents the Category entity in the View
    /// </summary>
    public class CategoryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IList<ProductViewModel> Products { get; set; }
    }
}
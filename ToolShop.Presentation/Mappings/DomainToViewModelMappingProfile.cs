using AutoMapper;
using ToolShop.Model.Models;
using ToolShop.Presentation.ViewModels;

namespace ToolShop.Presentation.Mappings
{
    /// <summary>
    /// Mapping for AutoMapper between Category and CategoryViewModel
    /// </summary>
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Category, CategoryViewModel>();
            CreateMap<Product, ProductViewModel>();
        }

        public override string ProfileName
        {
            get { return "CategoryToCategoryViewModelMappings"; }
        }
    }
}
using AutoMapper;
using ToolShop.Model.Models;
using ToolShop.Presentation.ViewModels;

namespace ToolShop.Presentation.Mappings
{
    /// <summary>
    /// Mapping for AutoMapper between Product and ProductViewModel
    /// </summary>
    public class ViewModelToModelMappingProfile : Profile
    {
        public ViewModelToModelMappingProfile()
        {
            CreateMap<CategoryViewModel, Category>();
            CreateMap<ProductViewModel, Product>();
            CreateMap<ProductFormViewModel, Product>()
                .ForMember(p => p.Id, map => map.MapFrom(f => f.CategoryId))
                .ForMember(p => p.Name, map => map.MapFrom(f => f.ProductName))
                .ForMember(p => p.Description, map => map.MapFrom(f => f.ProductDescription))
                .ForMember(p => p.CategoryId, map => map.MapFrom(f => f.CategoryId))
                .ForMember(p => p.Price, map => map.MapFrom(x => x.ProductPrice));
        }

        public override string ProfileName
        {
            get { return "ProductToProductViewModelMappings"; }
        }
    }
}
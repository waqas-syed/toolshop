using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace ToolShop.Presentation.Mappings
{
    /// <summary>
    /// Specifies the classes that will need to be mapped to each other
    /// </summary>
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToModelMappingProfile>();
            });
        }
    }
}
using AutoMapper;
using ExampleProject.Back.Core.Application.Dto;
using ExampleProject.Back.Core.Domain;

namespace ExampleProject.Back.Core.Application.Mappings
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            this.CreateMap<Product,ProductListDto>().ReverseMap();
        }
    }
}

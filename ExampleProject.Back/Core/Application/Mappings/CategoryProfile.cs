using AutoMapper;
using ExampleProject.Back.Core.Application.Dto;
using ExampleProject.Back.Core.Domain;

namespace ExampleProject.Back.Core.Application.Mappings
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            this.CreateMap<Category,CategoryListDto>().ReverseMap();
        }
    }
}

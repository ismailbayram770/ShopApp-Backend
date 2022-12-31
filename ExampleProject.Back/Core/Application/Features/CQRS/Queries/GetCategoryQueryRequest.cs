using ExampleProject.Back.Core.Application.Dto;
using MediatR;

namespace ExampleProject.Back.Core.Application.Features.CQRS.Queries
{
    public class GetCategoryQueryRequest:IRequest<CategoryListDto>
    {
        public int Id { get; set; }

        public GetCategoryQueryRequest(int id)
        {
            Id= id;
        }

    }
}

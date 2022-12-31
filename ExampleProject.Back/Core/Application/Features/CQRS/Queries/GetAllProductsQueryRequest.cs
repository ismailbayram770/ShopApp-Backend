using ExampleProject.Back.Core.Application.Dto;
using MediatR;

namespace ExampleProject.Back.Core.Application.Features.CQRS.Queries
{
    public class GetAllProductsQueryRequest:IRequest<List<ProductListDto>>
    {

    }
}

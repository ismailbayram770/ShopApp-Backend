using MediatR;

namespace ExampleProject.Back.Core.Application.Features.CQRS.Commands
{
    public class CreateCategoryCommandRequest:IRequest
    {
        public string? Definition { get; set; }
    }
}

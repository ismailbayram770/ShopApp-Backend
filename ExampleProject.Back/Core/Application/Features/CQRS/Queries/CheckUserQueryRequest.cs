using ExampleProject.Back.Core.Application.Dto;
using MediatR;

namespace ExampleProject.Back.Core.Application.Features.CQRS.Queries
{
    public class CheckUserQueryRequest:IRequest<CheckUserResponseDto>
    {
        public string Username { get; set; } = null !;
        public string Password { get; set; } = null!;
    }
}

using ExampleProject.Back.Core.Application.Features.CQRS.Commands;
using ExampleProject.Back.Core.Application.Features.CQRS.Queries;
using ExampleProject.Back.Infrastructure.Tools;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleProject.Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator mediator;

        public AuthController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Register(RegisterUserCommandRequest request)
        {
            await this.mediator.Send(request);
            return Created("",request);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(CheckUserQueryRequest request)
        {
            var dto=await this.mediator.Send(request);
            if (dto.IsExist)
            {

                return Created("",JwtTokenGenerator.GenerateToken(dto));
            }
            else
            {
                return BadRequest("Kullanıcı adi veya şifre hatalı");
            }
        }


    }
}

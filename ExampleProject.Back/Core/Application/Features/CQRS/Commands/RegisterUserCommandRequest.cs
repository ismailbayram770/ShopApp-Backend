﻿using MediatR;

namespace ExampleProject.Back.Core.Application.Features.CQRS.Commands
{
    public class RegisterUserCommandRequest:IRequest
    {
        public string? Username { get; set; }
        public string? Password { get; set; }

    }
}

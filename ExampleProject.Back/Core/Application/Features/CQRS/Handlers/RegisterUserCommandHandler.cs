﻿using ExampleProject.Back.Core.Application.Enums;
using ExampleProject.Back.Core.Application.Features.CQRS.Commands;
using ExampleProject.Back.Core.Application.Interfaces;
using ExampleProject.Back.Core.Domain;
using MediatR;

namespace ExampleProject.Back.Core.Application.Features.CQRS.Handlers
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommandRequest>
    {
        private readonly IRepository<AppUser> repository;

        public RegisterUserCommandHandler(IRepository<AppUser> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(RegisterUserCommandRequest request, CancellationToken cancellationToken)
        {
            await this.repository.CreateAsync(new AppUser
            {
                Password = request.Password,
                Username = request.Username,
                AppRoleId = (int)RoleType.Member
            }) ;
            return Unit.Value;
        }
    }
}
